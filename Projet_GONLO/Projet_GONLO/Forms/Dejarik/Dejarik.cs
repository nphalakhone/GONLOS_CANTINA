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
        Player otherPlayer;
        List<Player> players = new List<Player>();
        int turn = 0, counterMov = 0, firstClick = 0, oldPosition = 0, actions = 2, newTurn = 1, roll = 0, newAtk = 0;
        List<String> logMonster;
        Monster lastMonster;
        Monster defendingMonster = null, attackingMonster = null;


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
                listButtons[i].BackgroundImage = null;
                listButtons[i].Click += btn_Click;
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int currPosition = Int32.Parse(((Button)sender).Tag.ToString());
            players[turn].CurrMonster = getClickMonster(currPosition);
            lastMonster = players[turn].CurrMonster;
            setCounterMov(players[turn].CurrMonster);

            //FIRST CLICK
            if (firstClick == 0)
            {
                oldPosition = currPosition;
                firstClick++;
                disableButtons();
                activateMovButtons(players[turn].CurrMonster.Position);
                activateAttackButtons(players[turn].CurrMonster.Position);

                for (int i = 0; i < players[turn].ListMonsters.Count; i++)
                {
                    if (players[turn].ListMonsters[i].Position == currPosition)
                    {
                        attackingMonster = players[turn].ListMonsters[i];
                    }

                }
            }
            //after first click
            else if (firstClick > 0)
            {
                //Movement
                if (listButtons[currPosition].BackColor == Color.Green)
                {
                    clickMovMonster(currPosition);

                }

                //Attack
                else if (listButtons[currPosition].BackColor == Color.Red)
                {
                    getDefMonster(currPosition);
                    clickAtkMonster(currPosition);
                    counterMov = players[turn].CurrMonster.Movement;
                }

                else
                {
                    for (int i = 0; i < players[turn].ListMonsters.Count; i++)
                    {
                        if (players[turn].ListMonsters[i].Position == currPosition)
                        {
                            attackingMonster = players[turn].ListMonsters[i];
                        }

                    }
                }

                disableButtons();

                //Unfinished movement
                if (counterMov != players[turn].CurrMonster.Movement)
                {
                    activateMovButtons(players[turn].CurrMonster.Position);
                }


                oldPosition = currPosition;

                if (counterMov == players[turn].CurrMonster.Movement)
                {
                    addLog();
                    actions--;
                    LblAction.Text = "Action : " + actions;
                    activateCurrPlayer();
                    firstClick = 0;
                    counterMov = 0;
                }
                if (actions == 0)
                {
                    endTurn();
                }

            }
        }

        private void getDefMonster(int currPosition)
        {
            Player tmp = null;
            if (turn == 0)
            {
                tmp = players[1];
            }
            else
            {
                tmp = players[0];
            }

            for (int i = 0; i < tmp.ListMonsters.Count; i++)
            {
                if (tmp.ListMonsters[i].Position == currPosition)
                {
                    defendingMonster = tmp.ListMonsters[i];
                    MessageBox.Show("" + defendingMonster.Name, "Defending monster");
                }
            }

        }

        private void clickAtkMonster(int currPosition)
        {
            for (int i = 0; i < players[turn].ListMonsters.Count; i++)
            {
                if (players[turn].CurrMonster == players[turn].ListMonsters[i])
                {
                    disableButtons();
                    MessageBox.Show("Roll the dice to get a new Attack value", "Attack");
                    rollDice();
                }
            }

        }

        private void rollDice()
        {
            Random rng = new Random();
            int dice = rng.Next(1, 6);
            switch (dice)
            {
                case 1:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_one;
                    if (roll == 0)
                    {
                        newAtk = attack(players[turn].CurrMonster, dice);
                        roll++;
                        rollDice();
                    }
                    else
                    {
                        MessageBox.Show("Roll the dice to get a new Defense value", "Defense");
                        defend(dice, newAtk);
                        roll = 0;
                    }
                    break;

                case 2:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_two;
                    if (roll == 0)
                    {
                        newAtk = attack(players[turn].CurrMonster, dice);
                        roll++;
                        rollDice();
                    }
                    else
                    {
                        MessageBox.Show("Roll the dice to get a new Defense value", "Defense");
                        defend(dice, newAtk);
                        roll = 0;
                    }
                    break;

                case 3:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_three;
                    if (roll == 0)
                    {
                        newAtk = attack(players[turn].CurrMonster, dice);
                        roll++;
                        rollDice();
                    }
                    else
                    {
                        MessageBox.Show("Roll the dice to get a new Defense value", "Defense");
                        defend(dice, newAtk);
                        roll = 0;
                    }
                    break;

                case 4:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_four;
                    if (roll == 0)
                    {
                        newAtk = attack(players[turn].CurrMonster, dice);
                        roll++;
                        rollDice();
                    }
                    else
                    {
                        MessageBox.Show("Roll the dice to get a new Defense value", "Defense");
                        defend(dice, newAtk);
                        roll = 0;
                    }
                    break;

                case 5:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_five;
                    if (roll == 0)
                    {
                        newAtk = attack(players[turn].CurrMonster, dice);
                        roll++;
                        rollDice();
                    }
                    else
                    {
                        MessageBox.Show("Roll the dice to get a new Defense value", "Defense");
                        defend(dice, newAtk);
                        roll = 0;
                    }
                    break;

                case 6:
                    PnlDe.BackgroundImage = Properties.Resources.dice_six_faces_six;
                    if (roll == 0)
                    {
                        newAtk = attack(players[turn].CurrMonster, dice);
                        roll++;
                        rollDice();
                    }
                    else
                    {
                        MessageBox.Show("Roll the dice to get a new Defense value", "Defense");
                        defend(dice, newAtk);
                        roll = 0;
                    }
                    break;
            }
        }

        private int attack(Monster monster, int diceValueAtk)
        {
            int newValueAtk = monster.Attack;
            newValueAtk += diceValueAtk;
            MessageBox.Show("" + newValueAtk, "New Attack Value");
            return newValueAtk;
        }

        private void clickMovMonster(int currPosition)
        {
            for (int i = 0; i < players[turn].ListMonsters.Count; i++)
            {
                if (players[turn].CurrMonster == players[turn].ListMonsters[i])
                {
                    movement(currPosition, players[turn].ListMonsters[i]);
                }
            }

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
            //addLog();
            changeLabel();

            if (turn == 1)
            {
                turn = 0;
            }
            else if (turn == 0)
            {
                turn++;
            }

            disableButtons();
            activateCurrPlayer();
            counterMov = 0;
            firstClick = 0;
            actions = 2;
            LblAction.Text = "Action : " + actions;


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

        private void disableButtons()
        {
            //Disable all buttons before enabling them
            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].BackColor = Color.Transparent;
                listButtons[i].Enabled = false;
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
                if (accessibleButtons[i] == oldPosition)
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
                if (checkForAttack(accessibleButtons[i]))
                {
                    listButtons[accessibleButtons[i]].BackColor = Color.Red;
                    listButtons[accessibleButtons[i]].Enabled = true;
                }
            }
        }

        private Boolean checkForAttack(int accessible)
        {
            Boolean attack = false;


            if (turn == 0)
            {
                otherPlayer = players[1];
            }
            else if (turn == 1)
            {
                otherPlayer = players[0];
            }

            for (int i = 0; i < otherPlayer.ListMonsters.Count; i++)
            {
                if (accessible == otherPlayer.ListMonsters[i].Position)
                {
                    attack = true;
                }
            }
            return attack;
        }

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
                listButtons[i].Enabled = false;
            }


            for (int j = 0; j < players[turn].ListMonsters.Count; j++)
            {
                listButtons[players[turn].ListMonsters[j].Position].Enabled = true;
                //listButtons[i].FlatAppearance.BorderColor = Color.Red;
                //listButtons[i].FlatAppearance.BorderSize = 5;
            }
        }

        private void BtnDice_Click(object sender, EventArgs e)
        {


        }

        private void defend(int dice, int newAtk)
        {
            int newDef = defendingMonster.Defense;
            newDef += dice;
            MessageBox.Show("" + newDef, "New Defense Value");
            //int whoWins = 0; //0 = attacker wins / 1 = defender wins

            if (newAtk - newDef >= 5)
            {
                kill("Attacker");
            }
            else if (newAtk - newDef <= 4 && newAtk - newDef >= 1)
            {
                push("Attacker");
            }
            else if (newAtk == newDef)
            {
                push("Attacker");
            }
            else if (newDef - newAtk >= 5)
            {
                kill("Defender");
            }
            else if (newDef - newAtk <= 4 && newDef - newAtk >= 1)
            {
                push("Defender");
            }

        }

        private void push(String winner)
        {
            int tmpAtk = 0, tmpDef = 0;

            if (turn == 0)
            {
                tmpAtk = 0;
                tmpDef = 1;
            }
            else if (turn == 1)
            {
                tmpAtk = 1;
                tmpDef = 0;
            }

            if (winner.Equals("Attacker"))
            {
                for (int i = 0; i < players[tmpDef].ListMonsters.Count; i++)
                {
                    if (defendingMonster == players[tmpDef].ListMonsters[i])
                    {
                        for (int j = 0; j < listButtons.Count; j++)
                        {
                            if (j == defendingMonster.Position)
                            {
                                List<int> accessibleButtons = new List<int>();

                                for (int x = 0; x < Tile.ListTiles[j].ListMovement.Count; x++)
                                {
                                    if (listButtons[Tile.ListTiles[j].ListMovement[x].Number].BackgroundImage == null)
                                    {
                                        accessibleButtons.Add(Tile.ListTiles[j].ListMovement[x].Number);
                                    }
                                }

                                var random = new Random();
                                int newPos = accessibleButtons[random.Next(accessibleButtons.Count)];

                                setButton(players[tmpDef].ListMonsters[i].Position, null);
                                players[tmpDef].ListMonsters[i].Position = newPos;
                                setButton(newPos, players[tmpDef].ListMonsters[i].Picture);
                                break;
                            }
                        }
                    }
                }
            }
            else if (winner.Equals("Defender"))
            {
                for (int i = 0; i < players[tmpAtk].ListMonsters.Count; i++)
                {
                    if (attackingMonster == players[tmpAtk].ListMonsters[i])
                    {
                        for (int j = 0; j < listButtons.Count; j++)
                        {
                            if (j == attackingMonster.Position)
                            {
                                List<int> accessibleButtons = new List<int>();

                                for (int x = 0; x < Tile.ListTiles[j].ListMovement.Count; x++)
                                {
                                    if (listButtons[Tile.ListTiles[j].ListMovement[x].Number].BackgroundImage == null)
                                    {
                                        accessibleButtons.Add(Tile.ListTiles[j].ListMovement[x].Number);
                                    }
                                }

                                var random = new Random();
                                int newPos = accessibleButtons[random.Next(accessibleButtons.Count)];

                                setButton(players[tmpAtk].ListMonsters[i].Position, null);
                                players[tmpAtk].ListMonsters[i].Position = newPos;
                                setButton(newPos, players[tmpAtk].ListMonsters[i].Picture);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void kill(String winner)
        {
            int tmpAtk = 0, tmpDef = 0;

            if (turn == 0)
            {
                tmpAtk = 0;
                tmpDef = 1;
            }
            else if (turn == 1)
            {
                tmpAtk = 1;
                tmpDef = 0;
            }


            if (winner.Equals("Attacker"))
            {
                for (int i = 0; i < players[tmpDef].ListMonsters.Count; i++)
                {
                    if (defendingMonster == players[tmpDef].ListMonsters[i])
                    {
                        players[tmpDef].ListMonsters.Remove(players[tmpDef].ListMonsters[i]);
                        for (int j = 0; j < listButtons.Count; j++)
                        {
                            if (j == defendingMonster.Position)
                            {
                                listButtons[j].BackgroundImage = null;
                                break;
                            }
                        }
                    }
                }
            }
            else if (winner.Equals("Defender"))
            {
                for (int i = 0; i < players[tmpAtk].ListMonsters.Count; i++)
                {
                    if (attackingMonster == players[tmpAtk].ListMonsters[i])
                    {
                        players[tmpAtk].ListMonsters.Remove(players[tmpAtk].ListMonsters[i]);
                        for (int j = 0; j < listButtons.Count; j++)
                        {
                            if (j == attackingMonster.Position)
                            {
                                listButtons[j].BackgroundImage = null;
                                break;
                            }
                        }
                    }
                }
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

        private void LblAction_Click_1(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAccueil ma = new MenuAccueil();
            ma.Player1 = player1;
            ma.ShowDialog();
            this.Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Dejarik_Holochess_Rules.pdf");
        }
    }
}
