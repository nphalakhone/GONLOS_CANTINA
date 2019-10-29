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
    public partial class Pazaak : Form
    {
        Player playerPazaak = new Player();
        Cards c = new Cards();
        Image[] playerDeck = new Image[4];
        Panel[] panelPlayerDeck;
        Panel[] panelAiDeck;
        Panel[] TabPanelLeft;
        Panel[] TabPanelRight;
        int credsWaged;

        Random rand = new Random();

        //  THESE VARIABLES ARE TEMPORAIRY WE  //
        //   WILL USE OTHER VARIABLES LATER    //
        //   WHEN PLAYER CLASS IS IMPLEMENTED  //
        int PlayerPoints = 0;
        int AiPoints = 0;
        
        // player = 0  Ai = 1
        int turn = 0;

        //number of cards which 
        //are on their side of the board
        int nbCardsPlayer = 0;
        int nbCardsAi = 0;

        bool playerStand = false;
        bool AiStand = false;


        public Pazaak()
        {
            InitializeComponent();
            //sample deck
            setupPlayerdeck();
            setupBoard();
        }
        internal int CreditsWaged { set => credsWaged = value; }
        internal Player Player1 { get => playerPazaak; set => playerPazaak = value; }

        private void setupBoard()
        {
            TabPanelLeft = new Panel[]
            {
             RPnlG1, RPnlG2, RPnlG3, RPnlG4, RPnlG5, RPnlG6, RPnlG7, RPnlG8,RPnlG9
            };
            TabPanelRight= new Panel[]
            {
             RPnlD1, RPnlD2, RPnlD3, RPnlD4, RPnlD5, RPnlD6, RPnlD7, RPnlD8,RPnlD9
            };
        }

        private void setupPlayerdeck()
        {
            playerDeck[0] = c.getCartePlus(4);
            playerDeck[1] = c.getCarteMinus(3);
            playerDeck[2] = c.getCartePlusMinus(2);
            playerDeck[3] = c.getCartePlus(5);

            panelPlayerDeck = new Panel[]
            {
             RPnlDownG1, RPnlDownG2, RPnlDownG3, RPnlDownG4
            };
            for (int i = 0; i < panelPlayerDeck.Length; i++)
            {
                panelPlayerDeck[i].BackgroundImage = playerDeck[i];
                panelPlayerDeck[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void End_Turn_Click(object sender, EventArgs e)
        {
            int pointsAdded = rand.Next(1, 11);
            if (turn == 0 && !playerStand) //player
            {
                CPBoxAI.BackColor = Color.Black;
                CPBoxPlayer.BackColor = Color.Maroon;
                TabPanelLeft[nbCardsPlayer].BackgroundImage = c.getCarteNormal(pointsAdded);
                TabPanelLeft[nbCardsPlayer].BackgroundImageLayout = ImageLayout.Stretch;
                nbCardsPlayer++;
                PlayerPoints += pointsAdded;
                LblPointsPlayer.Text = PlayerPoints.ToString();
                if (!AiStand)
                {
                    turn = 1;
                }
            }
            else if(turn == 1 && !AiStand)
            {
                CPBoxAI.BackColor = Color.Maroon;
                CPBoxPlayer.BackColor = Color.Black;
                TabPanelRight[nbCardsAi].BackgroundImage = c.getCarteNormal(pointsAdded);
                TabPanelRight[nbCardsAi].BackgroundImageLayout = ImageLayout.Stretch;
                nbCardsAi++;
                AiPoints += pointsAdded;
                LblPointsAi.Text = AiPoints.ToString();
                if (!playerStand)
                {
                    turn = 0;
                }
            }
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            
            if (turn == 0)
            {
                playerStand = true;
                turn = 1;
            }
            else if (turn == 1)
            {
                AiStand = true;
                turn = 0;
            }

            if (AiStand && playerStand)
            {
                FindWinner();
            }

        }

        private void FindWinner()
        {

            if (AiPoints == PlayerPoints)
            {
                MessageBox.Show("Egalite");
            }
               else if (AiPoints < 20 && PlayerPoints < 20)
            {
                if (differenceFrom20(AiPoints) < differenceFrom20(PlayerPoints))
                {
                    MessageBox.Show("Ai gagne!!");
                }
                else
                {
                    MessageBox.Show("Player gagné!!");
                }
            }
            else if (AiPoints > 20 && PlayerPoints > 20)
            {
                if (AiPoints < PlayerPoints)
                {
                    MessageBox.Show("Player gagné!!");
                }
                else
                {
                    MessageBox.Show("Ai gagne!!");
                }
            }
            else if (AiPoints < 20 && PlayerPoints > 20)
            {
                MessageBox.Show("Ai gagne!!");
            }
            else
            {
                MessageBox.Show("Player gagné!!");
            }


               // differenceFrom20(PlayerPoints);
        }

        private int differenceFrom20(int points)
        {
            return 20 - points;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pazaak newPazaakGame = new Pazaak();
            newPazaakGame.Player1 = playerPazaak;
            newPazaakGame.ShowDialog();
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RPnlForfeitGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to forfeit and quit the game ?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void Pazaak_Load(object sender, EventArgs e)
        {
            LblNumeric1.Hide();
            LblNumeric2.Hide();
            LblNumeric3.Hide();
            LblNumeric4.Hide();
            LblMinusValue1.Hide();
            LblMinusValue2.Hide();
            LblMinusValue3.Hide();
            LblMinusValue4.Hide();
            LblPlusValue1.Hide();
            LblPlusValue2.Hide();
            LblPlusValue3.Hide();
            LblPlusValue4.Hide();
            LblFlipCard1.Hide();
            LblFlipCard2.Hide();
            LblFlipCard3.Hide();
            LblFlipCard4.Hide();
            LblCreditsWagedNumeric.Text = credsWaged.ToString();
            LblPlayerName.Text = playerPazaak.Name;
            LblCreditsNumeric.Text = playerPazaak.Credits.ToString();
        }
    }
}
