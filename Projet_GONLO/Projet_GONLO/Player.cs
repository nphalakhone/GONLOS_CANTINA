using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    class Player
    {
        private String _nom;
        private String _species;
        private String _gender;

        public Player()
        {

        }

        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string species
        {
            get { return _species; }
            set { _species = value; }
        }

        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
