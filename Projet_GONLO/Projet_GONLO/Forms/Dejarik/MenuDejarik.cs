using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public partial class MenuDejarik : Form
    {
        Monster mantellianSavrip, monnok, ghhhk, houjix, kintanStrider, ngok, klorslug, grimtaash;
        Player player1 = new Player();
        Player player2 = new Player();
        private int playerTurn = 1;


        internal Player Player1 { get => player1; set => player1 = value; }


        internal Player Player2 { get => player2; set => player2 = value; }

        public MenuDejarik()
        {
            InitializeComponent();       
            createMonsters();
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
                Dejarik newDejarikGame = new Dejarik();
                newDejarikGame.Player2 = player2;
                newDejarikGame.Player1 = player1;
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
            menu.Player1 = player1;
            menu.ShowDialog();
            this.Close();
        }

        private void nextTurn()
        {

                changeLabel();
            

                computerPick();
                checkMonsterFinish();
            
        }

        private void computerPick()
        {
            if (BtnGhhhk.Enabled == true && BtnHoujix.Enabled == true)
            {
                String message = "The computer chose the monster Ghhhk, you have then be assigned the monster Houjix " + player1.Name;
                computerChoose(BtnGhhhk, BtnHoujix, message);
                player2.AttMonster = houjix;
                player1.AttMonster = ghhhk;
            }
            else if (BtnKintanStrider.Enabled == true && BtnNgok.Enabled == true)
            {
                String message = "The computer chose the monster Kintan Strider, you have then be assigned the monster Ngok";
                computerChoose(BtnKintanStrider, BtnNgok, message);
                player2.DefMonster = kintanStrider;
                player1.DefMonster = ngok;
            }
            else if (BtnKlorslug.Enabled == true && BtnGrimtaash.Enabled == true)
            {
                String message = "The computer chose the monster Klorslug, you have then be assigned the monster Grimstaash ";
                computerChoose(BtnKlorslug, BtnGrimtaash, message);
                player2.MovMonster = klorslug;
                player1.MovMonster = grimtaash;
            }
            else
            {
                String message = "The computer chose the monster Mantellian, you have then be assigned the monster Monnok";
                computerChoose(BtnMantellian, BtnMonnok, message);
                player2.PowMonster = mantellianSavrip;
                player1.PowMonster = monnok;
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
