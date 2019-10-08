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
        List<Button> listBoutons = new List<Button>();
        public Dejarik()
        {
            InitializeComponent();
            createMonsters();
            initialiserBoutons();
        }

        private void initialiserBoutons()
        {
            listBoutons.Add(new Button());
            listBoutons.Add(bouttonCercle1);
            listBoutons.Add(bouttonCercle2);
            listBoutons.Add(bouttonCercle3);
            listBoutons.Add(bouttonCercle4);
            listBoutons.Add(bouttonCercle5);
            listBoutons.Add(bouttonCercle6);
            listBoutons.Add(bouttonCercle7);
            listBoutons.Add(bouttonCercle8);
            listBoutons.Add(bouttonCercle9);
            listBoutons.Add(bouttonCercle10);
            listBoutons.Add(bouttonCercle11);
            listBoutons.Add(bouttonCercle12);
            listBoutons.Add(bouttonCercle13);
            listBoutons.Add(bouttonCercle14);
            listBoutons.Add(bouttonCercle15);
            listBoutons.Add(bouttonCercle16);
            listBoutons.Add(bouttonCercle17);
            listBoutons.Add(bouttonCercle18);
            listBoutons.Add(bouttonCercle19);
            listBoutons.Add(bouttonCercle20);
            listBoutons.Add(bouttonCercle21);
            listBoutons.Add(bouttonCercle22);
            listBoutons.Add(bouttonCercle23);
            listBoutons.Add(bouttonCercle24);
        }

        private void createMonsters()
        {
            Monster mantellianSavrip = new Monster("The Mantellian Savrip", 2, 3, 2, (Image)Properties.Resources.ResourceManager.GetObject("Mantellian_Savrip"), typeMonster.Power);
            Monster monnok = new Monster("The Monnok", 3, 2, 2, (Image)Properties.Resources.ResourceManager.GetObject("Monnok"), typeMonster.Power);
            Monster ghhhk = new Monster("The Ghhhk", 3, 2, 1, (Image)Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive);
            Monster houjix = new Monster("The Houjix", 3, 1, 2, (Image)Properties.Resources.ResourceManager.GetObject("houjix"), typeMonster.Offensive);
            Monster kintanStrider = new Monster("The Kintan Strider", 1, 3, 2, (Image)Properties.Resources.ResourceManager.GetObject("Kintan_Strider"), typeMonster.Defensive);
            Monster ngok = new Monster("The Ng'ok", 2, 3, 1, (Image)Properties.Resources.ResourceManager.GetObject("Ngok"), typeMonster.Defensive);
            Monster klorslug = new Monster("The K'lor'slug", 2, 1, 3, (Image)Properties.Resources.ResourceManager.GetObject("klorslaug"), typeMonster.Mobile);
            Monster grimtaash = new Monster("Grimtaash the Molator", 1, 2, 3, (Image)Properties.Resources.ResourceManager.GetObject("grimtaash"), typeMonster.Mobile);
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
