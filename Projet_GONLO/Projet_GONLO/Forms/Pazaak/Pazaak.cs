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
using Projet_GONLO.Classes.Pazaak;
namespace Projet_GONLO
{

    public enum Move { Stand, End_Turn, AddCard1, AddCard2, AddCard3, AddCard4 };

    public partial class Pazaak : Form
    {
        List<Image> playerDeckPazaak = new List<Image>();
        List<int> carteIntEnvoye = new List<int>();
        List<int> ListIntSelectionne = new List<int>();
        Player playerPazaak;
        Cards c = new Cards();
        Image[] playerDeck = new Image[4];
        int[] AiDeck = new int[4];

        bool RoundOver = false;

        Panel[] panelPlayerDeck;
        //Panel[] panelAiDeck;
        Panel[] TabPanelLeft;
        Panel[] TabPanelRight;
        Panel[] TabPnlAiDeck;
        CircularPictureBox[] tabCircularBtnPlayer;
        CircularPictureBox[] tabCircularBtnAi;
        int credsWaged;
        public bool gameOver = false;
        bool addedPlusMinus = false;
        Random rand = new Random();
        Player ai = new Player();
        




        public Pazaak(List<Image> playerDeckPazaak, int[] carteIntEnvoye)
        {
            this.playerDeckPazaak = playerDeckPazaak;
            this.carteIntEnvoye = TabToList(carteIntEnvoye);
            playerPazaak = new Player();
            InitializeComponent();
            SetupPlayerdeck();
            SetupAiDeck();
            SetupBoard();
        }

        private void SetupAiDeck()
        {
           TabPnlAiDeck = new Panel[]
           {
             PnlAiDeck1,PnlAiDeck2,PnlAiDeck3,PnlAiDeck4
           };

            for (int i = 0; i < TabPnlAiDeck.Length; i++)
            {
                TabPnlAiDeck[i].BackgroundImage = Properties.Resources.back_card_Pazaak;
                TabPnlAiDeck[i].BackgroundImageLayout = ImageLayout.Stretch;
            }

        }

        private List<int> TabToList(int[] carteIntEnvoye)
        {
            List<int> listRetourner = new List<int>();
            for (int i = 0; i < carteIntEnvoye.Length; i++)
            {
                listRetourner.Add(carteIntEnvoye[i]);
            }
            return listRetourner;
        }

        internal int CreditsWaged { get => credsWaged; set => credsWaged = value; }
        internal Player Player1 { get => playerPazaak; set => playerPazaak = value; }
        public bool RoundOver1 { get => RoundOver; set => RoundOver = value; }


        private void SetupBoard()
        {
            TabPanelLeft = new Panel[]
            {
             RPnlG1, RPnlG2, RPnlG3, RPnlG4, RPnlG5, RPnlG6, RPnlG7, RPnlG8,RPnlG9
            };
            TabPanelRight = new Panel[]
            {
             RPnlD1, RPnlD2, RPnlD3, RPnlD4, RPnlD5, RPnlD6, RPnlD7, RPnlD8,RPnlD9
            };

         tabCircularBtnPlayer = new CircularPictureBox[]
        {
            CPBoxRound1Player,
            CPBoxRound2Player,
            CPBoxRound3Player
        };
            tabCircularBtnAi = new CircularPictureBox[]
        {
            CPBoxRound1AI,
            CPBoxRound2AI,
            CPBoxRound3AI
        };



        }

        private void SetupPlayerdeck()
        {
            SelectCardsForDeck();

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

        private void SelectCardsForDeck()
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
        }

        private void End_Turn_Click(object sender, EventArgs e)
        {
            if (playerPazaak.NbCards != 9)
            {
            int pointsAdded = rand.Next(1, 11);
            CPBoxAI.BackColor = Color.Black;
            CPBoxPlayer.BackColor = Color.Maroon;
            TabPanelLeft[playerPazaak.NbCards].BackgroundImage = c.getCarteNormal(pointsAdded);
            TabPanelLeft[playerPazaak.NbCards].BackgroundImageLayout = ImageLayout.Stretch;
            playerPazaak.NbCards++;
                //PlayerPoints += pointsAdded;
                //LblPointsPlayer.Text = PlayerPoints.ToString();
                playerPazaak.Points += pointsAdded;
                LblPointsPlayer.Text = playerPazaak.Points.ToString();
            AiTurn();
            }
            else
            {
                Stand();
            }
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
                TabPanelRight[ai.NbCards].BackgroundImage = c.getCarteNormal(pointsAdded);
                TabPanelRight[ai.NbCards].BackgroundImageLayout = ImageLayout.Stretch;
                ai.NbCards++;
                //AiPoints += pointsAdded;
                //LblPointsAi.Text = AiPoints.ToString();
                ai.Points += pointsAdded;
                LblPointsAi.Text = ai.Points.ToString();
            }
            else if (moveAI == Projet_GONLO.Move.Stand)
            {
                ai.Stand = true;
            }
            else
            {
                AddCard(moveAI);
            }

        }

       

        private void AddAICardToBoard(int index)
        {
            Panel[] TabPnlAiDeck = new Panel[]
            {
             PnlAiDeck1,PnlAiDeck2,PnlAiDeck3,PnlAiDeck4
            };

            
            if (AiDeck[index] < 0)
            {
                TabPanelRight[ai.NbCards].BackgroundImage = c.getCarteMinus(AiDeck[index] - 2 * (AiDeck[index]));
                ai.Points += AiDeck[index];
            }
            else if (AiDeck[index] > 0 && AiDeck[index] < 7)
            {
                TabPanelRight[ai.NbCards].BackgroundImage = c.getCartePlus(AiDeck[index]);
                ai.Points += AiDeck[index];
            }
            else
            {
                if (ai.Points > 20)
                {
                    TabPanelRight[ai.NbCards].BackgroundImage = c.getCartePlusMinus(AiDeck[index] - 6);
                    ai.Points -= AiDeck[index] - 6;
                }
                else
                {
                    TabPanelRight[ai.NbCards].BackgroundImage = c.getCartePlusMinus(AiDeck[index] - 6);
                    ai.Points += AiDeck[index] - 6;
                }
            }
            AiDeck[index] = 100; //empty
            TabPanelRight[ai.NbCards].BackgroundImageLayout = ImageLayout.Stretch;
            LblPointsAi.Text = ai.Points.ToString();
            TabPnlAiDeck[index].BackgroundImage = null;
            ai.NbCards++;
            ai.NbCarteUtiliseAi++;

        }
        private void AddCard(Move moveAI)
        {
            switch (moveAI)
            {
                case Projet_GONLO.Move.AddCard1:
                    AddAICardToBoard(0);
                    break;
                case Projet_GONLO.Move.AddCard2:
                    AddAICardToBoard(1);
                    break;
                case Projet_GONLO.Move.AddCard3:
                    AddAICardToBoard(2);
                    break;
                case Projet_GONLO.Move.AddCard4:
                    AddAICardToBoard(3);
                    break;

            }
        }
        private Move DetermineMove()
        {
            if (ai.NbCards != 9)
            {
                if (ai.Points <= 14)
                {
                    return Projet_GONLO.Move.End_Turn;
                }   
                else if (ai.Points == 20 || ai.Points == 19 || ai.Points == 18 || addedPlusMinus)
                {
                    return Projet_GONLO.Move.Stand;
                }
                else if (ai.Points > 20)
                {
                    return MinusCard();
                }
                else if (ai.Points > 14 && ai.Points < 20)
                {
                    return PlusCard();
                }
            }
            return Projet_GONLO.Move.Stand;
        }

        private Move AddPlusMinusCard()
        {
            if (playerPazaak.Points < 21) { 


                for (int i = 0; i < AiDeck.Length; i++)
                {
                    if (AiDeck[i] > 6 && AiDeck[i] < 13)
                    {
                        if (ai.Points > 20 && ai.Points - (AiDeck[i] - 6) > playerPazaak.Points && ai.Points - (AiDeck[i] - 6) <= 20)
                        {
                            addedPlusMinus = true;
                            return DetermineCard(i);
                        }
                        else if (ai.Points < 20 && AiDeck[i] + (ai.Points - 6) <= 20 && AiDeck[i] + (ai.Points - 6) >= playerPazaak.Points)
                        {
                            addedPlusMinus = true;
                            return DetermineCard(i);
                        }
                        
                    }
                }


            }


            return Projet_GONLO.Move.Stand;
        }

        private Move PlusCard()
        {
            if (playerPazaak.Points < 20)
            {

                for (int i = 0; i < AiDeck.Length; i++)
                {

                    if (AiDeck[i] > 0)
                    {
                        if (AiDeck[i] < 7 && AiDeck[i] + ai.Points <= 20) 
                        {
                            if (AiDeck[i] + ai.Points >= playerPazaak.Points ||  4 - ai.NbCarteUtiliseAi > 0)
                            {
                                MessageBox.Show(AiDeck[i].ToString());

                                return DetermineCard(i);
                            }

                        }
                    }
                }
            }
            return AddPlusMinusCard();
        }

        private Move MinusCard()
        {
            if (playerPazaak.Points <= 20)
            {

                for (int i = 0; i < AiDeck.Length; i++)
                {

                    if (AiDeck[i] < 0 && ai.Points + AiDeck[i] <= 20 && ai.Points + AiDeck[i] >= playerPazaak.Points)
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
            Stand();
        }

        private void Stand()
        {
            playerPazaak.Stand = true;
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
            if (ai.Stand && playerPazaak.Stand)
            {
                FindWinner();
            }
            
        }

        private void FindWinner()
        {
            string result = "";
            
            if (ai.Points == playerPazaak.Points)
            {
                result = "Egalite";
            }
            else if (playerPazaak.Points == 20)
            {
                result = "Player gagné!!";
                
            }
            else if (ai.Points == 20)
            {
                result = "Ai gagne!!";
            }
            else if (ai.Points < 20 && playerPazaak.Points < 20)
            {
                if (differenceFrom20(ai.Points) < differenceFrom20(playerPazaak.Points))
                {
                    result = "Ai gagne!!";
                }
                else
                {
                    result = "Player gagné!!";
                }
            }
            else if (ai.Points > 20 && playerPazaak.Points > 20)
            {
                result = "Egalite";
            }
            else if (ai.Points < 20 && playerPazaak.Points > 20)
            {
                result = "Ai gagne!!";
            }
            else
            {
                result = "Player gagné!!";
            }
            MessageBox.Show(result);
            if (result == "Player gagné!!")
            {   
                tabCircularBtnPlayer[playerPazaak.NbVictoire].BackColor = Color.Maroon;
                playerPazaak.NbVictoire++;
            }
            else if (result == "Ai gagne!!")
            {
                tabCircularBtnAi[ai.NbVictoire].BackColor = Color.Maroon;
                ai.NbVictoire++;
            }
            gameOver = true;
            
            
        }

        

        private int differenceFrom20(int points)
        {
            return 20 - points;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Player> playersSaved = new List<Player>();
            playersSaved = readSaveFile();
            StreamWriter sw2 = new StreamWriter(Application.StartupPath + "\\SavesTest.txt");

            foreach (Player p in playersSaved)
            {
                if (p.Name == playerPazaak.Name)
                {
                    DialogResult dr = MessageBox.Show("Your data already exists in the save file. " +
                        "Do you wish to overwrite your saved data?", "ATTENTION", MessageBoxButtons.YesNo);

                    switch (dr)
                    {
                        case DialogResult.Yes:
                            setPlayerData(p, playerPazaak);
                            writePlayerData(sw2, p);
                            break;
                        case DialogResult.No:
                            break;
                    }
                } else
                {
                    writePlayerData(sw2, p);
                }
            }
            playersSaved.Add(playerPazaak);
            writePlayerData(sw2, playerPazaak);
            sw2.Close();
        }

        private void setPlayerData(Player playerFromFile, Player playerInGame)
        {
            playerFromFile.Name = playerInGame.Name;
            playerFromFile.Gender = playerInGame.Gender;
            playerFromFile.Species = playerInGame.Species;
            playerFromFile.Credits = playerInGame.Credits;
            playerFromFile.PazaakGamesWon = playerInGame.PazaakGamesWon;
            playerFromFile.PazaakGamesLost = playerInGame.PazaakGamesLost;
            playerFromFile.DejarikGamesWon = playerInGame.DejarikGamesWon;
            playerFromFile.DejarikGamesLost = playerInGame.DejarikGamesLost;
        }

        private void writePlayerData(StreamWriter streamWriter, Player player)
        {
            streamWriter.WriteLine(player.Name + ";" + player.Gender + ";" + player.Species + ";" + player.Credits.ToString() + ";" +
                            player.PazaakGamesWon.ToString() + ";" + player.PazaakGamesLost.ToString() + ";" + player.DejarikGamesWon.ToString() + ";"
                            + player.DejarikGamesLost.ToString());
        }

        public List<Player> readSaveFile()
        {
            List<Player> playersSaved = new List<Player>();
            string line = "";

            if (!File.Exists(Application.StartupPath + "\\SavesTest.txt"))
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\SavesTest.txt");
                sw.Close();
            }
            StreamReader sr = new StreamReader(Application.StartupPath + "\\SavesTest.txt");
            while ((line = sr.ReadLine()) != null)
            {
                string[] new_player = line.Split(';');
                Player player = new Player();
                player.Name = new_player[0];
                player.Gender = new_player[1];
                player.Species = new_player[2];
                player.Credits = Int32.Parse(new_player[3]);
                player.PazaakGamesWon = Int32.Parse(new_player[4]);
                player.PazaakGamesLost = Int32.Parse(new_player[5]);
                player.DejarikGamesWon = Int32.Parse(new_player[6]);
                player.DejarikGamesLost = Int32.Parse(new_player[7]);
                playersSaved.Add(player);
            }
            sr.Close();
            return playersSaved;
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
            DialogResult result = MessageBox.Show("Are you sure you want to forfeit and quit the game ? You will  automaticaly lose the amount of credits taht you waged", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                playerPazaak.Credits -= credsWaged;
                playerPazaak.PazaakGamesLost++;
                this.Hide();
                MenuAccueil newMenuAccueil = new MenuAccueil();
                newMenuAccueil.Player1 = playerPazaak;
                newMenuAccueil.ShowDialog();
                this.Close();
            }
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
                playerPazaak.PazaakGamesLost++;
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
            TabPanelLeft[playerPazaak.NbCards].BackgroundImage = playerDeck[indexPanel];
            panelPlayerDeck[indexPanel].BackgroundImage = null;

            TabPanelLeft[playerPazaak.NbCards].BackgroundImageLayout = ImageLayout.Stretch;
            playerPazaak.NbCards++;
            if (ListIntSelectionne[indexPanel] >= 0 && ListIntSelectionne[indexPanel] < 6)
            {
                playerPazaak.Points += ListIntSelectionne[indexPanel] + 1;
            }
            else if (ListIntSelectionne[indexPanel] >= 6 && ListIntSelectionne[indexPanel] < 12)
            {
                // -6 pcq index commence apres les cartes + et + 1 puisque l'index commence a zero
                int pointsEnlever = ListIntSelectionne[indexPanel] - 5;
                playerPazaak.Points -= pointsEnlever;
            }
            else
            {
                int pointsEnlever = ListIntSelectionne[indexPanel] - 11;
                if (MinusValue[indexPanel].Visible)
                {
                    playerPazaak.Points -= pointsEnlever;
                }
                else
                {
                    playerPazaak.Points += pointsEnlever;
                }
                MinusValue[indexPanel].Hide();
                PlusValue[indexPanel].Hide();
                Numeric[indexPanel].Hide();
                FlipCard[indexPanel].Hide();

            }
            panelPlayerDeck[indexPanel].Enabled = false;
            LblPointsPlayer.Text = playerPazaak.Points.ToString();
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
            
            playerPazaak.Points = 0;
            ai.Points = 0;
            playerPazaak.NbCards = 0;
            ai.NbCards = 0;

            ai.Stand = false;
            playerPazaak.Stand = false;

            LblPointsAi.Text = "0";
            LblPointsPlayer.Text = "0";
            ai.NbCarteUtiliseAi = 0;

            if (playerPazaak.NbVictoire == 3)
            {
                MessageBox.Show("Vous avez gagne!!!!!!!!!");
                playerPazaak.Credits += credsWaged;
                playerPazaak.PazaakGamesWon++;
                this.Hide();
                playerPazaak.NbVictoire = 0;
                ai.NbVictoire = 0;
                MenuAccueil newMenuAccueil = new MenuAccueil();
                newMenuAccueil.Player1 = playerPazaak;
                newMenuAccueil.ShowDialog();
                this.Close();
            }
            if (ai.NbVictoire == 3)
            {
                MessageBox.Show("Vous avez perdu :( :(");
                playerPazaak.Credits -= credsWaged;
                playerPazaak.PazaakGamesLost++;
                this.Hide();
                playerPazaak.NbVictoire = 0;
                ai.NbVictoire = 0;
                MenuAccueil newMenuAccueil = new MenuAccueil();
                newMenuAccueil.Player1 = playerPazaak;
                newMenuAccueil.ShowDialog();
                this.Close();
            }
        }
    }
}