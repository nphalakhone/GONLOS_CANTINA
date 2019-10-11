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
        private string _credits;
        private Monster _powMonster;
        private Monster _attMonster;
        private Monster _defMonster;
        private Monster _movMonster;
        private Cards _fstCard;
        private Cards _secCard;
        private Cards _trdCard;
        private Cards _fthCard;

        public Player()
        {

        }

        public string getNom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string getSpecies
        {
            get { return _species; }
            set { _species = value; }
        }

        public string getGender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string getCredits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        public Monster getPowMonster
        {
            get { return _powMonster; }
            set { _powMonster = value; }
        }

        public Monster getAttMonster
        {
            get { return _attMonster; }
            set { _attMonster = value; }
        }

        public Monster getDefMonster
        {
            get { return _defMonster; }
            set { _defMonster = value; }
        }

        public Monster getMovMonster
        {
            get { return _movMonster; }
            set { _movMonster = value; }
        }

        public Cards getFirstCard
        {
            get { return _fstCard; }
            set { _fstCard = value; }
        }
        public Cards getSecondCard
        {
            get { return _secCard; }
            set { _secCard = value; }
        }
        public Cards getThirdCard
        {
            get { return _trdCard; }
            set { _trdCard = value; }
        }
        public Cards getFourthCard
        {
            get { return _fthCard; }
            set { _fthCard = value; }
        }


    }
}
