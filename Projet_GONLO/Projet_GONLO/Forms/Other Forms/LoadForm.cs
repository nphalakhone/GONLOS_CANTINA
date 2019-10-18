using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public partial class LoadForm : Form
    {
        List<Player> listPlayer = new List<Player>();
        Player playerSelected = new Player();

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
            string nameEntered = TBoxName.Text;
            List<string> saveFile = File.ReadAllLines("C:\\Users\\1156103\\Documents\\GitHub\\GONLOS_CANTINA\\Projet_GONLO\\Saves\\Saves.txt").ToList();
            foreach (var line in saveFile)
            {
                string[] playerData = line.Split(',');
                Player newPlayer = new Player();
                newPlayer.Name = playerData[0];
                newPlayer.Species = playerData[1];
                newPlayer.Gender = playerData[2];
                newPlayer.Credits = int.Parse(playerData[3]);
                //newPlayer.PowMonster = playerData[4];
                //newPlayer.AttMonster = playerData[5];
                //newPlayer.DefMonster = playerData[6];
                //newPlayer.MovMonster = playerData[7];
                listPlayer.Add(newPlayer);
            }

            foreach (var player in listPlayer)
            {
                if (player.Name == nameEntered)
                {
                    playerSelected = player;
                }
            }
            this.Hide();
            //MenuAccueil menu = new MenuAccueil();
            MenuAccueil menu = new MenuAccueil();
            menu.ShowDialog();
            this.Close();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            BtnEllLoad.Enabled = false;
        }

        private void TBoxName_TextChanged(object sender, EventArgs e)
        {
            BtnEllLoad.Enabled = true;
        }

        
    }
}
