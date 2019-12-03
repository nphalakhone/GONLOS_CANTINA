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
    public partial class StartForm : Form
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This click event method closes the current form and opens the CharacCreator form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacCreator creationPerso = new CharacCreator();
            creationPerso.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// This click event method closes the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This click event method closes the current form and opens the load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadForm load = new LoadForm();
            load.ShowDialog();
            this.Close();
        }
    }
}
