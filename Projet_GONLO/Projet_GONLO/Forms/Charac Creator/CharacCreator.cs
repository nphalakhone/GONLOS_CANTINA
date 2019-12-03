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
    public partial class CharacCreator : Form
    {
        //Global Variables
        Player player = new Player();
        BorderStyle style3D = BorderStyle.Fixed3D;
        BorderStyle styleNone = BorderStyle.None;
        GeneratedNamesList nameList = new GeneratedNamesList();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CharacCreator()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>
        /// This method expands a groupbox with the help of a button
        /// </summary>
        /// <param name="gb"></param>
        /// <param name="button"></param>
        public void groupBoxExtended(GroupBox gb, Button button)
        {
            if (gb.Height == 725)
            {
                gb.Height = 425;
                button.Location = new Point(65, 350);
                button.BackgroundImage = Properties.Resources.arrows;
            }
            else if (gb.Height == 425)
            {
                gb.Height = 725;
                button.Location = new Point(65, 685);
                button.BackgroundImage = Properties.Resources.arrowsUp;
            }
        }

        /// <summary>
        /// This click event method expands the groupbox to show a hidden text about the Mandalorian species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoMand_Click(object sender, EventArgs e)
        {
            groupBoxExtended(GBoxMandalorian, BtnInfoMand);
        }

        /// <summary>
        /// This click event method expands the groupbox to show a hidden text about the Zabrak species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoZab_Click(object sender, EventArgs e)
        {
            groupBoxExtended(GBoxZabrak, BtnInfoZab);
        }

        /// <summary>
        /// This click event method expands the groupbox to show a hidden text about the Sith Pureblood species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoSPB_Click(object sender, EventArgs e)
        {
            groupBoxExtended(GBoxSPB, BtnInfoSPB);
        }

        /// <summary>
        /// This click event method expands the groupbox to show a hidden text about the Twilek species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoTwi_Click(object sender, EventArgs e)
        {
            groupBoxExtended(GBoxTwilek, BtnInfoTwi);
        }

        /// <summary>
        /// This click event method expands the groupbox to show a hidden text about the Cathar species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoCath_Click(object sender, EventArgs e)
        {
            groupBoxExtended(GBoxCathar, BtnInfoCath);
        }

        /// <summary>
        /// This click event method expands the groupbox to show a hidden text about the Human species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoHum_Click(object sender, EventArgs e)
        {
            groupBoxExtended(GBoxHuman, BtnInfoHum);
        }

        /// <summary>
        /// This method verifies the species image panel border style 
        /// </summary>
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

        /// <summary>
        /// This click event method changes the Mandalorian panel border style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RPnlImgMando_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgMando.BorderStyle = style3D;
            
        }

        /// <summary>
        /// This click event method changes the Zabrak panel border style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RPnlImgZabrak_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgZabrak.BorderStyle = style3D;
        }

        /// <summary>
        /// This click event method changes the Sith Pureblood panel border style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RPnlImgSPB_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgSPB.BorderStyle = style3D;
        }

        /// <summary>
        /// This click event method changes the Twilek panel border style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RPnlImgTwi_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgTwi.BorderStyle = style3D;
        }

        /// <summary>
        /// This click event method changes the Cathar panel border style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RPnlImgCath_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgCath.BorderStyle = style3D;
        }

        /// <summary>
        /// This click event method changes the Human panel border style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RPnlImgHum_Click(object sender, EventArgs e)
        {
            CheckPanelBorderStyle();
            RPnlImgHum.BorderStyle = style3D;
        }

        /// <summary>
        /// This click event method checks the male CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This click event method checks the female CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method sets the default form when it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreationPerso_Load(object sender, EventArgs e)
        {
            BtnEllNext.Enabled = false;
            CBoxMale.Checked = true;
            RPnlImgMando.BorderStyle = style3D;
        }

        /// <summary>
        /// This click event method creates a player, close the current form and opens a Main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            player.Species = VerificationSpecies();
            player.Name = TxtBoxNameGen.Text;
            player.Credits = 500;
            player.PazaakGamesWon = 0;
            player.PazaakGamesLost = 0;
            player.DejarikGamesLost = 0;
            player.DejarikGamesWon = 0;
            MainForm menuAccueil = new MainForm();
            menuAccueil.Player1 = player;
            if (CBoxFemale.Checked)
            {
                player.Gender = "Female";
            }
            else if (CBoxMale.Checked)
            {
                player.Gender = "Male";
            }
            menuAccueil.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// This click event method close the current form and brings the user back to the StartForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startFrom = new StartForm();
            startFrom.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// This onkey event method enables the next button when the user writes down a name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBoxNameGen_TextChanged(object sender, EventArgs e)
        {
            BtnEllNext.Enabled = true;
        }

        /// <summary>
        /// This method verifies which species the user selected
        /// </summary>
        /// <returns> string species </returns>
        private string VerificationSpecies()
        {
            String species = "";
            if (RPnlImgMando.BorderStyle == style3D)
            {
                species = "Mandalorian";
            }
            else if (RPnlImgZabrak.BorderStyle == style3D)
            {
                species = "Zabrak";
            }
            else if (RPnlImgSPB.BorderStyle == style3D)
            {
                species = "Sith PureBlood";
            }
            else if (RPnlImgTwi.BorderStyle == style3D)
            {
                species = "Twi'lek";
            }
            else if (RPnlImgCath.BorderStyle == style3D)
            {
                species = "Cathar";
            }
            else if (RPnlImgHum.BorderStyle == style3D)
            {
                species = "Human";
            }
            return species;
        }

        /// <summary>
        /// This method select a random name depending on which species and which sex the user selected 
        /// </summary>
        public void GenderCheckName()
        {
            string gender = "";
            if (RPnlImgMando.BorderStyle == style3D && CBoxMale.Checked)
            {
                string playerName;
                gender = "M";
                playerName = nameList.getListNameMand(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgMando.BorderStyle == style3D && CBoxFemale.Checked)
            {
                string playerName;
                playerName = nameList.getListNameMand(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgZabrak.BorderStyle == style3D && CBoxMale.Checked)
            {
                string playerName;
                gender = "M";
                playerName = nameList.getListNameZab(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgZabrak.BorderStyle == style3D && CBoxFemale.Checked)
            {
                string playerName;
                playerName = nameList.getListNameZab(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgSPB.BorderStyle == style3D && CBoxMale.Checked)
            {
                string playerName;
                gender = "M";
                playerName = nameList.getListNameSPB(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgSPB.BorderStyle == style3D && CBoxFemale.Checked)
            {
                string playerName;
                playerName = nameList.getListNameSPB(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgTwi.BorderStyle == style3D && CBoxMale.Checked)
            {
                string playerName;
                gender = "M";
                playerName = nameList.getListNameTwilek(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgTwi.BorderStyle == style3D && CBoxFemale.Checked)
            {
                string playerName;
                playerName = nameList.getListNameTwilek(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgCath.BorderStyle == style3D && CBoxMale.Checked)
            {
                string playerName;
                gender = "M";
                playerName = nameList.getListNameCathar(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgCath.BorderStyle == style3D && CBoxFemale.Checked)
            {
                string playerName;
                playerName = nameList.getListNameCathar(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgHum.BorderStyle == style3D && CBoxMale.Checked)
            {
                string playerName;
                gender = "M";
                playerName = nameList.getListNameHum(gender);
                TxtBoxNameGen.Text = playerName;
            }
            else if (RPnlImgHum.BorderStyle == style3D && CBoxFemale.Checked)
            {
                string playerName;
                playerName = nameList.getListNameHum(gender);
                TxtBoxNameGen.Text = playerName;
            }
        }

        /// <summary>
        /// This click event method generates a name in the form's TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenName_Click(object sender, EventArgs e)
        {
            GenderCheckName();
        }
    }

 }
