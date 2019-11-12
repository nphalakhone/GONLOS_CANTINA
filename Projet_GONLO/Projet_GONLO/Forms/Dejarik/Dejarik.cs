using Projet_GONLO.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Projet_GONLO
{
    public partial class Dejarik : Form
    {
        List<Button> listButtons;
        Player player1 = new Player();
        Player player2 = new Player();
        List<Player> players = new List<Player>();

        int newTurn = 1;

        int turn = 0;
        int counterMov = 0;
        int firstClick = 0;
        int oldPosition = 0;
        int actions = 0;//If actions = 0 = mouvement, if actions = 1 = attack, 
        List<String> logMonster;
        Monster lastMonster;


        internal Player Player1 { get => player1; set => player1 = value; }
        internal Player Player2 { get => player2; set => player2 = value; }

        public Dejarik(String monster)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            initalizeListButtons();
            Tile.CreateTiles();
            addLogMonster(monster);
        }

        private void addLogMonster(string monster)
        {
            logMonster = monster.Split('-').ToList();
            for (int i = 0; i < logMonster.Count; i++)
            {
                if (!logMonster[i].Equals(""))
                {
                    ListBoxLog.Items.Add(logMonster[i]);
                }
            }
        }

        private void initializeMonsterPosition()
        {
            //Setting the position of each monster on player 1 side
            player1.AttMonster.Position = 14;
            player1.DefMonster.Position = 15;
            player1.MovMonster.Position = 16;
            player1.PowMonster.Position = 17;

            //Setting the position of each monster on player 2 side
            player2.AttMonster.Position = 23;
            player2.DefMonster.Position = 22;
            player2.MovMonster.Position = 21;
            player2.PowMonster.Position = 20;

            //Setting the images based on the monsters positions
            setButton(player1.AttMonster.Position, player1.AttMonster.Picture);
            setButton(player1.DefMonster.Position, player1.DefMonster.Picture);
            setButton(player1.MovMonster.Position, player1.MovMonster.Picture);
            setButton(player1.PowMonster.Position, player1.PowMonster.Picture);

            setButton(player2.AttMonster.Position, player2.AttMonster.Picture);
            setButton(player2.DefMonster.Position, player2.DefMonster.Picture);
            setButton(player2.MovMonster.Position, player2.MovMonster.Picture);
            setButton(player2.PowMonster.Position, player2.PowMonster.Picture);

            setInfoMonster();
        }

        private void setButton(int x, Image img)
        {
            if (img != null)
            {
                listButtons[x].BackgroundImageLayout = ImageLayout.Stretch;
                listButtons[x].BackgroundImage = img;
            }
            else if (img == null)
            {
                listButtons[x].BackgroundImageLayout = ImageLayout.Stretch;
                listButtons[x].BackgroundImage = null;
            }
        }

        private void initalizeListButtons()
        {
            listButtons = new List<Button>();
            listButtons.Add(new Button());
            listButtons.Add(Button1);
            listButtons.Add(Button2);
            listButtons.Add(Button3);
            listButtons.Add(Button4);
            listButtons.Add(Button5);
            listButtons.Add(Button6);
            listButtons.Add(Button7);
            listButtons.Add(Button8);
            listButtons.Add(Button9);
            listButtons.Add(Button10);
            listButtons.Add(Button11);
            listButtons.Add(Button12);
            listButtons.Add(Button13);
            listButtons.Add(Button14);
            listButtons.Add(Button15);
            listButtons.Add(Button16);
            listButtons.Add(Button17);
            listButtons.Add(Button18);
            listButtons.Add(Button19);
            listButtons.Add(Button20);
            listButtons.Add(Button21);
            listButtons.Add(Button22);
            listButtons.Add(Button23);
            listButtons.Add(Button24);
            listButtons.Add(Button25);

            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].Click += btn_Click;
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int currPosition = Int32.Parse(((Button)sender).Tag.ToString());


            if(firstClick == 0)
            {
                oldPosition = currPosition;
                firstClick++;

            }

            //When he begins (he choose a monster)
            players[turn].CurrMonster = getClickMonster(currPosition);

            setCounterMov(players[turn].CurrMonster);

            lastMonster = players[turn].CurrMonster;

            //If he chose to move
            if (listButtons[currPosition].BackColor == Color.Green)
            {
                for (int i = 0; i < players[turn].ListMonsters.Count; i++)
                {
                    if (players[turn].CurrMonster == players[turn].ListMonsters[i])
                    {
                        movement(currPosition, players[turn].ListMonsters[i]);
                    }
                }
            }


            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].BackColor = Color.Transparent;
                listButtons[i].Enabled = false;
            }

            if (counterMov == players[turn].CurrMonster.Movement)
            {
                
                endTurn();

            }
            else
            {

                activateMovButtons(players[turn].CurrMonster.Position);
                oldPosition = currPosition;
            }

            //activateAttackButtons(players[turn].CurrMonster.Position);
        }

        private void movement(int nextPosition, Monster monster)
        {
            setButton(monster.Position, null);
            monster.Position = nextPosition;
            setButton(nextPosition, monster.Picture);
            counterMov++;
            setCounterMov(monster);
        }

        private void setCounterMov(Monster monster)
        {
            int tempMov = monster.Movement - counterMov;
            LblMov.Text = "MOV : " + tempMov;
        }

        private void endTurn()
        {
            oldPosition = 0;
            alertChangePlayer();
            addLog();
            changeLabel();

            if (turn == 1)
            {
                turn = 0;
            }
            else if (turn == 0)
            {
                turn++;
            }

            activateCurrPlayer();
            counterMov = 0;

        }

        private void addLog()
        {
            String logTemp = "";
            if (turn == 0)
            {
                logTemp = "Round " + newTurn + " : Player 1 moved " + lastMonster.Name + " to position : " + lastMonster.Position;
            }
            else
            {
                logTemp = "Round " + newTurn + " : Player 2 moved " + lastMonster.Name + " to position : " + lastMonster.Position;
            }
            ListBoxLog.Items.Add(logTemp);
            
        }

        private void alertChangePlayer()
        {
            string message;
            if (turn == 0)
            {
                message = "Player 2's turn";
            }
            else
            {
                message = "Player 1's turn";
            }
            string title = "Player's turn to play";
            MessageBox.Show(message, title);
        }

        private void changeLabel()
        {
            
            if (turn == 0)
            {
                LblPlayerTurn.Text = "Player 2's turn";
            }
            else
            {
                LblPlayerTurn.Text = "Player 1's turn";
                newTurn += 1;
                lblRound.Text = "Round : " + newTurn;
            }
        }

        private void activateMovButtons(int currPosition)
        {
            List<int> accessibleButtons = new List<int>();
            for (int j = 0; j < Tile.ListTiles[currPosition].ListMovement.Count; j++)
            {
                accessibleButtons.Add(Tile.ListTiles[currPosition].ListMovement[j].Number);
            }

            //******************************
            for (int i = 0; i < accessibleButtons.Count; i++)
            {
                if(accessibleButtons[i] == oldPosition)
                {
                    accessibleButtons.Remove(oldPosition);
                }
            }

            //Activate accessible buttons for movement
            for (int i = 0; i < accessibleButtons.Count; i++)
            {
                if (listButtons[accessibleButtons[i]].BackgroundImage == null)
                {
                    listButtons[accessibleButtons[i]].BackColor = Color.Green;
                    listButtons[accessibleButtons[i]].Enabled = true;
                }

            }
        }

        private void activateAttackButtons(int currPosition)
        {
            List<int> accessibleButtons = new List<int>();
            for (int j = 0; j < Tile.ListTiles[currPosition].ListMovement.Count; j++)
            {
                accessibleButtons.Add(Tile.ListTiles[currPosition].ListMovement[j].Number);
            }

            //Activate accessible buttons for attack
            for (int i = 0; i < accessibleButtons.Count; i++)
            {
                ////Attack
                //if (checkForAttack(accessibleButtons[i]))
                //{
                //    listButtons[accessibleButtons[i]].BackColor = Color.Yellow;
                //    listButtons[accessibleButtons[i]].Enabled = true;
                //}
            }
        }

        //private Boolean checkForAttack(int accessible)
        //{
        //    Boolean attack = false;
        //    for (int i = 0; i < otherPlayer.ListMonsters.Count; i++)
        //    {
        //        if (accessible == otherPlayer.ListMonsters[i].Position)
        //        {
        //            attack = true;
        //        }
        //    }
        //    return attack;
        //}

        /// <summary>
        /// Get the monster of where the player clicked
        /// </summary>
        /// <param name="currPosition"></param>
        /// <returns></returns>
        private Monster getClickMonster(int currPosition)
        {
            for (int i = 0; i < players[turn].ListMonsters.Count; i++)
            {
                if (currPosition == players[turn].ListMonsters[i].Position)
                {
                    players[turn].CurrMonster = players[turn].ListMonsters[i];
                    break;
                }
            }
            return players[turn].CurrMonster;
        }

        private void Dejarik_Load(object sender, EventArgs e)
        {
            initializeMonsterPosition();
            player1.ListMonsters = new List<Monster> { player1.AttMonster, player1.DefMonster, player1.MovMonster, player1.PowMonster };
            player2.ListMonsters = new List<Monster> { player2.AttMonster, player2.DefMonster, player2.MovMonster, player2.PowMonster };
            players.Add(player1);
            players.Add(player2);
            activateCurrPlayer();
        }

        private void setInfoMonster()
        {
            imgP1MonsterAtk.BackgroundImageLayout = ImageLayout.Stretch;
            imgP1MonsterAtk.Image = player1.AttMonster.Picture;

            imgP1MonsterDef.BackgroundImageLayout = ImageLayout.Stretch;
            imgP1MonsterDef.Image = player1.DefMonster.Picture;

            imgP1MonsterMov.BackgroundImageLayout = ImageLayout.Stretch;
            imgP1MonsterMov.Image = player1.MovMonster.Picture;

            imgP1MonsterPow.BackgroundImageLayout = ImageLayout.Stretch;
            imgP1MonsterPow.Image = player1.PowMonster.Picture;

            imgP2MonsterAtk.BackgroundImageLayout = ImageLayout.Stretch;
            imgP2MonsterAtk.Image = player2.AttMonster.Picture;

            imgP2MonsterDef.BackgroundImageLayout = ImageLayout.Stretch;
            imgP2MonsterDef.Image = player2.DefMonster.Picture;

            imgP2MonsterMov.BackgroundImageLayout = ImageLayout.Stretch;
            imgP2MonsterMov.Image = player2.MovMonster.Picture;

            imgP2MonsterPow.BackgroundImageLayout = ImageLayout.Stretch;
            imgP2MonsterPow.Image = player2.PowMonster.Picture;

        }

        /// <summary>
        /// Activate current player monsters.
        /// </summary>
        private void activateCurrPlayer()
        {
            for (int i = 0; i < listButtons.Count; i++)
            {
                if (!(i == players[turn].AttMonster.Position || i == players[turn].DefMonster.Position
                    || i == players[turn].MovMonster.Position || i == players[turn].PowMonster.Position))
                {
                    listButtons[i].Enabled = false;
                }
                else
                {
                    listButtons[i].Enabled = true;
                    //listButtons[i].FlatAppearance.BorderColor = Color.Red;
                    //listButtons[i].FlatAppearance.BorderSize = 5;
                }
            }
        }

        private void BtnDice_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int dice = rng.Next(1, 7);
            switch (dice)
            {
                case 1:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_one;
                    break;

                case 2:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_two;
                    break;

                case 3:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_three;
                    break;

                case 4:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_four;
                    break;

                case 5:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_five;
                    break;

                case 6:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_six;
                    break;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\1156103\\Documents\\GitHub\\GONLOS_CANTINA\\Projet_GONLO\\Saves\\Saves.txt");
            string playerData = player1.Name + "," + player1.Species + "," + player1.Gender + "," + player1.PowMonster + "," + player1.AttMonster + "," + player1.DefMonster + "," + player1.MovMonster;
            writer.Flush();
            writer.WriteLine(playerData);
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDejarik newDejarik = new MenuDejarik();
            newDejarik.ShowDialog();
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Dejarik_Holochess_Rules.pdf");
        }

        private void LblAction_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
