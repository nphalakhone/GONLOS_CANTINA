using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public partial class MenuAccueil : Form
    {
        public MenuAccueil()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            
        }

        bool etatWelcome = true;
        bool etatGonlo = true;
        int len1;
        int len2;
        string txt1;
        string txt2;

        private void MenuAccueil_Load(object sender, EventArgs e)
        {
            txt1 = LblWelcome.Text;
            txt2 = LblGonlo.Text;
            len1 = txt1.Length;
            len2 = txt2.Length;
            RPnlPazaak.Hide();
            RPnlDejarik.Hide();
            RPnlSBR.Hide();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void BtnEllPazaak_Click(object sender, EventArgs e)
        {
            RPnlDejarik.Hide();
            RPnlSBR.Hide();
            RPnlPazaak.Show();
            this.Refresh();
        }

        private void BtnEllDejarik_Click(object sender, EventArgs e)
        {
            RPnlPazaak.Hide();
            RPnlSBR.Hide();
            RPnlDejarik.Show();
            this.Refresh();
        }

        private void BtnEllSB_Click(object sender, EventArgs e)
        {
            RPnlPazaak.Hide();
            RPnlDejarik.Hide();
            RPnlSBR.Show();
            this.Refresh();
        }

        private void BtnEllSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerSlide1_Tick(object sender, EventArgs e)
        {

            //label1
            if (LblWelcome.Left < this.Width)
            {
                LblWelcome.Left += 5;
            }
            else
            {
                if (etatWelcome == true)
                {
                    LblWelcome.Font = new Font("Aurek-Besh", 14);
                    LblWelcome.Left = -1300;
                    etatWelcome = false;
                }
                else
                {
                    LblWelcome.Left = -1200;
                    LblWelcome.Font = new Font("SF Distant Galaxy Alternate", 25);
                    etatWelcome = true;
                } 
            }

            //label2
            if (LblGonlo.Left < this.Width)
            {
                LblGonlo.Left += 5;
            }
            else
            {
                if (etatGonlo == true)
                {
                    LblGonlo.Font = new Font("Aurek-Besh", 14);
                    LblGonlo.Left = -1300;
                    etatGonlo = false;
                }
                else
                {
                    LblGonlo.Left = -1200;
                    LblGonlo.Font = new Font("SF Distant Galaxy Alternate", 25);
                    etatGonlo = true;
                }
            }
        }

        private void BtnEllPlayPazaak_Click(object sender, EventArgs e)
        {
            Hide();
            PazaakCardsSelector pazaakCards = new PazaakCardsSelector();
            pazaakCards.ShowDialog();
            this.Close();
            //Hide();
            //Pazaak newPazaakGame = new Pazaak();
            //newPazaakGame.ShowDialog();
            //this.Close();

        }

        private void BtnEllPlayDejarik_Click(object sender, EventArgs e)
        {
            Hide();
            Dejarik newDejarikGame = new Dejarik();
            newDejarikGame.ShowDialog();
            this.Close();
        }
    }
}
