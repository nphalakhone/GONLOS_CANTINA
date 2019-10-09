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
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void BtnEllBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm start = new StartForm();
            start.ShowDialog();
            this.Close();
        }

        private void BtnEllLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAccueil menu = new MenuAccueil();
            menu.ShowDialog();
            this.Close();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            BtnEllLoad.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BtnEllLoad.Enabled = true;
        }
    }
}
