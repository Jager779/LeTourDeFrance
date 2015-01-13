namespace LeTourDeFrance.Backend.Models {
    public class Rider {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Team { get; set; }
    }

    public class TopRider : Rider {
        public int Position { get; set; }
    }
}