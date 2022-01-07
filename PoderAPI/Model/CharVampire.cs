using System;

namespace PoderAPI.Model
{
    public class CharVampire : Character
    {
        public CharVampire(string clan,
                           int? generation,
                           int filiation,
                           string name,
                           string player,
                           string resume,
                           string imgLink,
                           string symbolLink) : base(name, player, resume, imgLink, symbolLink)
        {
            Clan = clan;
            Generation = generation;
            Filiation = filiation;
        }  

        public string Clan { get; private set; }

        public int? Generation { get; private set; }

        public int Filiation { get; private set; }
    }
}
