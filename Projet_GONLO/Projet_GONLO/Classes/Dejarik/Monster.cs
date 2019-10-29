using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GONLO
{
    public enum typeMonster { Power, Offensive, Defensive, Mobile };

    class Monster
    {


        // Instance Variables 
        string name;
        int attack;
        int defense;
        int movement;
        //int position;
        Image picture;
        typeMonster type;


        // Constructor Declaration of Class 
        public Monster(string name, int attack,
                      int defense, int movement, Image picture, typeMonster type) //, int position)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.movement = movement;
            this.picture = picture;
            this.type = type;
        }

        public string Name { get => name; set => name = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
        public int Movement { get => movement; set => movement = value; }
        public Image Picture { get => picture; set => picture = value; }
        public typeMonster Type { get => type; set => type = value; }
        //public int Position { get => position; set => position = value; }
    }
}
