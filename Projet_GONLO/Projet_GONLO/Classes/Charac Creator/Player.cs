using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    class Player
    {
        private string _nom;
        private string _species;
        private string _gender;
        private int _credits;
        private int _pazaakgameswon;
        private int _pazaakgameslost;
        private int _dejarikgameswon;
        private int _dejarikgameslost;
        private Monster _powMonster;
        private Monster _attMonster;
        private Monster _defMonster;
        private Monster _movMonster;
       

        public Player()
        {
            
        }

        public string Name
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        public int PazaakGamesWon
        {
            get { return _pazaakgameswon; }
            set { _pazaakgameswon = value; }
        }

        public int PazaakGamesLost
        {
            get { return _pazaakgameslost; }
            set { _pazaakgameslost = value; }
        }

        public int DejarikGamesWon
        {
            get { return _dejarikgameswon; }
            set { _dejarikgameswon = value; }
        }

        public int DejarikGamesLost
        {
            get { return _dejarikgameslost; }
            set { _dejarikgameslost = value; }
        }

        public Monster PowMonster
        {
            get { return _powMonster; }
            set { _powMonster = value; }
        }

        public Monster AttMonster
        {
            get { return _attMonster; }
            set { _attMonster = value; }
        }

        public Monster DefMonster
        {
            get { return _defMonster; }
            set { _defMonster = value; }
        }

        public Monster MovMonster
        {
            get { return _movMonster; }
            set { _movMonster = value; }
        }

        
    }
}
