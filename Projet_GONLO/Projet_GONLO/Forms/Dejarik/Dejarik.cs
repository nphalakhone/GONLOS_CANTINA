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
        int turn = 0, counterMov = 0, firstClick = 0, oldPosition = 0, actions = 2, newRound = 1, roll = 0, newAtk = 0, newDef = 0, tmpAtk = 0, tmpDef = 0, checkAtk = 0, adjacentMonsters = 0;
        List<String> logMonster;
        Monster lastMonster;
        Monster defendingMonster = null, attackingMonster = null;


        internal Player Player1 { get => player1; set => player1 = value; }
        internal Player Player2 { get => player2; set => player2 = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="monster"></param>
        public Dejarik(String monster)
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            initalizeListButtons();
            Tile.CreateTiles();
            addLogMonster(monster);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monster"></param>
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

        /// <summary>
        /// Initialize the positions and labels of players' monsters
        /// </summary>
        private void initializeMonsterPosition()
        {
            //Setting the position of each monster on player 1 side
            setUpPlayersMonster(player1, 14, 15, 16, 17);

            //Setting the position of each monster on player 2 side
            setUpPlayersMonster(player2, 23, 22, 21, 20);

            //Player 1
            setInfoMonsters(imgP1MonsterAtk, LblAtkMonsterAtk1, LblDefMonsterAtk1, LblMovMonsterAtk1, player1.AttMonster);
            setInfoMonsters(imgP1MonsterDef, LblAtkMonsterDef1, LblDefMonsterDef1, LblMovMonsterDef1, player1.DefMonster);
            setInfoMonsters(imgP1MonsterMov, LblAtkMonsterMov1, LblDefMonsterMov1, LblMovMonsterMov1, player1.MovMonster);
            setInfoMonsters(imgP1MonsterPow, LblAtkMonsterPow1, LblDefMonsterPow1, LblMovMonsterPow1, player1.PowMonster);

            //Player 2
            setInfoMonsters(imgP2MonsterAtk, LblAtkMonsterAtk2, LblDefMonsterAtk2, LblMovMonsterAtk2, player2.AttMonster);
            setInfoMonsters(imgP2MonsterDef, LblAtkMonsterDef2, LblDefMonsterDef2, LblMovMonsterDef2, player2.DefMonster);
            setInfoMonsters(imgP2MonsterMov, LblAtkMonsterMov2, LblDefMonsterMov2, LblMovMonsterMov2, player2.MovMonster);
            setInfoMonsters(imgP2MonsterPow, LblAtkMonsterPow2, LblDefMonsterPow2, LblMovMonsterPow2, player2.PowMonster);
        }

        /// <summary>
        /// Set up the positions of monsters and put the monsters on the board
        /// </summary>
        /// <param name="p"></param>
        /// <param name="posAtk"></param>
        /// <param name="posDef"></param>
        /// <param name="posMov"></param>
        /// <param name="posPow"></param>
        private void setUpPlayersMonster(Player p, int posAtk, int posDef, int posMov, int posPow)
        {
            p.AttMonster.Position = posAtk;
            p.DefMonster.Position = posDef;
            p.MovMonster.Position = posMov;
            p.PowMonster.Position = posPow;

            setMonsterImg(p.AttMonster.Position, p.AttMonster.Picture);
            setMonsterImg(p.DefMonster.Position, p.DefMonster.Picture);
            setMonsterImg(p.MovMonster.Position, p.MovMonster.Picture);
            setMonsterImg(p.PowMonster.Position, p.PowMonster.Picture);
        }


        /// <summary>
        /// Set the monster image at the correct position on board (on the correct button)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="img"></param>
        private void setMonsterImg(int x, Image img)
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

        /// <summary>
        /// Initialization of the list of 25 buttons (buttons of the game board)
        /// </summary>
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

        /// <summary>
        /// Main method of when the player click on a button on the map
        /// Everything is verified in this method (first click, movement, attack, etc)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            int currPosition = Int32.Parse(((Button)sender).Name.ToString().Substring(6));

            players[turn].CurrMonster = getClickMonster(currPosition);
            lastMonster = players[turn].CurrMonster;
            setCounterMov(players[turn].CurrMonster);

            //FIRST CLICK
            if (firstClick == 0)
            {
                onFirstClick(currPosition);
            }

            //after first click
            else if (firstClick > 0)
            {
                //Pick Atk or Mov
                actionPicker(currPosition);

                disableButtonsWithTransparent();

                if (counterMov != players[turn].CurrMonster.Movement)
                {
                    activateMovButtons(players[turn].CurrMonster.Position);
                }

                oldPosition = currPosition;

                endAction();
            }
        }

        /// <summary>
        /// End the action of the current monster (in each turn the player has 2 actions)
        /// </summary>
        private void endAction()
        {
            if (counterMov == players[turn].CurrMonster.Movement)
            {
                if (checkAtk == 0)
                {
                    addLogMouvement();
                }
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

            endGame();

        }

        /// <summary>
        /// End the game if one player monsters are all dead
        /// After 25 rounds, the game stops and check which player has the most monsters
        /// </summary>
        private void endGame()
        {
            if (newRound == 25)
            {
                if (players[0].ListMonsters.Count > players[1].ListMonsters.Count)
                {
                    MessageBox.Show("Player 1 is the winner of the game !");
                    disableButtonsWithTransparent();
                    exitMainMenu();
                }
                else if (players[1].ListMonsters.Count > players[0].ListMonsters.Count)
                {
                    MessageBox.Show("Player 2 is the winner of the game !");
                    disableButtonsWithTransparent();
                    exitMainMenu();
                }
                else if (players[1].ListMonsters.Count == players[0].ListMonsters.Count)
                {
                    MessageBox.Show("Equality!");
                    disableButtonsWithTransparent();
                    exitMainMenu();
                }
            }
            else
            {
            if (players[0].ListMonsters.Count == 0)
            {
                MessageBox.Show("Player 2 is the winner of the game !");
                disableButtonsWithTransparent();
                //exit();
            }
            else if (players[1].ListMonsters.Count == 0)
            {
                MessageBox.Show("Player 1 is the winner of the game !");
                disableButtonsWithTransparent();
                //exit();
            }
            }

        }

        /// <summary>
        /// Check which action the player has decided to do
        /// If the color is Lime, it means that he chose to move, Red, he chose to attack
        /// </summary>
        /// <param name="currPosition"></param>
        private void actionPicker(int currPosition)
        {
            //Movement
            if (listButtons[currPosition].BackColor == Color.FromArgb(80, Color.Lime))
            {
                clickMovMonster(currPosition);
                checkAtk = 0;
            }

            //Attack
            else if (listButtons[currPosition].BackColor == Color.FromArgb(70, Color.Red))
            {
                setDefMonster(currPosition);
                clickAtkMonster(currPosition);
                counterMov = players[turn].CurrMonster.Movement;
                checkAtk = 1;
            }

            else
            {
                setAtkMonster(currPosition);
            }
        }

        /// <summary>
        /// Event on the first click, when the player chooses the monster with which he will play
        /// </summary>
        /// <param name="currPosition"></param>
        private void onFirstClick(int currPosition)
        {
            oldPosition = currPosition;
            firstClick++;
            disableButtonsWithTransparent();
            activateMovButtons(players[turn].CurrMonster.Position);
            activateAttackButtons(players[turn].CurrMonster.Position);
            setAtkMonster(currPosition);
        }


        /// <summary>
        /// Find the current attacking monster
        /// </summary>
        /// <param name="currPosition"></param>
        private void setAtkMonster(int currPosition)
        {
            for (int i = 0; i < players[turn].ListMonsters.Count; i++)
            {
                if (players[turn].ListMonsters[i].Position == currPosition)
                {
                    attackingMonster = players[turn].ListMonsters[i];
                }

            }
        }

        /// <summary>
        /// Find the 
        /// </summary>
        /// <param name="currPosition"></param>
        private void setDefMonster(int currPosition)
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
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currPosition"></param>
        private void clickAtkMonster(int currPosition)
        {
            for (int i = 0; i < players[turn].ListMonsters.Count; i++)
            {
                if (players[turn].CurrMonster == players[turn].ListMonsters[i])
                {
                    disableButtonsWithTransparent();
                    rollDice();
                }
            }

        }

        /// <summary>
        /// Method that roll the dice
        /// </summary>
        private void rollDice()
        {
            Random rng = new Random();
            int dice = rng.Next(1, 6);
            switch (dice)
            {
                case 1:
                    setDiceImg(Properties.Resources.dice_six_faces_one);
                    giveNewAtkDefValue(dice);
                    break;

                case 2:
                    setDiceImg(Properties.Resources.dice_six_faces_two);
                    giveNewAtkDefValue(dice);
                    break;

                case 3:
                    setDiceImg(Properties.Resources.dice_six_faces_three);
                    giveNewAtkDefValue(dice);
                    break;

                case 4:
                    setDiceImg(Properties.Resources.dice_six_faces_four);
                    giveNewAtkDefValue(dice);
                    break;

                case 5:
                    setDiceImg(Properties.Resources.dice_six_faces_five);
                    giveNewAtkDefValue(dice);
                    break;

                case 6:
                    setDiceImg(Properties.Resources.dice_six_faces_six);
                    giveNewAtkDefValue(dice);
                    break;
            }
        }

        private void setDiceImg(Bitmap diceImg)
        {
            if (roll == 0)
            {
                PnlDeAtk.BackgroundImage = diceImg;
            }
            else
            {
                pnlDeDef.BackgroundImage = diceImg;
            }
        }

        private void giveNewAtkDefValue(int dice)
        {
            if (roll == 0)
            {
                newAtk = attack(players[turn].CurrMonster, dice);
                addLogRollDice(dice, attackingMonster);
                roll++;
                rollDice();
            }
            else
            {
                addLogRollDice(dice, defendingMonster);
                defend(dice, newAtk);
                roll = 0;
            }
        }

        private void addLogRollDice(int dice, Monster monster)
        {
            if (turn == 0)
            {

                if (roll == 0)
                {
                    ListBoxLog.Items.Add("Round " + newRound + " Player 1's Monster : " + monster.Name + " rolled a : " + dice);
                }
                else
                {
                    ListBoxLog.Items.Add("Round " + newRound + " Player 2's Monster : " + monster.Name + " rolled a : " + dice);
                }

            }
            else
            {
                if (roll > 0)
                {
                    ListBoxLog.Items.Add("Round " + newRound + " Player 2's Monster : " + monster.Name + " rolled a : " + dice);
                }
                else
                {
                    ListBoxLog.Items.Add("Round " + newRound + " Player 1's Monster : " + monster.Name + " rolled a : " + dice);
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monster"></param>
        /// <param name="diceValueAtk"></param>
        /// <returns></returns>
        private int attack(Monster monster, int diceValueAtk)
        {
            int newValueAtk = monster.Attack;
            newValueAtk += diceValueAtk;
            LblAtkMonsterName.Text = attackingMonster.Name;
            LblNewAttackValue.Text = ": " + newValueAtk;
            return newValueAtk;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currPosition"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nextPosition"></param>
        /// <param name="monster"></param>
        private void movement(int nextPosition, Monster monster)
        {
            setMonsterImg(monster.Position, null);
            monster.Position = nextPosition;
            setMonsterImg(nextPosition, monster.Picture);
            counterMov++;
            setCounterMov(monster);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monster"></param>
        private void setCounterMov(Monster monster)
        {
            int tempMov = monster.Movement - counterMov;
            LblMov.Text = "MOV : " + tempMov;
        }

        /// <summary>
        /// Finir le tour d'un joueur
        /// </summary>
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
            disableButtonsWithTransparent();
            activateCurrPlayer();
            counterMov = 0;
            firstClick = 0;
            actions = 2;
            LblAction.Text = "Action : " + actions;
        }

        /// <summary>
        /// Method that add the movement log
        /// </summary>
        private void addLogMouvement()
        {
            String logTemp = "";
            String pos = "";

            pos = findTagButton(lastMonster);


            if (turn == 0)
            {
                logTemp = "Round " + newRound + " : Player 1 moved " + lastMonster.Name + " to position : " + pos;
            }
            else
            {
                logTemp = "Round " + newRound + " : Player 2 moved " + lastMonster.Name + " to position : " + pos;
            }
            ListBoxLog.Items.Add(logTemp);

        }

        private String findTagButton(Monster monster)
        {
            String pos = "";
            for (int i = 0; i < listButtons.Count; i++)
            {
                if (monster.Position == i)
                {
                    pos = listButtons[i].Tag.ToString();
                }
            }
            return pos;
        }

        /// <summary>
        /// Method that create an alert to notify that the turn have changed
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        private void changeLabel()
        {

            if (turn == 0)
            {
                LblPlayerTurn.Text = "Player 2's turn";
            }
            else
            {
                LblPlayerTurn.Text = "Player 1's turn";
                newRound += 1;
                lblRound.Text = "Round : " + newRound;
            }
        }

        /// <summary>
        /// Disable all buttons before enabling them
        /// </summary>
        private void disableButtonsWithTransparent()
        {
            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].BackColor = Color.Transparent;
                listButtons[i].Enabled = false;
            }

            activateColors();
        }

        private void disableAllButtons()
        {
            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].Enabled = false;
            }

            activateColors();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currPosition"></param>
        private void activateMovButtons(int currPosition)
        {
            List<int> accessibleButtons = new List<int>();
            accessibleButtons = getMovAccessibleButtons(currPosition);

            for (int i = 0; i < accessibleButtons.Count; i++)
            {
                if (accessibleButtons[i] == oldPosition)
                {
                    accessibleButtons.Remove(oldPosition);
                }
            }

            if (accessibleButtons.Count == 0)
            {
                if (counterMov < players[turn].CurrMonster.Movement && counterMov > 0 || adjacentMonsters >= 3)
                {
                    counterMov = players[turn].CurrMonster.Movement;
                    endAction();
                }
                else
                {
                    return;
                }
            }
            else
            {
                //Activate accessible buttons for movement
                for (int i = 0; i < accessibleButtons.Count; i++)
                {
                    listButtons[accessibleButtons[i]].BackColor = Color.FromArgb(80, Color.Lime);
                    listButtons[accessibleButtons[i]].Enabled = true;
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="currPosition"></param>
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
                    listButtons[accessibleButtons[i]].BackColor = Color.FromArgb(70, Color.Red);
                    listButtons[accessibleButtons[i]].Enabled = true;
                }
            }



        }

        private List<int> getMovAccessibleButtons(int currPosition)
        {
            List<int> accessibleButtons = new List<int>();
            adjacentMonsters = 0;
            for (int j = 0; j < Tile.ListTiles[currPosition].ListMovement.Count; j++)
            {
                if (listButtons[Tile.ListTiles[currPosition].ListMovement[j].Number].BackgroundImage == null)
                {
                    accessibleButtons.Add(Tile.ListTiles[currPosition].ListMovement[j].Number);
                }
                else if(listButtons[Tile.ListTiles[currPosition].ListMovement[j].Number].BackColor == Color.FromArgb(80, Color.Gold))
                {
                    adjacentMonsters++;
                }
            }

            return accessibleButtons;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessible"></param>
        /// <returns></returns>
        private bool checkForAttack(int accessible)
        {
            bool attack = false;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dejarik_Load(object sender, EventArgs e)
        {
            initializeMonsterPosition();
            player1.ListMonsters = new List<Monster> { player1.AttMonster, player1.DefMonster, player1.MovMonster, player1.PowMonster };
            player2.ListMonsters = new List<Monster> { player2.AttMonster, player2.DefMonster, player2.MovMonster, player2.PowMonster };
            players.Add(player1);
            players.Add(player2);
            activateCurrPlayer();
        }

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imgMonster"></param>
        /// <param name="lblAtk"></param>
        /// <param name="lblDef"></param>
        /// <param name="lblMov"></param>
        /// <param name="playerMonsterType"></param>
        private void setInfoMonsters(PictureBox imgMonster, Label lblAtk, Label lblDef, Label lblMov, Monster playerMonsterType)
        {
            imgMonster.BackgroundImageLayout = ImageLayout.Stretch;
            imgMonster.Image = playerMonsterType.Picture;
            lblAtk.Text = "" + playerMonsterType.Attack;
            lblDef.Text = "" + playerMonsterType.Defense;
            lblMov.Text = "" + playerMonsterType.Movement;
        }

        /// <summary>
        /// Activate current player monsters.
        /// </summary>
        private void activateCurrPlayer()
        {
            disableAllButtons();

            for (int j = 0; j < players[turn].ListMonsters.Count; j++)
            {
                listButtons[players[turn].ListMonsters[j].Position].Enabled = true;
            }

            activateColors();
        }

        private void activateColors()
        {
            for (int j = 0; j < players[turn].ListMonsters.Count; j++)
            {
                listButtons[players[turn].ListMonsters[j].Position].BackColor = Color.FromArgb(80, Color.Gold);
            }
        }



        private void defend(int dice, int newAtk)
        {
            newDef = defendingMonster.Defense;
            newDef += dice;
            LblDefMonsterName.Text = defendingMonster.Name;
            LblNewDefenseValue.Text = ": " + newDef;

            if (newAtk - newDef >= 4)
            {
                kill("Attacker");
            }
            else if (newAtk - newDef <= 3 && newAtk - newDef >= 1)
            {
                push("Attacker");
            }
            else if (newAtk == newDef)
            {
                push("Attacker");
            }
            else if (newDef - newAtk >= 4)
            {
                kill("Defender");
            }
            else if (newDef - newAtk <= 3 && newDef - newAtk >= 1)
            {
                push("Defender");
            }

        }

        private void push(String winner)
        {
            setAtkDef();

            if (winner.Equals("Attacker"))
            {
                pushMonster(tmpDef, defendingMonster, winner);
            }

            else if (winner.Equals("Defender"))
            {
                pushMonster(tmpAtk, attackingMonster, winner);

            }

        }

        private void pushMonster(int tmpVal, Monster monsterInvolved, String winner)
        {
            for (int i = 0; i < players[tmpVal].ListMonsters.Count; i++)
            {
                if (monsterInvolved == players[tmpVal].ListMonsters[i])
                {
                    for (int j = 0; j < listButtons.Count; j++)
                    {
                        if (j == monsterInvolved.Position)
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
                            int newPos = 0;

                            if (accessibleButtons.Count > 0)
                            {
                                newPos = accessibleButtons[random.Next(accessibleButtons.Count)];
                            }
                            else if (accessibleButtons.Count == 0)
                            {
                                if (monsterInvolved == defendingMonster)
                                {
                                    kill("Attacker");
                                    break;
                                }
                                else if (monsterInvolved == attackingMonster)
                                {
                                    kill("Defender");
                                    break;
                                }
                            }


                            setMonsterImg(players[tmpVal].ListMonsters[i].Position, null);
                            players[tmpVal].ListMonsters[i].Position = newPos;
                            setMonsterImg(newPos, players[tmpVal].ListMonsters[i].Picture);

                            if (accessibleButtons.Count > 0)
                            {
                                addLogPush(winner, tmpAtk);
                            }

                            break;
                        }
                    }
                }
            }
        }

        private void kill(String winner)
        {
            setAtkDef();
            addLogKill(winner, tmpAtk);
            if (winner.Equals("Attacker"))
            {
                killMonster(tmpDef, defendingMonster);
            }
            else if (winner.Equals("Defender"))
            {
                killMonster(tmpAtk, attackingMonster);
            }
        }

        private void setAtkDef()
        {
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
        }

        private void killMonster(int tmpVal, Monster monsterInvolved)
        {
            for (int i = 0; i < players[tmpVal].ListMonsters.Count; i++)
            {
                if (monsterInvolved == players[tmpVal].ListMonsters[i])
                {
                    players[tmpVal].ListMonsters.Remove(players[tmpVal].ListMonsters[i]);

                    for (int j = 0; j < listButtons.Count; j++)
                    {
                        if (j == monsterInvolved.Position)
                        {
                            listButtons[j].BackgroundImage = null;
                            break;
                        }
                    }
                }
            }
        }

        
        private void addLogPush(string winner, int tmpAtk)
        {
            string pos = "";
            String logTemp = "";

            if (tmpAtk == 0)
            {
                if (winner.Equals("Attacker"))
                {
                    pos = findTagButton(defendingMonster);
                    logTemp = "Round " + newRound + " : Player 1's monster : " + attackingMonster.Name + " pushed Player 2's monster : " + defendingMonster.Name + " to " + pos;
                }
                else
                {
                    pos = findTagButton(attackingMonster);
                    logTemp = "Round " + newRound + " : Player 2's monster : " + defendingMonster.Name + " pushed Player 1's monster : " + attackingMonster.Name + " to " + pos;
                }
            }
            //player 2 is attacker
            else
            {
                if (winner.Equals("Attacker"))
                {
                    pos = findTagButton(defendingMonster);
                    logTemp = "Round " + newRound + " : Player 2's monster : " + attackingMonster.Name + " pushed Player 1's monster : " + defendingMonster.Name + " to " + pos;
                }
                else
                {
                    pos = findTagButton(attackingMonster);
                    logTemp = "Round " + newRound + " : Player 1's monster : " + defendingMonster.Name + " pushed Player 2's monster : " + attackingMonster.Name + " to " + pos;
                }
            }
            ListBoxLog.Items.Add(logTemp);
        }


        private void addLogKill(string winner, int tmpAtk)
        {
            String logTemp = "";
            if (tmpAtk == 0)
            {
                if (winner.Equals("Attacker"))
                {
                    logTemp = "Round " + newRound + " : Player 1's monster : " + attackingMonster.Name + " killed Player 2's monster : " + defendingMonster.Name;
                }
                else if (winner.Equals("Defender"))
                {
                    logTemp = "Round " + newRound + " : Player 2's monster : " + defendingMonster.Name + " killed Player 1's monster : " + attackingMonster.Name;
                }
            }
            //if player 2 is attacking
            else
            {
                if (winner.Equals("Attacker"))
                {
                    logTemp = "Round " + newRound + " : Player 2's monster : " + attackingMonster.Name + " killed Player 1's monster : " + defendingMonster.Name;
                }
                else if (winner.Equals("Defender"))
                {
                    logTemp = "Round " + newRound + " : Player 1's monster : " + defendingMonster.Name + " killed Player 2's monster : " + attackingMonster.Name;
                }
            }
            ListBoxLog.Items.Add(logTemp);
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
            Application.Exit();
        }

        private void exitMainMenu()
        {
            player1.DejarikGamesLost++;
            this.Hide();
            MenuAccueil newMenuAccueil = new MenuAccueil();
            newMenuAccueil.Player1 = player1;
            newMenuAccueil.ShowDialog();
            this.Close();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMainMenu();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Dejarik_Holochess_Rules.pdf");
        }
    }
}
