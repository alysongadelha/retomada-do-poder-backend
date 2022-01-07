namespace PoderAPI.Model.InputModels
{
    public class CharVampireInputModel
    {
        public string Name { get; set; }

        public string Player { get; set; }

        public string Resume { get; set; }

        public string ImgLink { get; set; }

        public string SymbolLink { get; set; }

        public string Clan { get; private set; }

        public int? Generation { get; private set; }

        public int Filiation { get; private set; }

        public bool? Dead { get; set; }

    }
}
