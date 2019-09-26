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
    public partial class CreationPerso : Form
    {
        int gbheight;
        

        public CreationPerso()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.GBoxMandalorian.Height == 675)
            {
                this.GBoxMandalorian.Height = 425;
            }
            else if (this.GBoxMandalorian.Height == 425)
            {
                this.GBoxMandalorian.Height = 675;
            }
            
        }
    }
}
