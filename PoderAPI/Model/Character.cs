using System;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "Character name is required.", AllowEmptyStrings = false)]
        [Display(Name = "Character name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Player name is required.", AllowEmptyStrings = true)]
        [Display(Name = "Player name")]
        public string Player { get; set; }

        [Required(ErrorMessage = "Character history resume.", AllowEmptyStrings = false)]
        [Display(Name = "Character resume")]
        [StringLength(100)]
        public string Resume { get; set; }

        public string ImgLink { get; set; }

        public string SymbolLink { get; set; }

        public bool Dead { get; set; }

        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime Register { get; set; }

        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime? Death { get; set; }
    }
}
