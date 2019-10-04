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
    public partial class MenuDejarik : Form
    {
        public MenuDejarik()
        {
            InitializeComponent();
           

        }

        private void BtnSolo_Click(object sender, EventArgs e)
        {
            PnlChooseMonster.Visible = true;
            PnlChooseOption.Visible = false;

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            PnlChooseMonster.Visible = true;
            PnlChooseOption.Visible = false;
        }
    }
}
