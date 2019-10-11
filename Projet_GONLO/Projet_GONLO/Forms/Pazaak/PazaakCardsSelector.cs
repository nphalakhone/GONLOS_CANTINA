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
        List<RoundPanel> playerDeck = new List<RoundPanel>();
        List<int> positionCarteEnleve = new List<int>();
        int nbCartes = 0;


        public PazaakCardsSelector()
        {
            InitializeComponent();
            FillListPanels();
        }

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
            newPazaakGame.ShowDialog();
            this.Close();
        }

        private void AddAvailableCards_Click(object sender, EventArgs e)
        {
            RoundPanel roundPanel = sender as RoundPanel;
           // int numberCards = CheckDeck();
            //MessageBox.Show(nbCartes.ToString());
            if (nbCartes < 10)
            {
                if (positionCarteEnleve.Count == 0)
                {
                    playerDeck.ElementAt(nbCartes).BackgroundImage = roundPanel.BackgroundImage;
                }
                else
                {
                    playerDeck.ElementAt(positionCarteEnleve.ElementAt(1)).BackgroundImage = roundPanel.BackgroundImage;
                }

                nbCartes++;
            }
            if (nbCartes == 10)
            {
                BtnEllReady.Enabled = true;
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
                int pos = CheckHoleDeck();
                //MessageBox.Show(pos.ToString());
                positionCarteEnleve.Add(pos);
            }
        }

        public int CheckHoleDeck()
        {
            int index = 0;
            for (int i = 0; i < playerDeck.Count(); i++)
            {
                if (playerDeck.ElementAt(i).BackgroundImage == null)
                {
                    index = i;
                    return index;
                }
            }
            return index;
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
    }
}
