using Projet_GONLO.Classes.Dejarik;
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
        private ComputerDejarik cpu = new ComputerDejarik();
        Monster mantellianSavrip, monnok, ghhhk, houjix, kintanStrider, ngok, klorslug, grimtaash;
        Player playerMenuDejarik = new Player();

        internal Player Player1 { get => playerMenuDejarik; set => playerMenuDejarik = value; }

        public MenuDejarik()
        {
            InitializeComponent();       
            createMonsters();
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
            playerMenuDejarik.AttMonster = ghhhk;
            cpu.AttMonster = houjix;
            btnClick(BtnGhhhk, BtnHoujix);           
        }
 

        private void BtnHoujix_Click(object sender, EventArgs e)
        {
            playerMenuDejarik.AttMonster = houjix;
            cpu.AttMonster = ghhhk;
            btnClick(BtnGhhhk, BtnHoujix);
        }

        private void BtnKintanStrider_Click(object sender, EventArgs e)
        {
            playerMenuDejarik.DefMonster = kintanStrider;
            cpu.DefMonster = ngok;
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnNgok_Click(object sender, EventArgs e)
        {
            playerMenuDejarik.DefMonster = ngok;
            cpu.DefMonster = kintanStrider;
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnKlorslug_Click(object sender, EventArgs e)
        {
            playerMenuDejarik.MovMonster = klorslug;
            cpu.MovMonster = grimtaash;
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnGrimtaash_Click(object sender, EventArgs e)
        {
            playerMenuDejarik.MovMonster = grimtaash;
            cpu.MovMonster = klorslug;
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnMantellian_Click(object sender, EventArgs e)
        {
            playerMenuDejarik.PowMonster = mantellianSavrip;
            cpu.PowMonster = monnok;
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void BtnMonnok_Click(object sender, EventArgs e)
        {
            playerMenuDejarik.PowMonster = monnok;
            cpu.PowMonster = mantellianSavrip;
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void btnClick(Button btnGhhhk, Button btnHoujix)
        {
            btnGhhhk.Enabled = false;
            btnHoujix.Enabled = false;
            checkMonsterFinish();
            nextTurn();
        }

        private void createMonsters()
        {
            mantellianSavrip = new Monster("The Mantellian Savrip", 2, 3, 2, (Image)Properties.Resources.ResourceManager.GetObject("Mantellian_Savrip"), typeMonster.Power, 0);
            monnok = new Monster("The Monnok", 3, 2, 2, (Image)Properties.Resources.ResourceManager.GetObject("Monnok"), typeMonster.Power, 0);
            ghhhk = new Monster("The Ghhhk", 3, 2, 1, (Image)Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 0);
            houjix = new Monster("The Houjix", 3, 1, 2, (Image)Properties.Resources.ResourceManager.GetObject("houjix"), typeMonster.Offensive, 0);
            kintanStrider = new Monster("The Kintan Strider", 1, 3, 2, (Image)Properties.Resources.ResourceManager.GetObject("Kintan_Strider"), typeMonster.Defensive, 0);
            ngok = new Monster("The Ng'ok", 2, 3, 1, (Image)Properties.Resources.ResourceManager.GetObject("Ngok"), typeMonster.Defensive, 0);
            klorslug = new Monster("The K'lor'slug", 2, 1, 3, (Image)Properties.Resources.ResourceManager.GetObject("klorslaug"), typeMonster.Mobile, 0);
            grimtaash = new Monster("Grimtaash the Molator", 1, 2, 3, (Image)Properties.Resources.ResourceManager.GetObject("grimtaash"), typeMonster.Mobile, 0);
        }


        private void checkMonsterFinish()
        {
            if (BtnGhhhk.Enabled == false && BtnHoujix.Enabled == false
                && BtnKintanStrider.Enabled == false && BtnNgok.Enabled == false
                && BtnKlorslug.Enabled == false && BtnGrimtaash.Enabled == false
                && BtnMantellian.Enabled == false && BtnMonnok.Enabled == false)
            {
                Hide();
                Dejarik newDejarikGame = new Dejarik(multiplayer);
                newDejarikGame.Computer = cpu;
                newDejarikGame.Player1 = playerMenuDejarik;
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
            menu.Player1 = playerMenuDejarik;
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
                String message = "The computer chose the monster Ghhhk, you have then be assigned the monster Houjix " + playerMenuDejarik.Name;
                computerChoose(BtnGhhhk, BtnHoujix, message);
                cpu.AttMonster = houjix;
                playerMenuDejarik.AttMonster = ghhhk;
            }
            else if (BtnKintanStrider.Enabled == true && BtnNgok.Enabled == true)
            {
                String message = "The computer chose the monster Kintan Strider, you have then be assigned the monster Ngok";
                computerChoose(BtnKintanStrider, BtnNgok, message);
                cpu.DefMonster = kintanStrider;
                playerMenuDejarik.DefMonster = ngok;
            }
            else if (BtnKlorslug.Enabled == true && BtnGrimtaash.Enabled == true)
            {
                String message = "The computer chose the monster Klorslug, you have then be assigned the monster Grimstaash ";
                computerChoose(BtnKlorslug, BtnGrimtaash, message);
                cpu.MovMonster = klorslug;
                playerMenuDejarik.MovMonster = grimtaash;
            }
            else
            {
                String message = "The computer chose the monster Mantellian, you have then be assigned the monster Monnok";
                computerChoose(BtnMantellian, BtnMonnok, message);
                cpu.PowMonster = mantellianSavrip;
                playerMenuDejarik.PowMonster = monnok;
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
