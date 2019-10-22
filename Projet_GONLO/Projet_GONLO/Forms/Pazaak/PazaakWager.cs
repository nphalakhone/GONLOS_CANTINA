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
    public partial class PazaakWager : Form
    {
        Player playerWager = new Player();

        public PazaakWager()
        {
            InitializeComponent();
        }

        internal Player Player1 { get => playerWager; set => playerWager = value; }

        private void PazaakWager_Load(object sender, EventArgs e)
        {
            BtnEllNext.Enabled = false;
        }

        private void BtnEllNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pazaak newPazaak = new Pazaak();
            newPazaak.ShowDialog();
            this.Close();
        }

        private void BtnEllBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PazaakCardsSelector pazaakCardsSelector = new PazaakCardsSelector();
            pazaakCardsSelector.ShowDialog();
            this.Close();
        }

        private void MTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string message = "Write down a number";
            MessageBox.Show(message);
        }

        private void MTxtBox_TextChanged(object sender, EventArgs e)
        {
            BtnEllNext.Enabled = true;
        }
    }
}
