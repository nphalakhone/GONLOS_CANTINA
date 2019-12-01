﻿using System;
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
            List<Player> playersSaved = new List<Player>();
            string line = "";

            if (!File.Exists(Application.StartupPath + "\\SavesTest.txt"))
            {
                MessageBox.Show("There is no SavesTest file in your computer", "ATTENTION");
                this.Hide();
                StartForm start = new StartForm();
                start.ShowDialog();
                this.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\SavesTest.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    string[] new_player = line.Split(';');
                    Player player = new Player();
                    player.Name = new_player[0];
                    player.Gender = new_player[1];
                    player.Species = new_player[2];
                    player.Credits = Int32.Parse(new_player[3]);
                    player.PazaakGamesWon = Int32.Parse(new_player[4]);
                    player.PazaakGamesLost = Int32.Parse(new_player[5]);
                    player.DejarikGamesWon = Int32.Parse(new_player[6]);
                    player.DejarikGamesLost = Int32.Parse(new_player[7]);
                    playersSaved.Add(player);
                }
                sr.Close();
            }

            foreach (Player p in playersSaved)
            {
                if (TBoxName.Text == p.Name)
                {
                    playerSelected.Name = p.Name;
                    playerSelected.Gender = p.Gender;
                    playerSelected.Species = p.Species;
                    playerSelected.Credits = p.Credits;
                    playerSelected.PazaakGamesWon = p.PazaakGamesWon;
                    playerSelected.PazaakGamesLost = p.PazaakGamesLost;
                    playerSelected.DejarikGamesWon = p.DejarikGamesWon;
                    playerSelected.DejarikGamesLost = p.DejarikGamesLost;
                    this.Hide();
                    MenuAccueil menu = new MenuAccueil();
                    menu.Player1 = playerSelected;
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The name: " + TBoxName.Text + " does not appear on our guest file", "ATTENTION");
                }
            }
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
