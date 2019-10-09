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
    public partial class PazaakCardsSelector : Form
    {
        public PazaakCardsSelector()
        {
            InitializeComponent();
        }

        private void RPnl1Plus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEllReady_Click(object sender, EventArgs e)
        {
            Hide();
            Pazaak newPazaakGame = new Pazaak();
            newPazaakGame.ShowDialog();
            this.Close();
        }
    }
}
