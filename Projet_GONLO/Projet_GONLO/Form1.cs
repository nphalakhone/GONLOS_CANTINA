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
            InitializeComponent();
        }

        bool etatWelcome = true;
        bool etatGonlo = true;
        int counter = 0;
        int counter2 = 0;
        int len1 = 0;
        int len2 = 0;
        string txt1;
        string txt2;

        private void MenuAccueil_Load(object sender, EventArgs e)
        {
            txt1 = LblWelcome.Text;
            txt2 = LblGonlo.Text;
            len1 = txt1.Length;
            len2 = txt2.Length;
            //LblWelcomePartie1.Text = "";
            //LblGonlo.Text = "";
            timer1.Start();
            timer2.Start();


            

            this.DoubleBuffered = true;
        }

        

        private void Timer1_Tick(object sender, EventArgs e)
        {

            //counter++;
            //if (counter > len1)
            //{
            //    counter = 0;
            //    LblWelcomePartie1.Text = "";
            //    if (etat == true)
            //    {
            //        //  Lbltitre.Font = new Font("Aurek-Besh", Lbltitre.Font.Size);
            //        LblWelcomePartie1.Font = new Font("Aurek-Besh", LblWelcomePartie1.Font.Size);
            //        etat = false;
            //    }
            //    else
            //    {
            //        LblWelcomePartie1.Font = new Font("SF Distant Galaxy Alternate", LblWelcomePartie1.Font.Size);
            //        etat = true;
            //    }
            //}
            //else
            //{
            //    LblWelcomePartie1.Text = txt1.Substring(0, counter);
            //}
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            
            //counter2++;
            //if (counter2 > len2)
            //{
            //    counter2 = 0;
            //    LblGonlo.Text = "";
            //    if (etat == true)
            //    {
            //        LblGonlo.Font = new Font("Aurek-Besh", LblGonlo.Font.Size);
            //        etat = false;
            //    }
            //    else
            //    {
            //        LblGonlo.Font = new Font("SF Distant Galaxy Alternate", LblGonlo.Font.Size);
            //        etat = true;
            //    }
            //}
            //else
            //{
            //    LblGonlo.Text = txt2.Substring(0, counter2);
            //}
        }

        private void TickSlide1(object sender, EventArgs e)
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
                    LblWelcome.Font = new Font("Aurek-Besh", 12);
                    LblWelcome.Left = -1500;
                    etatWelcome = false;
                }
                else
                {
                    LblWelcome.Left = -675;
                    LblWelcome.Font = new Font("SF Distant Galaxy Alternate", 12);
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
                    LblGonlo.Font = new Font("Aurek-Besh", 12);
                    LblGonlo.Left = -1500;
                    etatGonlo = false;
                }
                else
                {
                    LblGonlo.Left = -675;
                    LblGonlo.Font = new Font("SF Distant Galaxy Alternate", 12);
                    etatGonlo = true;
                }
            }
        }
    }
}
