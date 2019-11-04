using Projet_GONLO.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Projet_GONLO
{
    public partial class Dejarik : Form
    {
        List<Button> listButtons;
        List<Player> players = new List<Player>();
        Player player1 = new Player();
        Player player2 = new Player();
        Player currPlayer;
        Player otherPlayer;

        List<int> monsterPosPlayer1 = new List<int> { 20, 21, 22, 23 };
        List<int> monsterPosPlayer2 = new List<int> { 14, 15, 16, 17 };

        internal Player Player2 { get => player2; set => player2 = value; }

        internal Player Player1 { get => player1; set => player1 = value; }

        public Dejarik()
        {
            InitializeComponent();
            initalizeListButtons();
            Tile.CreateTiles();
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
        }

        private void setButton(int x, Image img)
        {
            if (img != null)
            {
                listButtons[x].BackgroundImageLayout = ImageLayout.Stretch;
                listButtons[x].Image = img;
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
            //CREATE COMPTEUR FOR MOVEMENT
            //if currentPlayer.currentMonster compteur de mouvement then end movement
            //if currentPlayer already attacked, he stills can move
            //if currentPlayer has moved and attacked, then end turn
            endTurn();

            int currPosition = Int32.Parse(((Button)sender).Tag.ToString());
            Monster currMonster = getClickMonster(currPosition);
            List<int> accessibleButtons = new List<int>();

            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].BackColor = Color.Transparent;
                listButtons[i].Enabled = false;
            }

            for (int j = 0; j < Tile.ListTiles[currPosition].ListMovement.Count; j++)
            {
                accessibleButtons.Add(Tile.ListTiles[currPosition].ListMovement[j].Number);
            }

            activateMovButtons(accessibleButtons, currPosition);
            activateAttackButtons(accessibleButtons, currPosition);

        }

        private void endTurn()
        {
            Player playerTmp = new Player();

            //Change current Player
            playerTmp = currPlayer;
            currPlayer = otherPlayer;
            otherPlayer = playerTmp;
        }

        private void activateMovButtons(List<int> accessibleButtons, int currPosition)
        {
            //Activate accessible buttons
            for (int i = 0; i < accessibleButtons.Count; i++)
            {
                listButtons[accessibleButtons[i]].BackColor = Color.Green;
                listButtons[accessibleButtons[i]].Enabled = true;
            }
        }

        private void activateAttackButtons(List<int> accessibleButtons, int currPosition)
        {
            //Activate accessible buttons
            for (int i = 0; i < accessibleButtons.Count; i++)
            {
                //Attack
                if (checkForAttack(accessibleButtons[i]))
                {
                    listButtons[accessibleButtons[i]].BackColor = Color.Yellow;
                    listButtons[accessibleButtons[i]].Enabled = true;
                }
            }
        }

        private Boolean checkForAttack(int accessible)
        {
            Boolean attack = false;
            for (int i = 0; i < otherPlayer.ListMonsters.Count; i++)
            {
                if (accessible == otherPlayer.ListMonsters[i].Position)
                {
                    attack = true;
                }
            }
            return attack;
        }

        private Monster getClickMonster(int currPosition)
        {
            Monster currMonster = new Monster();
            for (int i = 0; i < listButtons.Count; i++)
            {
                if (currPosition == currPlayer.AttMonster.Position)
                {
                    currMonster = currPlayer.AttMonster;
                    break;
                }

                else if (currPosition == currPlayer.DefMonster.Position)
                {
                    currMonster = currPlayer.DefMonster;
                    break;
                }

                else if (currPosition == currPlayer.MovMonster.Position)
                {
                    currMonster = currPlayer.MovMonster;
                    break;
                }

                else if (currPosition == currPlayer.PowMonster.Position)
                {
                    currMonster = currPlayer.PowMonster;
                    break;
                }
            }
            return currMonster;
        }

        private void Dejarik_Load(object sender, EventArgs e)
        {
            initializeMonsterPosition();
            player1.ListMonsters = new List<Monster> { player1.AttMonster, player1.DefMonster, player1.MovMonster, player1.PowMonster };
            player2.ListMonsters = new List<Monster> { player2.AttMonster, player2.DefMonster, player2.MovMonster, player2.PowMonster };
            currPlayer = player1;
            otherPlayer = player2;
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
            Dejarik newDejarik = new Dejarik();
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
    }
}
