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
        List<int> positionCarteEnleve = new List<int>();
        //List<bool> PanelRempi = new List<bool>();
        //bool[] PanelRempi = new bool[8];
        int nbCartes = 0;
        int creditsWaged = 0;

        public PazaakCardsSelector()
        {
            InitializeComponent();
            FillListPanels();
            //InitializeArrayBool();
        }

        internal Player Player1 { get => playerCBS; set => playerCBS = value; }

        //private void InitializeArrayBool()
        //{
        //    for (int i = 0; i < PanelRempi.Length; i++)
        //    {
        //        PanelRempi[i] = false;
        //    }
        //}

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
            Hide();
            Pazaak newPazaakGame = new Pazaak();
            newPazaakGame.Player1 = playerCBS;
            newPazaakGame.CreditsWaged = int.Parse(MTxtBoxWager.Text);
            newPazaakGame.ShowDialog();
            this.Close();
        }

        private void AddAvailableCards_Click(object sender, EventArgs e)
        {
            RoundPanel roundPanel = sender as RoundPanel;
           // int numberCards = CheckDeck();
            //MessageBox.Show(nbCartes.ToString());
            if (positionCarteEnleve.Count == 0)
            {
                if (nbCartes < 10)
                {
                    playerDeck.ElementAt(nbCartes).BackgroundImage = roundPanel.BackgroundImage;
                    nbCartes++;
                }
               
                    //PanelRempi[nbCartes] = true;
            }
            else
            {
                    //MessageBox.Show(positionCarteEnleve.ElementAt(1).ToString());
                    playerDeck.ElementAt(positionCarteEnleve.ElementAt(0)).BackgroundImage = roundPanel.BackgroundImage;
                    positionCarteEnleve.RemoveAt(0);
                    nbCartes++;
            }
            //if (nbCartes == 10)
            //{
            //    BtnEllReady.Enabled = true;
            //}
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
             
            //if (roundPanel.BackgroundImage != null)
            //{
            //    roundPanel.BackgroundImage = null;
            //    BtnEllReady.Enabled = false;
            //    int pos = CheckHoleDeck();
            //    //MessageBox.Show(pos.ToString());
            //    positionCarteEnleve.Add(pos);
            //}
        }

        //public int CheckHoleDeck()
        //{
        //    int index = 0;
        //    for (int i = 0; i < playerDeck.Count(); i++)
        //    {
        //        if (playerDeck.ElementAt(i).BackgroundImage == null)
        //        {
        //            //PanelRempi[i] = false;
        //            index = i;
        //            return index;
        //        }
        //    }
        //    return index;
        //}

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
        }
    }
}
