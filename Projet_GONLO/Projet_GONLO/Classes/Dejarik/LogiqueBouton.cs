using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    public class LogiqueBouton
    {
        private List<LogiqueBouton> listBouttonAttaque = new List<LogiqueBouton>();
        private List<LogiqueBouton> listBouttonDeplacement = new List<LogiqueBouton>();
        private List<LogiqueBouton> listBouttonAdjacent = new List<LogiqueBouton>();

        //Liste de tous les bouttons qui sont sur le board
        private static List<LogiqueBouton> listBouttons = new List<LogiqueBouton>();

        public static List<LogiqueBouton> ListBouttons
        {
            get
            {
                return listBouttons;
            }
        }
    }
}
