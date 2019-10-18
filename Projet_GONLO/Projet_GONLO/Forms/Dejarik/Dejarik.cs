using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public partial class Dejarik : Form
    {
        List<Button> listButtons;
        List<Player> players = new List<Player>();
        Player dejarikPlayer = new Player();

        public Dejarik()
        {
            InitializeComponent();
            initalizeListButtons();
        }

        private void initalizeListButtons()
        {
            listButtons = new List<Button>();
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
            listButtons.Add(Button14);
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
            listButtons.Add(Button1);

            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].Click += btn_Click;
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int currPosition = Int32.Parse(((Button)sender).Tag.ToString());
            List<int> accessibleButtons = new List<int>();

            for (int i = 0; i < listButtons.Count; i++)
            {
                listButtons[i].Enabled = false;
            }

           
            for (int i = 0; i < Tile.ListTiles[currPosition].ListMovement.Count; i++)
            {
                    accessibleButtons.Add(Tile.ListTiles[currPosition].ListMovement[i].Number);
            }


            //Activate accessible buttons
            for (int i = 0; i < accessibleButtons.Count; i++)
            {
                listButtons[accessibleButtons[i]].Enabled = true;
            }
            //timerTransport.Start();

        }

        

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dejarik_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

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
            string playerData = dejarikPlayer.Name + "," + dejarikPlayer.Species + "," + dejarikPlayer.Gender + "," + dejarikPlayer.PowMonster + "," + dejarikPlayer.AttMonster + "," + dejarikPlayer.DefMonster + "," + dejarikPlayer.MovMonster;
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
