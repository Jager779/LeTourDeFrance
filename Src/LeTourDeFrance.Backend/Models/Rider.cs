using System;

namespace LeTourDeFrance.Backend.Models {
    public class Rider {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Team { get; set; }
    }
}