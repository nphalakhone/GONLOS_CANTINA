using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    public class Tile
    {
        private List<Tile> listAttack = new List<Tile>();
        private List<Tile> listMovement = new List<Tile>();
        private List<Tile> listDefense = new List<Tile>();

        //Liste de tous les bouttons qui sont sur le board
        private static List<Tile> listTiles = new List<Tile>();

        public static List<Tile> ListTiles { get => listTiles; }
        public List<Tile> ListAttack { get => listAttack; }
        public List<Tile> ListMovement { get => listMovement; }
        public List<Tile> ListDefense { get => listDefense; }

        public static void CreateTiles()
        {
            for (int i = 0; i < 24; i++)
            {
                listTiles.Add(new Tile(i));
            }
            CreateGraphTiles();
        }

        private static void CreateGraphTiles()
        {
            

            
        }

        private static void AssociateMovement(int myTile, params int[] tab)
        {
            foreach (int position in tab)
            {
                listTiles[myTile].listMovement.Add(listTiles[position]);
            }
        }

        /// <summary>
        /// Case Number
        /// </summary>
        public int Number
        {
            get;
            set;
        }

        /// <summary>
        /// Tile Constructor
        /// </summary>
        /// <param name="number"></param>
        public Tile(int number)
        {
            Number = number;
        }
    }
}
