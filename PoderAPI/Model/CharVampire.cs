using System;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Clan { get; private set; }

        public int? Generation { get; private set; }

        [Required]
        [Range(1, 3)]
        public int Filiation { get; private set; }

        public void UpdatingCharVampire(string name, string resume, string player, string imgLink, string symbolLink, string clan, int filiation, int? generation, bool? dead = false)
        {
            Name = name;
            Resume = resume;
            Player = player;
            ImgLink = imgLink;
            SymbolLink = symbolLink;
            Clan = clan;
            Filiation = filiation;
            Generation = generation ?? null;
            Dead = dead ?? false;
            Death = Dead ? DateTime.Now : null;
        }
    }
}
