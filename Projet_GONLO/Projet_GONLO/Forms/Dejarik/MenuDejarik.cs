using Projet_GONLO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (playerTurn == 1)
            {
                player1.AttMonster = ghhhk;
                player2.AttMonster = houjix;
                
                //giveMonsterPLayer(player1.AttMonster, player2.AttMonster, ghhhk, houjix);
            }
            else
            {
                player2.AttMonster = ghhhk;
                player1.AttMonster = houjix;
                //giveMonsterPLayer(player2.AttMonster, player1.AttMonster, ghhhk, houjix);
            }

            btnClick(BtnGhhhk, BtnHoujix);
        }


        private void BtnHoujix_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.AttMonster = houjix;
                player2.AttMonster = ghhhk;
                //giveMonsterPLayer(player1.AttMonster, player2.AttMonster, houjix, ghhhk);
            }
            else
            {
                player2.AttMonster = houjix;
                player1.AttMonster = ghhhk;
                //giveMonsterPLayer(player2.AttMonster, player1.AttMonster, houjix, ghhhk);
            }
            btnClick(BtnGhhhk, BtnHoujix);
        }

        private void BtnKintanStrider_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.DefMonster = kintanStrider;
                player2.DefMonster = ngok;
                //giveMonsterPLayer(player1.DefMonster, player2.DefMonster, kintanStrider, ngok);
            }
            else
            {
                player2.DefMonster = kintanStrider;
                player1.DefMonster = ngok;
                //giveMonsterPLayer(player2.DefMonster, player1.DefMonster, kintanStrider, ngok);
            }
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnNgok_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.DefMonster = ngok;
                player2.DefMonster = kintanStrider;
                //giveMonsterPLayer(player1.DefMonster, player2.DefMonster, ngok, kintanStrider);
            }
            else
            {
                player2.DefMonster = ngok;
                player1.DefMonster = kintanStrider;
                //giveMonsterPLayer(player2.DefMonster, player1.DefMonster, ngok, kintanStrider);
            }
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnKlorslug_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.MovMonster = klorslug;
                player2.MovMonster = grimtaash;
                //giveMonsterPLayer(player1.MovMonster, player2.MovMonster, klorslug, grimtaash);
            }
            else
            {
                player2.MovMonster = klorslug;
                player1.MovMonster = grimtaash;
                //giveMonsterPLayer(player2.MovMonster, player1.MovMonster, klorslug, grimtaash);
            }
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnGrimtaash_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.MovMonster = grimtaash;
                player2.MovMonster = klorslug;
                //giveMonsterPLayer(player1.MovMonster, player2.MovMonster, grimtaash, klorslug);
            }
            else
            {
                player2.MovMonster = grimtaash;
                player1.MovMonster = klorslug;
                //giveMonsterPLayer(player2.MovMonster, player1.MovMonster, grimtaash, klorslug);
            }
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnMantellian_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.PowMonster = mantellianSavrip;
                player2.PowMonster = monnok;
                //giveMonsterPLayer(player1.PowMonster, player2.PowMonster, mantellianSavrip, monnok);
            }
            else
            {
                player2.PowMonster = mantellianSavrip;
                player1.PowMonster = monnok;
                //giveMonsterPLayer(player2.PowMonster, player1.PowMonster, mantellianSavrip, monnok);
            }
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void BtnMonnok_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.PowMonster = monnok;
                player2.PowMonster = mantellianSavrip;
                //giveMonsterPLayer(player1.PowMonster, player2.PowMonster, monnok, mantellianSavrip);
            }
            else
            {
                player2.PowMonster = monnok;
                player1.PowMonster = mantellianSavrip;
                //giveMonsterPLayer(player2.PowMonster, player1.PowMonster, monnok, mantellianSavrip);
            }
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void giveMonsterPLayer(Monster attMonster1, Monster attMonster2, Monster ghhhk, Monster houjix)
        {
            attMonster1 = ghhhk;
            attMonster2 = houjix;
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
                playerTurn = 2;
            }
            else
            {
                LblMenuPlayerTurn.Text = "Player 1 choose one monster for each category  ";
                Refresh();
                playerTurn = 1;
            }
        }
    }

}
