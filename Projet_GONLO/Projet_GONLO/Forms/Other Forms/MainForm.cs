using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public partial class MainForm : Form
    {
        //Global Variables
        Player player1 = new Player();
        SoundPlayer sound = new SoundPlayer(Properties.Resources.Cantina_Band);
        bool etatWelcome = true;
        bool etatGonlo = true;
        int len1;
        int len2;
        string txt1;
        string txt2;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            sound.PlayLooping();
            // player1 = player;
        }

        /// <summary>
        /// Property that grants the form a Player object
        /// </summary>
        internal Player Player1 { get => player1; set => player1 = value; }

        /// <summary>
        /// This method sets the default form when it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuAccueil_Load(object sender, EventArgs e)
        {
            txt1 = LblWelcome.Text;
            txt2 = LblGonlo.Text;
            len1 = txt1.Length;
            len2 = txt2.Length;
            LblPlayerName.Text = player1.Name;
            LblPlayerSpecies.Text = player1.Species;
            LblPlayerCredits.Text = player1.Credits.ToString();
            LblNbPGW.Text = player1.PazaakGamesWon.ToString();
            LblNbPGL.Text = player1.PazaakGamesLost.ToString();
            LblNbDGW.Text = player1.DejarikGamesWon.ToString();
            LblNbDGL.Text = player1.DejarikGamesLost.ToString();
            RPnlPazaak.Hide();
            RPnlDejarik.Hide();
            RPnlSBR.Hide();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>
        /// This click event method shows the Pazaak's informations panel and hides the others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllPazaak_Click(object sender, EventArgs e)
        {
            RPnlDejarik.Hide();
            RPnlSBR.Hide();
            RPnlPazaak.Show();
            this.Refresh();
        }

        /// <summary>
        /// This click event method shows the Dejarik's informations panel and hides the others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllDejarik_Click(object sender, EventArgs e)
        {
            RPnlPazaak.Hide();
            RPnlSBR.Hide();
            RPnlDejarik.Show();
            this.Refresh();
        }

        /// <summary>
        /// This click event method shows the Swoop Bike Racing's informations panel and hides the others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllSB_Click(object sender, EventArgs e)
        {
            RPnlPazaak.Hide();
            RPnlDejarik.Hide();
            RPnlSBR.Show();
            this.Refresh();
        }

        /// <summary>
        /// This click event method closes the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method makes the labels on top of the form move left to right
        /// and changes the font of the text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerSlide1_Tick(object sender, EventArgs e)
        {
            //label1
            if (LblWelcome.Left < this.Width)
            {
                LblWelcome.Left += 5;
            }
            else
            {
                if (etatWelcome == true)
                {
                    LblWelcome.Font = new Font("Aurek-Besh", 14);
                    LblWelcome.Left = -1300;
                    etatWelcome = false;
                }
                else
                {
                    LblWelcome.Left = -1200;
                    LblWelcome.Font = new Font("SF Distant Galaxy Alternate", 25);
                    etatWelcome = true;
                } 
            }

            //label2
            if (LblGonlo.Left < this.Width)
            {
                LblGonlo.Left += 5;
            }
            else
            {
                if (etatGonlo == true)
                {
                    LblGonlo.Font = new Font("Aurek-Besh", 14);
                    LblGonlo.Left = -1300;
                    etatGonlo = false;
                }
                else
                {
                    LblGonlo.Left = -1200;
                    LblGonlo.Font = new Font("SF Distant Galaxy Alternate", 25);
                    etatGonlo = true;
                }
            }
        }

        /// <summary>
        /// This click event method closes the MenuAccueil form and opens the Pazaak Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllPlayPazaak_Click(object sender, EventArgs e)
        {
            sound.Stop();
            Hide();
            PazaakCardsSelector pazaakCards = new PazaakCardsSelector();
            pazaakCards.Player1 = player1;
            pazaakCards.ShowDialog();
            this.Close();

        }

        /// <summary>
        /// This click event method closes the MenuAccueil form and opens the Dejarik Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllPlayDejarik_Click(object sender, EventArgs e)
        {
            sound.Stop();
            Hide();
            MenuDejarik menuDejarik = new MenuDejarik();
            menuDejarik.Player1 = player1;
            menuDejarik.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// This click event method expands the player's information board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGBoxPI_Click(object sender, EventArgs e)
        {
            if (GBoxPlayerInfo.Height == 460)
            {
                GBoxPlayerInfo.Height = 280;
                BtnGBoxPI.BackgroundImage = Properties.Resources.arrows;
            }
            else if (GBoxPlayerInfo.Height == 280)
            {
                GBoxPlayerInfo.Height = 460;
                BtnGBoxPI.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }
    }
}
