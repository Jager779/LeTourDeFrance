using System;
using System.Collections.Generic;

namespace LeTourDeFrance.Backend.Models {
    public class Stage {
        public int StageNumber { get; set; }
        public string Course { get; set; }
        public string Date { get; set; }
        public string Distance { get; set; }
        public string Types { get; set; }
        public List<TopRider> TopRiders { get; set; } 
    }
}