using Projet_GONLO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Projet_GONLO.Classes.Dejarik;
using System.Media;

namespace Projet_GONLO
{
    public partial class MenuDejarik : Form
    {
        Monster mantellianSavrip, monnok, ghhhk, houjix, kintanStrider, ngok, klorslug, grimtaash;
        Player player1 = new Player();
        Player player2 = new Player();
        SoundPlayer sound = new SoundPlayer(Properties.Resources.Dejarik_Cantina);
        private int playerTurn = 1;
        String logMonster = "";


        internal Player Player1 { get => player1; set => player1 = value; }
        internal Player Player2 { get => player2; set => player2 = value; }

        public MenuDejarik()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            sound.PlayLooping();
            createMonsters();
            setBtnInfoExtender();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void groupBoxExtended(GroupBox gb, Button button)
        {
            if (gb.Height == 635)
            {
                gb.Height = 265;
                button.Location = new Point(57, 212);
                button.BackgroundImage = Properties.Resources.arrows;
            }
            else if (gb.Height == 265)
            {
                gb.Height = 635;
                button.Location = new Point(57, 212);
                button.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        private void setBtnInfoExtender()
        {
            BtnInfoGHHHK.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpGhhhk, BtnInfoGHHHK); };
            BtnInfoHoujix.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpHoujix, BtnInfoHoujix); };
            BtnInfoKintanStrider.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpKintanStrider, BtnInfoKintanStrider); };
            BtnInfoNgok.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpNgok, BtnInfoNgok); };
            BtnInfoKlorslug.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpKlorslug, BtnInfoKlorslug); };
            buBtnInfoGrimstaash.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpGrimstaash, buBtnInfoGrimstaash); };
            BtnInfoMantellian.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpMantellian, BtnInfoMantellian); };
            BtnInfoMonnok.Click += (sender, EventArgs) => { ClickInfoMonsters(sender, EventArgs, grpMonnok, BtnInfoMonnok); };
        }

        private void ClickInfoMonsters(object sender, EventArgs e, GroupBox gbox, Button btnInfo)
        {
            groupBoxExtended(gbox, btnInfo);
        }

        private void BtnGhhhk_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.AttMonster = ghhhk;
                player2.AttMonster = houjix;
                logMonster += "Player 1 chose the monster : Ghhhk-";
                logMonster += "Player 2 gets the monster : Houjix-";
            }
            else
            {
                player2.AttMonster = ghhhk;
                player1.AttMonster = houjix;
                logMonster += "Player 2 chose the monster : Ghhhk-";
                logMonster += "Player 1 gets the monster : Houjix-";
            }
            btnClick(BtnGhhhk, BtnHoujix);
        }


        private void BtnHoujix_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.AttMonster = houjix;
                player2.AttMonster = ghhhk;
                logMonster += "Player 1 chose the monster : Houjix-";
                logMonster += "Player 2 gets the monster : Ghhhk-";
            }
            else
            {
                player2.AttMonster = houjix;
                player1.AttMonster = ghhhk;
                logMonster += "Player 2 chose the monster : Houjix-";
                logMonster += "Player 1 gets the monster : Ghhhk-";
            }
            btnClick(BtnGhhhk, BtnHoujix);
        }

        private void BtnKintanStrider_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.DefMonster = kintanStrider;
                player2.DefMonster = ngok;
                logMonster += "Player 1 chose the monster : Kintan Strider-";
                logMonster += "Player 2 gets the monster : Ngok-";
            }
            else
            {
                player2.DefMonster = kintanStrider;
                player1.DefMonster = ngok;
                logMonster += "Player 2 chose the monster : Kintan Strider-";
                logMonster += "Player 1 gets the monster : Ngok-";
            }
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnNgok_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.DefMonster = ngok;
                player2.DefMonster = kintanStrider;
                logMonster += "Player 1 chose the monster : Ngok-";
                logMonster += "Player 2 gets the monster : Kintan Strider-";
            }
            else
            {
                player2.DefMonster = ngok;
                player1.DefMonster = kintanStrider;
                logMonster += "Player 2 chose the monster : Ngok-";
                logMonster += "Player 1 gets the monster : Kintan Strider-";
            }
            btnClick(BtnKintanStrider, BtnNgok);
        }

        private void BtnKlorslug_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.MovMonster = klorslug;
                player2.MovMonster = grimtaash;
                logMonster += "Player 1 chose the monster : Klorslug-";
                logMonster += "Player 2 gets the monster : Grimtaash-";
            }
            else
            {
                player2.MovMonster = klorslug;
                player1.MovMonster = grimtaash;
                logMonster += "Player 2 chose the monster : Klorslug-";
                logMonster += "Player 1 gets the monster : Grimtaash-";
            }
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnGrimtaash_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.MovMonster = grimtaash;
                player2.MovMonster = klorslug;
                logMonster += "Player 1 chose the monster : Grimtaash-";
                logMonster += "Player 2 gets the monster : Klorslug-";
            }
            else
            {
                player2.MovMonster = grimtaash;
                player1.MovMonster = klorslug;
                logMonster += "Player 2 chose the monster : Grimtaash-";
                logMonster += "Player 1 gets the monster : Klorslug-";
            }
            btnClick(BtnKlorslug, BtnGrimtaash);
        }

        private void BtnMantellian_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.PowMonster = mantellianSavrip;
                player2.PowMonster = monnok;
                logMonster += "Player 1 chose the monster : Mantellian Savrip-";
                logMonster += "Player 2 gets the monster : Monnok-";
            }
            else
            {
                player2.PowMonster = mantellianSavrip;
                player1.PowMonster = monnok;
                logMonster += "Player 2 chose the monster : Mantellian Savrip-";
                logMonster += "Player 1 gets the monster : Monnok-";
            }
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void BtnMonnok_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                player1.PowMonster = monnok;
                player2.PowMonster = mantellianSavrip;
                logMonster += "Player 1 chose the monster : Monnok-";
                logMonster += "Player 2 gets the monster : Mantellian Savrip-";
            }
            else
            {
                player2.PowMonster = monnok;
                player1.PowMonster = mantellianSavrip;
                logMonster += "Player 2 chose the monster : Monnok-";
                logMonster += "Player 1 gets the monster : Mantellian Savrip-";
            }
            btnClick(BtnMantellian, BtnMonnok);
        }

        private void picAtkValue_Click(object sender, EventArgs e)
        {

        }

        private void btnClick(Button monster1, Button monster2)
        {
            monster1.Enabled = false;
            monster2.Enabled = false;
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
                Dejarik newDejarikGame = new Dejarik(logMonster);
                newDejarikGame.Player2 = player2;
                newDejarikGame.Player1 = player1;
                newDejarikGame.ShowDialog();
                this.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound.Stop();
            this.Close();
        }

        private void ReturnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound.Stop();
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

        private void changeLabel()
        {
            if (LblMenuPlayerTurn.Text.Equals("Player 1 select one monster for each category  "))
            {
                LblMenuPlayerTurn.Text = "Player 2 select one monster for each category  ";
                Refresh();
                playerTurn = 2;
            }
            else
            {
                LblMenuPlayerTurn.Text = "Player 1 select one monster for each category  ";
                Refresh();
                playerTurn = 1;
            }
        }
    }

}
