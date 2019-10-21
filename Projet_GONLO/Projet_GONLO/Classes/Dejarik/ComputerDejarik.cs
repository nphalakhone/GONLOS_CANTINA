﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO.Classes.Dejarik
{
    class ComputerDejarik
    {
        private Monster _powMonster;
        private Monster _attMonster;
        private Monster _defMonster;
        private Monster _movMonster;

        public ComputerDejarik()
        {
        }

        public Monster PowMonster { get => _powMonster; set => _powMonster = value; }
        public Monster AttMonster { get => _attMonster; set => _attMonster = value; }
        public Monster DefMonster { get => _defMonster; set => _defMonster = value; }
        public Monster MovMonster { get => _movMonster; set => _movMonster = value; }
    }
}