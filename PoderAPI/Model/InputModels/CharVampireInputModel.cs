using System.ComponentModel.DataAnnotations;

namespace PoderAPI.Model.InputModels
{
    public class CharVampireInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Player { get; set; }

        [Required]
        [StringLength(100)]
        public string Resume { get; set; }


        public string ImgLink { get; set; }

        public string SymbolLink { get; set; }

        [Required]
        public string Clan { get; set; }

        public int? Generation { get; set; }

        [Required]
        [Range(1, 3)]
        public int Filiation { get; set; }

        public bool? Dead { get; set; }

    }
}
