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

        public MenuDejarik()
        {
            InitializeComponent();
           

        }

        private void BtnSolo_Click(object sender, EventArgs e)
        {
            PnlChooseMonster.Visible = true;
            PnlChooseOption.Visible = false;

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            PnlChooseMonster.Visible = true;
            PnlChooseOption.Visible = false;
        }

        private void BtnGhhhk_Click(object sender, EventArgs e)
        {
            BtnGhhhk.Enabled = false;
            BtnHoujix.Enabled = false;
            checkMonsterFinish();
        }

 

        private void BtnHoujix_Click(object sender, EventArgs e)
        {
            BtnGhhhk.Enabled = false;
            BtnHoujix.Enabled = false;
            checkMonsterFinish();
        }

        private void BtnKintanStrider_Click(object sender, EventArgs e)
        {
            BtnKintanStrider.Enabled = false;
            BtnNgok.Enabled = false;
            checkMonsterFinish();
        }

        private void BtnNgok_Click(object sender, EventArgs e)
        {
            BtnKintanStrider.Enabled = false;
            BtnNgok.Enabled = false;
            checkMonsterFinish();
        }

        private void BtnKlorslug_Click(object sender, EventArgs e)
        {
            BtnKlorslug.Enabled = false;
            BtnGrimtaash.Enabled = false;
            checkMonsterFinish();
        }

        private void BtnGrimtaash_Click(object sender, EventArgs e)
        {
            BtnKlorslug.Enabled = false;
            BtnGrimtaash.Enabled = false;
            checkMonsterFinish();
        }

        private void BtnMantellian_Click(object sender, EventArgs e)
        {
            BtnMantellian.Enabled = false;
            BtnMonnok.Enabled = false;
            checkMonsterFinish();
        }

        private void BtnMonnok_Click(object sender, EventArgs e)
        {
            BtnMantellian.Enabled = false;
            BtnMonnok.Enabled = false;
            checkMonsterFinish();
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
    }

}
