using System;

namespace LeTourDeFrance.Backend.Models {
    public class Stage {
        public int StageNumber { get; set; }
        public string Course { get; set; }
        public DateTime Date { get; set; }
        public string Distance { get; set; }
        public string Types { get; set; }
    }
}