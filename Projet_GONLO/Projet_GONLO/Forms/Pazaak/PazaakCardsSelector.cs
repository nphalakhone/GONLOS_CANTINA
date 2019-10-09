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
            int numberCards = CheckDeck();
            if (numberCards < 10)
            {
                playerDeck.ElementAt(numberCards).BackgroundImage = roundPanel.BackgroundImage;
            }
            else if (numberCards > 8)
            {
                BtnEllReady.Enabled = true;
            }
            else
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
