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
    public partial class Dejarik : Form
    {
        public Dejarik()
        {
            InitializeComponent();
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
    }
}
