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
        //Global variables
        StreamWriter sw = new StreamWriter(Application.StartupPath + "\\SavesTest.txt");
        Player playerSelected = new Player();
        List<Player> playersSaved = new List<Player>();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LoadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This click event method closes the Load form and opens the Start form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm start = new StartForm();
            start.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// This click event method closes the Load form and opens the Main form 
        /// if the save file and the user's player name are existing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllLoad_Click(object sender, EventArgs e)
        {
            string line = "";

            if (!File.Exists(Application.StartupPath + "\\SavesTest.txt"))
            {
                MessageBox.Show("There is no Save file in your computer, you must create a player and save it first.", "ATTENTION");
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
                    MainForm menu = new MainForm();
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

        /// <summary>
        /// This method sets the default form when it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadForm_Load(object sender, EventArgs e)
        {
            BtnEllLoad.Enabled = false;
        }

        /// <summary>
        /// This onkey event method enables the load button when the user writes down a name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TBoxName_TextChanged(object sender, EventArgs e)
        {
            BtnEllLoad.Enabled = true;
        }

        /// <summary>
        /// This click event method delete a save game that the user has written down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEllDelete_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < playersSaved.Count; i++)
            {
                if (TBoxName.Text == playersSaved.ElementAt(i).Name)
                {
                    temp = i;
                }
                else
                {
                    MessageBox.Show("The name: " + TBoxName.Text + " does not appear on our guest file", "ATTENTION");
                }
            }
            playersSaved.RemoveAt(temp);
            foreach (Player p in playersSaved)
            {
                sw.WriteLine(p.Name + ";" + p.Gender + ";" + p.Species + ";" + p.Credits.ToString() + ";" +
                            p.PazaakGamesWon.ToString() + ";" + p.PazaakGamesLost.ToString() + ";" + p.DejarikGamesWon.ToString() + ";"
                            + p.DejarikGamesLost.ToString());
            }

        }
    }
}
