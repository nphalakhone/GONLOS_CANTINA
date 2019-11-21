using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projet_GONLO
{

    enum Move { Stand, End_Turn, AddCard1, AddCard2, AddCard3, AddCard4 };

    public partial class Pazaak : Form
    {
        List<Image> playerDeckPazaak = new List<Image>();
        List<int> carteIntEnvoye = new List<int>();
        List<int> ListIntSelectionne = new List<int>();
        Player playerPazaak = new Player();
        Cards c = new Cards();
        Image[] playerDeck = new Image[4];
        int[] AiDeck = new int[4];

        bool RoundOver = false;

        Panel[] panelPlayerDeck;
        Panel[] panelAiDeck;
        Panel[] TabPanelLeft;
        Panel[] TabPanelRight;
        int credsWaged;
        public bool gameOver = false;
        bool addedPlusMinus = false;
        Random rand = new Random();
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


        public Pazaak(List<Image> playerDeckPazaak, List<int> carteIntEnvoye)
        {
            this.playerDeckPazaak = playerDeckPazaak;
            this.carteIntEnvoye = carteIntEnvoye;

            InitializeComponent();
            setupPlayerdeck();
            setupBoard();
        }
        internal int CreditsWaged { get => credsWaged; set => credsWaged = value; }
        internal Player Player1 { get => playerPazaak; set => playerPazaak = value; }
        public bool RoundOver1 { get => RoundOver; set => RoundOver = value; }


        private void setupBoard()
        {
            TabPanelLeft = new Panel[]
            {
             RPnlG1, RPnlG2, RPnlG3, RPnlG4, RPnlG5, RPnlG6, RPnlG7, RPnlG8,RPnlG9
            };
            TabPanelRight = new Panel[]
            {
             RPnlD1, RPnlD2, RPnlD3, RPnlD4, RPnlD5, RPnlD6, RPnlD7, RPnlD8,RPnlD9
            };
        }

        private void setupPlayerdeck()
        {
            selectCardsForDeck();

            panelPlayerDeck = new Panel[]
            {
             RPnlDownG1, RPnlDownG2, RPnlDownG3, RPnlDownG4
            };
            for (int i = 0; i < panelPlayerDeck.Length; i++)
            {
                panelPlayerDeck[i].BackgroundImage = playerDeck[i];
                panelPlayerDeck[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
            for (int i = 0; i < AiDeck.Length; i++)
            {
                //1 2 3 4 5 6
                //-1 -2 -3 -4 -5 -6
                //7 8 9 10 11 12 == +-1 +-2 etc
                int num = rand.Next(-6, 13);
                while (num == 0)
                {
                    num = rand.Next(-6, 13);
                }
                AiDeck[i] = num;
            }
        }

        private void selectCardsForDeck()
        {
            int tailleListe = playerDeckPazaak.Count;

            int nombreCarteSelectionne = 0;

            for (int i = 0; i < 4; i++)
            {
                ListIntSelectionne.Add(0);
            }
            while (nombreCarteSelectionne != 4)
            {
                int a = rand.Next(0, tailleListe);
                playerDeck[nombreCarteSelectionne] = playerDeckPazaak.ElementAt(a);
                playerDeckPazaak.RemoveAt(a);

                ListIntSelectionne[nombreCarteSelectionne] = carteIntEnvoye.ElementAt(a);
                carteIntEnvoye.RemoveAt(a);

                tailleListe--;
                nombreCarteSelectionne++;
            }
            for (int i = 0; i < 4; i++)
            {
                MessageBox.Show((ListIntSelectionne[i] + 1).ToString());
            }
        }

        private void End_Turn_Click(object sender, EventArgs e)
        {
            int pointsAdded = rand.Next(1, 11);
            CPBoxAI.BackColor = Color.Black;
            CPBoxPlayer.BackColor = Color.Maroon;
            TabPanelLeft[nbCardsPlayer].BackgroundImage = c.getCarteNormal(pointsAdded);
            TabPanelLeft[nbCardsPlayer].BackgroundImageLayout = ImageLayout.Stretch;
            nbCardsPlayer++;
            PlayerPoints += pointsAdded;
            LblPointsPlayer.Text = PlayerPoints.ToString();
            AiTurn();
        }

        private void AiTurn()
        {
            int pointsAdded = 0;
            CPBoxAI.BackColor = Color.Maroon;
            CPBoxPlayer.BackColor = Color.Black;
            Move moveAI = DetermineMove();

            if (moveAI == Projet_GONLO.Move.End_Turn)
            {
                pointsAdded = rand.Next(1, 11);
                TabPanelRight[nbCardsAi].BackgroundImage = c.getCarteNormal(pointsAdded);
                TabPanelRight[nbCardsAi].BackgroundImageLayout = ImageLayout.Stretch;
                nbCardsAi++;
                AiPoints += pointsAdded;
                LblPointsAi.Text = AiPoints.ToString();
            }
            else if (moveAI == Projet_GONLO.Move.Stand)
            {
                AiStand = true;
            }
            else
            {
                AddCard(moveAI);
            }

        }

       

        private void addAICardToBoard(int index)
        {
            MessageBox.Show("add card");
            if (AiDeck[index] < 0)
            {
                TabPanelRight[nbCardsAi].BackgroundImage = c.getCarteMinus(AiDeck[index] - 2 * (AiDeck[index]));
                AiPoints += AiDeck[index];
            }
            else if (AiDeck[index] > 0 && AiDeck[index] < 7)
            {
                TabPanelRight[nbCardsAi].BackgroundImage = c.getCartePlus(AiDeck[index]);
                AiPoints += AiDeck[index];
            }
            else
            {
                if (AiPoints > 20)
                {
                    TabPanelRight[nbCardsAi].BackgroundImage = c.getCartePlusMinus(AiDeck[index] - 6);
                    AiPoints -= AiDeck[index] - 6;
                }
                else
                {
                    TabPanelRight[nbCardsAi].BackgroundImage = c.getCartePlusMinus(AiDeck[index] - 6);
                    AiPoints += AiDeck[index] - 6;
                }
            }
            AiDeck[index] = 100; //empty
            TabPanelRight[nbCardsAi].BackgroundImageLayout = ImageLayout.Stretch;
            LblPointsAi.Text = AiPoints.ToString();
            nbCardsAi++;

        }
        private void AddCard(Move moveAI)
        {
            switch (moveAI)
            {
                case Projet_GONLO.Move.AddCard1:
                    addAICardToBoard(0);
                    break;
                case Projet_GONLO.Move.AddCard2:
                    addAICardToBoard(1);
                    break;
                case Projet_GONLO.Move.AddCard3:
                    addAICardToBoard(2);
                    break;
                case Projet_GONLO.Move.AddCard4:
                    addAICardToBoard(3);
                    break;

            }
        }
        private Move DetermineMove()
        {
            if (AiPoints <= 14)
            {
                return Projet_GONLO.Move.End_Turn;
            }
            else if (AiPoints == 20 || AiPoints == 19 || AiPoints == 18 || addedPlusMinus)
            {
                return Projet_GONLO.Move.Stand;
            }
            else if (AiPoints > 20)
            {
                return MinusCard();
            }
            else if (AiPoints > 14 && AiPoints < 20)
            {
                return PlusCard();
            }
            return Projet_GONLO.Move.Stand;

        }

        private Move AddPlusMinusCard()
        {
            for (int i = 0; i < AiDeck.Length; i++)
            {
                if (AiDeck[i] > 6 && AiDeck[i] < 13)
                {
                    addedPlusMinus = true;
                    return DetermineCard(i);
                }
            }


            return Projet_GONLO.Move.Stand;
        }

        private Move PlusCard()
        {
            if (PlayerPoints < 20)
            {

                for (int i = 0; i < AiDeck.Length; i++)
                {

                    if (AiDeck[i] > 0)
                    {
                        if (AiDeck[i] < 7 && AiDeck[i] + AiPoints <= 20 && AiDeck[i] + AiPoints >= PlayerPoints)
                        {
                            MessageBox.Show(AiDeck[i].ToString());

                            return DetermineCard(i);
                        }
                    }
                }
            }
            return AddPlusMinusCard();
        }

        private Move MinusCard()
        {
            if (PlayerPoints <= 20)
            {

                for (int i = 0; i < AiDeck.Length; i++)
                {

                    if (AiDeck[i] < 0 && AiPoints + AiDeck[i] <= 20)
                    {
                        return DetermineCard(i);

                    }
                }
            }
            return AddPlusMinusCard();
        }

        private Move DetermineCard(int element)
        {
            switch (element)
            {
                case 0:
                    return Projet_GONLO.Move.AddCard1;
                case 1:
                    return Projet_GONLO.Move.AddCard2;
                case 2:
                    return Projet_GONLO.Move.AddCard3;
                case 3:
                    return Projet_GONLO.Move.AddCard4;
            }
            return Projet_GONLO.Move.Stand;
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            playerStand = true;
            VerifyStands();
            while (!gameOver)
            {
                AiTurn();
                VerifyStands();
                
            }
            ResetGame();
            

        }

        private void VerifyStands()
        {
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
            else if (PlayerPoints == 20)
            {
                MessageBox.Show("Player gagné!!");
            }
            else if (AiPoints == 20)
            {
                MessageBox.Show("Ai gagne!!");
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
            gameOver = true;
            
            
        }

        

        private int differenceFrom20(int points)
        {
            return 20 - points;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = { playerPazaak.Name, playerPazaak.Species, playerPazaak.Gender };
            StreamWriter file = new StreamWriter(@"C:\Users\1156103\Documents\GitHub\GONLOS_CANTINA\Projet_GONLO\Saves\Saves.txt");
            foreach (string line in lines)
            {
                file.WriteLine(line);
            }

        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PazaakCardsSelector newPazaakCardSelector = new PazaakCardsSelector();
            newPazaakCardSelector.Player1 = playerPazaak;
            newPazaakCardSelector.ShowDialog();
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
                playerPazaak.Credits -= credsWaged;
                this.Hide();
                MenuAccueil newMenuAccueil = new MenuAccueil();
                newMenuAccueil.Player1 = playerPazaak;
                newMenuAccueil.ShowDialog();
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

            ShowFlipCard();

        }

        private void ShowFlipCard()
        {

            Label[] Numeric = { LblNumeric1, LblNumeric2, LblNumeric3, LblNumeric4 };
            Label[] PlusValue = { LblPlusValue1, LblPlusValue2, LblPlusValue3, LblPlusValue4 };
            Label[] FlipCard = { LblFlipCard1, LblFlipCard2, LblFlipCard3, LblFlipCard4 };

            for (int i = 0; i < ListIntSelectionne.Count; i++)
            {
                if (ListIntSelectionne[i] > 11)
                {
                    PlusValue[i].Show();
                    FlipCard[i].Show();
                    Numeric[i].Text = (ListIntSelectionne[i] - 11).ToString();
                    Numeric[i].Show();
                }
            }
        }
        private void RPnlDownG1_Click(object sender, EventArgs e)
        {
            AddCardPlayerDeck(0);
        }

        private void RPnlDownG2_Click(object sender, EventArgs e)
        {
            AddCardPlayerDeck(1);
        }

        private void RPnlDownG3_Click(object sender, EventArgs e)
        {
            AddCardPlayerDeck(2);
        }

        private void RPnlDownG4_Click(object sender, EventArgs e)
        {
            AddCardPlayerDeck(3);
        }

        private void AddCardPlayerDeck(int indexPanel)
        {
            Label[] MinusValue = { LblMinusValue1, LblMinusValue2, LblMinusValue3, LblMinusValue4 };
            Label[] Numeric = { LblNumeric1, LblNumeric2, LblNumeric3, LblNumeric4 };
            Label[] PlusValue = { LblPlusValue1, LblPlusValue2, LblPlusValue3, LblPlusValue4 };
            Label[] FlipCard = { LblFlipCard1, LblFlipCard2, LblFlipCard3, LblFlipCard4 };
            CPBoxAI.BackColor = Color.Black;
            CPBoxPlayer.BackColor = Color.Maroon;
            TabPanelLeft[nbCardsPlayer].BackgroundImage = playerDeck[indexPanel];
            panelPlayerDeck[indexPanel].BackgroundImage = null;

            TabPanelLeft[nbCardsPlayer].BackgroundImageLayout = ImageLayout.Stretch;
            nbCardsPlayer++;
            if (ListIntSelectionne[indexPanel] >= 0 && ListIntSelectionne[indexPanel] < 6)
            {
                PlayerPoints += ListIntSelectionne[indexPanel] + 1;
            }
            else if (ListIntSelectionne[indexPanel] >= 6 && ListIntSelectionne[indexPanel] < 12)
            {
                // -6 pcq index commence apres les cartes + et + 1 puisque l'index commence a zero
                int pointsEnlever = ListIntSelectionne[indexPanel] - 5;
                PlayerPoints -= pointsEnlever;
            }
            else
            {
                int pointsEnlever = ListIntSelectionne[indexPanel] - 11;
                if (MinusValue[indexPanel].Visible)
                {
                    PlayerPoints -= pointsEnlever;
                }
                else
                {
                    PlayerPoints += pointsEnlever;
                }
                MinusValue[indexPanel].Hide();
                PlusValue[indexPanel].Hide();
                Numeric[indexPanel].Hide();
                FlipCard[indexPanel].Hide();

            }
            panelPlayerDeck[indexPanel].Enabled = false;
            LblPointsPlayer.Text = PlayerPoints.ToString();
            AiTurn();
        }


        private void FlipCard_Click(object sender, EventArgs e)
        {
            Label[] MinusValue = { LblMinusValue1, LblMinusValue2, LblMinusValue3, LblMinusValue4 };
            Label[] PlusValue = { LblPlusValue1, LblPlusValue2, LblPlusValue3, LblPlusValue4 };

            string lablelName = ((Label)sender).Name;
            for (int i = 0; i < playerDeck.Length; i++)
            {
                if (lablelName.IndexOf((i+1).ToString()) != -1)
                {
                   if (PlusValue[i].Visible)
                   {
                        PlusValue[i].Hide();
                        MinusValue[i].Show();
                    }
                    else
                    {
                        PlusValue[i].Show();
                        MinusValue[i].Hide();
                    }
                }
            }
        }


        private void ResetGame()
        {
            for (int i = 0; i < TabPanelLeft.Length; i++)
            {
                TabPanelLeft[i].BackgroundImage = null;
                TabPanelRight[i].BackgroundImage = null;
            }
            gameOver = false;
            addedPlusMinus = false;
            
            PlayerPoints = 0;
            AiPoints = 0;
            turn = 0;
            nbCardsPlayer = 0;
            nbCardsAi = 0;

            playerStand = false;
            AiStand = false;

            LblPointsAi.Text = "0";
            LblPointsPlayer.Text = "0";



        }


    }
}