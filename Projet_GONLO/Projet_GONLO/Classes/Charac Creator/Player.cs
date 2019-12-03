using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    /// <summary>
    /// Class Player
    /// </summary>
   public class Player
    {
        //Global variables
        private string _nom, _species, _gender;
        private int  _credits,_pazaakgameswon, _pazaakgameslost, _dejarikgameswon, _dejarikgameslost,
            points = 0, nbCards = 0, nbVictoire = 0, nbCarteUtiliseAi = 0;
        private Monster _powMonster, _attMonster,  _defMonster, _movMonster, currMonster;
        private List<Monster> _listMonsters = new List<Monster>();
        private bool stand = false;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Player()
        {
            
        }

        /// <summary>
        /// Getters and setters for each variable
        /// </summary>
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

        public Monster CurrMonster
        {
            get { return currMonster; }
            set { currMonster = value; }
        }

        public List<Monster> ListMonsters {
            get => _listMonsters;
            set => _listMonsters = value;
        }

        public int Points {
            get => points;
            set => points = value;
        }
        public int NbCards {
            get => nbCards;
            set => nbCards = value;
        }
        public bool Stand {
            get => stand;
            set => stand = value;
        }
        public int NbVictoire {
            get => nbVictoire;
            set => nbVictoire = value;
        }
        public int NbCarteUtiliseAi {
            get => nbCarteUtiliseAi;
            set => nbCarteUtiliseAi = value;
        }
    }
}
