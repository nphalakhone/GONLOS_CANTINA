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
    public partial class Pazaak : Form
    {




        public Pazaak()
        {
            InitializeComponent();

            Cards c = new Cards();
            RPnlG1.BackgroundImage = c.getCartePlus(4);
            RPnlG2.BackgroundImage = c.getCarteMinus(2);
            RPnlG3.BackgroundImage = c.getCartePlusMinus(1);
            RPnlG4.BackgroundImage = c.getCarteNormal(7);



            //Cards c = new Cards();
            RPnlG1.BackgroundImage = c.getCartePlus(1);

            RPnlG1.BackgroundImageLayout = ImageLayout.Stretch;
            RPnlG2.BackgroundImageLayout = ImageLayout.Stretch;

            RPnlG3.BackgroundImageLayout = ImageLayout.Stretch;
            RPnlG4.BackgroundImageLayout = ImageLayout.Stretch;

        }
    }
}
