using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public partial class PazaakCardsSelector : Form
    {
        Player playerCBS = new Player();
        List<RoundPanel> playerDeck = new List<RoundPanel>();
        List<Image> playerDeckImage = new List<Image>();
        List<int> positionCarteEnleve = new List<int>();
        int nbCartes = 0;
        int creditsWaged = 0;

        public PazaakCardsSelector()
        {
            InitializeComponent();
            FillListPanels();
        }

        internal Player Player1 { get => playerCBS; set => playerCBS = value; }


        internal List<Image> Player1Deck { get => playerDeckImage; set => playerDeckImage = value; }

        public void FillListPanels()
        {
            playerDeck.Add(RPnlPlayerDC1);
            playerDeck.Add(RPnlPlayerDC2);
            playerDeck.Add(RPnlPlayerDC3);
            playerDeck.Add(RPnlPlayerDC4);
            playerDeck.Add(RPnlPlayerDC5);
            playerDeck.Add(RPnlPlayerDC6);
            playerDeck.Add(RPnlPlayerDC7);
            playerDeck.Add(RPnlPlayerDC8);
            playerDeck.Add(RPnlPlayerDC9);
            playerDeck.Add(RPnlPlayerDC10);
        }

        private void BtnEllReady_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < playerDeck.Count; i++)
            {
                playerDeckImage.Add(playerDeck[i].BackgroundImage);
            }
            Hide();
            Pazaak newPazaakGame = new Pazaak(playerDeckImage);
            newPazaakGame.Player1 = playerCBS;
            newPazaakGame.CreditsWaged = int.Parse(MTxtBoxWager.Text);
            newPazaakGame.ShowDialog();
            this.Close();
        }

        private void AddAvailableCards_Click(object sender, EventArgs e)
        {
            RoundPanel roundPanel = sender as RoundPanel;
            if (positionCarteEnleve.Count == 0)
            {
                if (nbCartes < 10)
                {
                    playerDeck.ElementAt(nbCartes).BackgroundImage = roundPanel.BackgroundImage;
                    nbCartes++;
                }
            }
            else
            {
                playerDeck.ElementAt(positionCarteEnleve.ElementAt(0)).BackgroundImage = roundPanel.BackgroundImage;
                positionCarteEnleve.RemoveAt(0);
                nbCartes++;
            }
            if (nbCartes > 10)
            {
                MessageBox.Show("You have the maximum cards allowed");
            }
        }

        private void RemoveDeckCards(object sender, EventArgs e)
        {
            RoundPanel roundPanel = sender as RoundPanel;
            if (roundPanel.BackgroundImage != null)
            {
                roundPanel.BackgroundImage = null;
                BtnEllReady.Enabled = false;
                //int pos = CheckHoleDeck();
                int idx = playerDeck.IndexOf(roundPanel);
                MessageBox.Show(idx.ToString());
                positionCarteEnleve.Add(idx);
                nbCartes--;
            }
        }

        public int CheckDeck()
        {
            int numberCards = 0;
            foreach (var card in playerDeck)
            {
                if (card.BackgroundImage != null)
                {
                    numberCards++;
                }
            }
            return numberCards;
        }

        private void PazaakCardsSelector_Load(object sender, EventArgs e)
        {
            BtnEllReady.Enabled = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAccueil menu = new MenuAccueil();
            menu.Player1 = playerCBS;
            menu.ShowDialog();
            this.Close();
        }

        private void MTxtBoxWager_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DialogResult result = MessageBox.Show("You have to write down a number", "ATTENTION");
        }

        private void MTxtBoxWager_TextChanged(object sender, EventArgs e)
        {
            BtnEllReady.Enabled = true;
            if (MTxtBoxWager.Text == null)
            {
                BtnEllReady.Enabled = false;
            }
        }

        public List<string> getCardValue()
        {
            List<string> listCards = new List<string>();
            listCards.Add(getMinusValue());
            listCards.Add(getPlusValue());
            listCards.Add(getPlusMinusValue());
            return listCards;
        }

        private string getPlusValue()
        {
            string plus = "";
            for (int i = 0; i < playerDeckImage.Count; i++)
            {
                if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus1))
                {
                    plus = "+1";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus2))
                {
                    plus = "+2";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus3))
                {
                    plus = "+3";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus4))
                {
                    plus = "+4";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus5))
                {
                    plus = "+5";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus6))
                {
                    plus = "+6";
                }
            }
            return plus;
        }

        private string getMinusValue()
        {
            string minus = "";
            for (int i = 0; i < playerDeckImage.Count; i++)
            {
                if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus1))
                {
                    minus = "-1";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus2))
                {
                    minus = "-2";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus3))
                {
                    minus = "-3";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus4))
                {
                    minus = "-4";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus5))
                {
                    minus = "-5";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus6))
                {
                    minus = "-6";
                }
            }
            return minus;
        }
        private string getPlusMinusValue()
        {
            string plusMinus = "";
            for (int i = 0; i < playerDeckImage.Count; i++)
            {
                if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus1))
                {
                    plusMinus = "+-1";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus2))
                {
                    plusMinus = "+-2";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus3))
                {
                    plusMinus = "+-3";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus4))
                {
                    plusMinus = "+-4";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus5))
                {
                    plusMinus = "+-5";
                }
                else if (playerDeckImage.ElementAt(i).Equals(Properties.Resources.CartePlus6))
                {
                    plusMinus = "+-6";
                }
            }
            return plusMinus;
        }
    }
}
