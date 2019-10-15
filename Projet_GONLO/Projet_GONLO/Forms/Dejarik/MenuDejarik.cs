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
    public partial class MenuDejarik : Form
    {
        private Boolean multiplayer = false;

        public MenuDejarik()
        {
            InitializeComponent();
           
        }

        private void BtnSolo_Click(object sender, EventArgs e)
        {

            multiplayer = false;
            PnlChooseMonster.Visible = true;
            PnlChooseOption.Visible = false;
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            multiplayer = true;
            PnlChooseMonster.Visible = true;
            PnlChooseOption.Visible = false;
        }

        private void BtnGhhhk_Click(object sender, EventArgs e)
        {
            btnClick(BtnGhhhk, BtnHoujix);
        }
 

        private void BtnHoujix_Click(object sender, EventArgs e)
        {
            btnClick(BtnGhhhk, BtnHoujix);
        }

        private void BtnKintanStrider_Click(object sender, EventArgs e)
        {
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnNgok_Click(object sender, EventArgs e)
        {
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnKlorslug_Click(object sender, EventArgs e)
        {
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnGrimtaash_Click(object sender, EventArgs e)
        {
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnMantellian_Click(object sender, EventArgs e)
        {
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void BtnMonnok_Click(object sender, EventArgs e)
        {
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void btnClick(Button btnGhhhk, Button btnHoujix)
        {
            btnGhhhk.Enabled = false;
            btnHoujix.Enabled = false;
            addMonsterToPlayer(btnGhhhk);
            checkMonsterFinish();
            nextTurn();
        }

        private void addMonsterToPlayer(Button btnGhhhk)
        {
            
        }

        private void checkMonsterFinish()
        {
            if (BtnGhhhk.Enabled == false && BtnHoujix.Enabled == false
                && BtnKintanStrider.Enabled == false && BtnNgok.Enabled == false
                && BtnKlorslug.Enabled == false && BtnGrimtaash.Enabled == false
                && BtnMantellian.Enabled == false && BtnMonnok.Enabled == false)
            {
                Hide();
                Dejarik newDejarikGame = new Dejarik();
                newDejarikGame.ShowDialog();
                this.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            MenuAccueil menu = new MenuAccueil();
            menu.ShowDialog();
            this.Close();
        }

        private void nextTurn()
        {
            if (multiplayer)
            {
                changeLabel();
            }
            else
            {
                computerPick();
                checkMonsterFinish();
            }
        }

        private void computerPick()
        {
            if (BtnGhhhk.Enabled == true && BtnHoujix.Enabled == true)
            {
                String message = "The computer chose the monster Ghhhk, you have then be assigned the monster Houjix";
                computerChoose(BtnGhhhk, BtnHoujix, message);
            }
            else if (BtnKintanStrider.Enabled == true && BtnNgok.Enabled == true)
            {
                String message = "The computer chose the monster Kintan Strider, you have then be assigned the monster Ngok";
                computerChoose(BtnKintanStrider, BtnNgok, message);
            }
            else if (BtnKlorslug.Enabled == true && BtnGrimtaash.Enabled == true)
            {
                String message = "The computer chose the monster Klorslug, you have then be assigned the monster Grimstaash";
                computerChoose(BtnKlorslug, BtnGrimtaash, message);
            }
            else
            {
                String message = "The computer chose the monster Mantellian, you have then be assigned the monster Monnok";
                computerChoose(BtnMantellian, BtnMonnok, message);
            }

         }

        private void computerChoose(Button btnGhhhk, Button btnHoujix, string message)
        {
            btnGhhhk.Enabled = false;
            btnHoujix.Enabled = false;
            MessageBox.Show(message);
        }

        private void changeLabel()
        {
            if (LblMenuPlayerTurn.Text.Equals("Player 1 choose one monster for each category  "))
            {
                LblMenuPlayerTurn.Text = "Player 2 choose one monster for each category  ";
                Refresh();
            }
            else
            {
                LblMenuPlayerTurn.Text = "Player 1 choose one monster for each category  ";
                Refresh();
            }
        }
    }

}
