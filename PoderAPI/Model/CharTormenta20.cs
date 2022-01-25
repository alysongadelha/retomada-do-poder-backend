using PoderAPI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoderAPI.Model
{
    public class CharTormenta20 : Character
    {
        public CharTormenta20(string name, string player, string resume, string imgLink, string symbolLink, int level, string origin) : base(name, player, resume, imgLink, symbolLink)
        {
            Level = level;
            Origin = origin;

        }

        public Enums.ClassTormenta20 Class { get; private set; }

        public int Level { get; private set; }

        public string Origin { get; private set; }
    }
}
