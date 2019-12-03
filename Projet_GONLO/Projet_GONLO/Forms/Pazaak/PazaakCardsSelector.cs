using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public partial class PazaakCardsSelector : Form
    {
        Player playerCBS = new Player();
        List<RoundPanel> playerDeck = new List<RoundPanel>();
        SoundPlayer sound = new SoundPlayer(Properties.Resources.Pazzak_Cantina);

        List<Image> playerDeckImage = new List<Image>();
        List<int> positionCarteEnleve = new List<int>();
        int nbCartes = 0;
        int creditsWaged = 0;

        List<Panel> listeCarteTotal = new List<Panel>();


        //List<int> carteIntEnvoye = new List<int>();
        int[] carteIntEnvoye = new int[10];

        public PazaakCardsSelector()
        {
            InitializeComponent();
            sound.PlayLooping();
            FillListPanels();
        }

        public Player Player1 { get => playerCBS; set => playerCBS = value; }
        //internal

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


            listeCarteTotal.Add(RPnlPlus1);
            listeCarteTotal.Add(RPnlPlus2);
            listeCarteTotal.Add(RPnlPlus3);
            listeCarteTotal.Add(RPnlPlus4);
            listeCarteTotal.Add(RPnlPlus5);
            listeCarteTotal.Add(RPnlPlus6);

            listeCarteTotal.Add(RPnlMinus1);
            listeCarteTotal.Add(RPnlMinus2);
            listeCarteTotal.Add(RPnlMinus3);
            listeCarteTotal.Add(RPnlMinus4);
            listeCarteTotal.Add(RPnlMinus5);
            listeCarteTotal.Add(RPnlMinus6);

            listeCarteTotal.Add(RPnlPlusMinus1);
            listeCarteTotal.Add(RPnlPlusMinus2);
            listeCarteTotal.Add(RPnlPlusMinus3);
            listeCarteTotal.Add(RPnlPlusMinus4);
            listeCarteTotal.Add(RPnlPlusMinus5);
            listeCarteTotal.Add(RPnlPlusMinus6);

        }

        private void BtnEllReady_Click(object sender, EventArgs e)
        {
            //if (playerDeck.Count() != 10 || (MTxtBoxWager.Text.Equals("")))
            //{
            //    BtnEllReady.Enabled = false;
            //}
            for (int i = 0; i < playerDeck.Count; i++)
            {
                playerDeckImage.Add(playerDeck[i].BackgroundImage);
            }
            Hide();
            Pazaak newPazaakGame = new Pazaak(playerDeckImage, carteIntEnvoye);
            newPazaakGame.Player1 = playerCBS;


            newPazaakGame.CreditsWaged = int.Parse(MTxtBoxWager.Text);
            newPazaakGame.ShowDialog();   
            this.Close();
        }

        private void AddAvailableCards_Click(object sender, EventArgs e)
        {
            RoundPanel roundPanel = sender as RoundPanel;
            int position = FindPositionPanel(roundPanel);
            
            if (positionCarteEnleve.Count == 0)
            {
                if (nbCartes < 10)
                {
                    playerDeck.ElementAt(nbCartes).BackgroundImage = roundPanel.BackgroundImage;
                    //carteIntEnvoye.Add(position);
                    carteIntEnvoye[nbCartes] = position;
                    nbCartes++;
                }
            }
            else
            {
                playerDeck.ElementAt(positionCarteEnleve.ElementAt(0)).BackgroundImage = roundPanel.BackgroundImage;
                //carteIntEnvoye.Add(position);
                carteIntEnvoye[positionCarteEnleve[0]] = position;
                positionCarteEnleve.RemoveAt(0);
                nbCartes++;
            }
            if (nbCartes > 10)
            {
                MessageBox.Show("You have the maximum cards allowed");
            }



            if (AllCardsSelected() && MTxtBoxWager.Text != "")
            {
                BtnEllReady.Enabled = true;
            }
            else
            {
                BtnEllReady.Enabled = false;
            }

        }

        private bool AllCardsSelected()
        {
            for (int i = 0; i < playerDeck.Count; i++)
            {
                if (playerDeck[i].BackgroundImage == null)
                {
                    return false;
                }
            }
            return true;
        }

        private int FindPositionPanel(RoundPanel roundPanel)
        {
            for (int i = 0; i < listeCarteTotal.Count; i++)
            {
                if (roundPanel.BackgroundImage == listeCarteTotal[i].BackgroundImage)
                {
                    return i;
                }
            }
            return -1;
        }

        private void RemoveDeckCards(object sender, EventArgs e)
        {
            RoundPanel roundPanel = sender as RoundPanel;
            if (roundPanel.BackgroundImage != null)
            {
                int idx = playerDeck.IndexOf(roundPanel);
                RemoveElementInt(roundPanel, idx);
                roundPanel.BackgroundImage = null;
                BtnEllReady.Enabled = false;
                
                //MessageBox.Show(idx.ToString());
               
                positionCarteEnleve.Add(idx);
                nbCartes--;
            }
            //BtnEllReady.Enabled = false;

        }

        private void RemoveElementInt(RoundPanel roundPanel, int idx)
        {
            int position = FindPositionPanel(roundPanel);
            carteIntEnvoye[idx] = 100;
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
            sound.Stop();
            this.Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm menu = new MainForm();
            menu.Player1 = playerCBS;
            menu.ShowDialog();
            this.Close();
        }

        private void MTxtBoxWager_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DialogResult result = MessageBox.Show("You have to write down a number", "ATTENTION");
            MTxtBoxWager.Text = "";
        }

        private void MTxtBoxWager_TextChanged(object sender, EventArgs e)
        {
            if (MTxtBoxWager.Text != "" && AllCardsSelected())
            {
                BtnEllReady.Enabled = true;
            }
            else
            {
                BtnEllReady.Enabled = false;
            }
            
        }

    }
}