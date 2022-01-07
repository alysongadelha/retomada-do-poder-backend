using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoderAPI.Model
{
    public abstract class Character
    {
        protected Character(string name, string player, string resume, string imgLink, string symbolLink)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Player = player;
            Resume = resume;
            ImgLink = imgLink;
            SymbolLink = symbolLink;
            Register = DateTime.Now;
            Dead = false;
            Death = null;
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Usuário é obrigatório")]
        public string Name { get; set; }

        public string Player { get; set; }

        public string Resume { get; set; }

        public string ImgLink { get; set; }

        public string SymbolLink { get; set; }

        public bool Dead { get; set; }

        public DateTime Register { get; set; }

        public DateTime? Death { get; set; }

        public void UpdateCharacter(string name, string resume, string player, string imgLink, string symbolLink, bool? dead = false)
        {
            Name = name;
            Resume = resume;
            Player = player;
            ImgLink = imgLink;
            SymbolLink = symbolLink;
            Dead = dead ?? false;   
            Death = Dead ? DateTime.Now : null;
        }
    }
}
