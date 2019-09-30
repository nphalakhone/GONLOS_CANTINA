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

        BorderStyle style3D = BorderStyle.Fixed3D;
        BorderStyle styleNone = BorderStyle.None;

        public CreationPerso()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void BtnInfoMand_Click(object sender, EventArgs e)
        {
            if (this.GBoxMandalorian.Height == 725)
            {
                this.GBoxMandalorian.Height = 425;
                BtnInfoMand.Location = new Point(65, 350);
                BtnInfoMand.BackgroundImage = Properties.Resources.arrows;
            }
            else if (this.GBoxMandalorian.Height == 425)
            {
                this.GBoxMandalorian.Height = 725;
                BtnInfoMand.Location = new Point(65, 685);
                BtnInfoMand.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        private void BtnInfoZab_Click(object sender, EventArgs e)
        {
            if (this.GBoxZabrak.Height == 725)
            {
                this.GBoxZabrak.Height = 425;
                BtnInfoZab.Location = new Point(65, 350);
                BtnInfoZab.BackgroundImage = Properties.Resources.arrows;
            }
            else if (this.GBoxZabrak.Height == 425)
            {
                this.GBoxZabrak.Height = 725;
                BtnInfoZab.Location = new Point(65, 685);
                BtnInfoZab.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        private void BtnInfoSPB_Click(object sender, EventArgs e)
        {
            if (this.GBoxSPB.Height == 725)
            {
                this.GBoxSPB.Height = 425;
                BtnInfoSPB.Location = new Point(65, 350);
                BtnInfoSPB.BackgroundImage = Properties.Resources.arrows;
            }
            else if (this.GBoxSPB.Height == 425)
            {
                this.GBoxSPB.Height = 725;
                BtnInfoSPB.Location = new Point(65, 685);
                BtnInfoSPB.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        private void BtnInfoTwi_Click(object sender, EventArgs e)
        {
            if (this.GBoxTwilek.Height == 725)
            {
                this.GBoxTwilek.Height = 425;
                BtnInfoTwi.Location = new Point(65, 350);
                BtnInfoTwi.BackgroundImage = Properties.Resources.arrows;
            }
            else if (this.GBoxTwilek.Height == 425)
            {
                this.GBoxTwilek.Height = 725;
                BtnInfoTwi.Location = new Point(65, 685);
                BtnInfoTwi.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        private void BtnInfoCath_Click(object sender, EventArgs e)
        {
            if (this.GBoxCathar.Height == 725)
            {
                this.GBoxCathar.Height = 425;
                BtnInfoCath.Location = new Point(65, 350);
                BtnInfoCath.BackgroundImage = Properties.Resources.arrows;
            }
            else if (this.GBoxCathar.Height == 425)
            {
                this.GBoxCathar.Height = 725;
                BtnInfoCath.Location = new Point(65, 685);
                BtnInfoCath.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        private void BtnInfoHum_Click(object sender, EventArgs e)
        {
            if (this.GBoxHuman.Height == 725)
            {
                this.GBoxHuman.Height = 425;
                BtnInfoHum.Location = new Point(65, 350);
                BtnInfoHum.BackgroundImage = Properties.Resources.arrows;
            }
            else if (this.GBoxHuman.Height == 425)
            {
                this.GBoxHuman.Height = 725;
                BtnInfoHum.Location = new Point(65, 685);
                BtnInfoHum.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        private void CheckPanelBorderStyle()
        {
            if (RPnlImgMando.BorderStyle == style3D)
            {
                RPnlImgMando.BorderStyle = styleNone;
            }
            else if (RPnlImgZabrak.BorderStyle == style3D)
            {
                RPnlImgZabrak.BorderStyle = styleNone;
            }
            else if (RPnlImgSPB.BorderStyle == style3D)
            {
                RPnlImgSPB.BorderStyle = styleNone;
            }
            else if (RPnlImgTwi.BorderStyle == style3D)
            {
                RPnlImgTwi.BorderStyle = styleNone;
            }
            else if (RPnlImgCath.BorderStyle == style3D)
            {
                RPnlImgCath.BorderStyle = styleNone;
            }
            else if (RPnlImgHum.BorderStyle == style3D)
            {
                RPnlImgHum.BorderStyle = styleNone;
            }
        }

        private void RPnlImgMando_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgMando.BorderStyle = style3D;
            
        }

        private void RPnlImgZabrak_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgZabrak.BorderStyle = style3D;
        }

        private void RPnlImgSPB_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgSPB.BorderStyle = style3D;
        }

        private void RPnlImgTwi_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgTwi.BorderStyle = style3D;
        }

        private void RPnlImgCath_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgCath.BorderStyle = style3D;
        }

        private void RPnlImgHum_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgHum.BorderStyle = style3D;
        }

        private void CBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxFemale.Checked == true)
            {
                CBoxFemale.Checked = false;
            }
            else
            {
                CBoxMale.Checked = true;
            }
        }

        private void CBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxMale.Checked == true)
            {
                CBoxMale.Checked = false;
            }
            else
            {
                CBoxFemale.Checked = true;
            }
        }
    }

 }
