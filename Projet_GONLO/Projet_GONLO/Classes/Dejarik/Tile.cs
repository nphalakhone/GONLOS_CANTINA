using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    public class Tile
    {
        private List<Tile> listBouttonAttaque = new List<Tile>();
        private List<Tile> listBouttonDeplacement = new List<Tile>();
        private List<Tile> listBouttonAdjacent = new List<Tile>();

        //Liste de tous les bouttons qui sont sur le board
        private static List<Tile> listBouttons = new List<Tile>();

        public static List<Tile> ListBouttons
        {
            get
            {
                return listBouttons;
            }
        }
    }
}
