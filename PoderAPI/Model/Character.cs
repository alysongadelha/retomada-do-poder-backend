using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoderAPI.Model
{
    public class Character
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

        protected string Id { get; set; }

        [Required(ErrorMessage = "Usuário é obrigatório")]
        protected string Name { get; set; }

        protected string Player { get; set; }

        protected string Resume { get; set; }

        protected string ImgLink { get; set; }

        protected string SymbolLink { get; set; }

        protected bool Dead { get; set; }

        protected DateTime Register { get; set; }

        protected DateTime? Death { get; set; }
    }
}
