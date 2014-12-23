using System;
using System.Collections.Generic;
using LeTourDeFrance.Backend.Models;

namespace LeTourDeFrance.Backend.Repositories {
    public class RidersRidersRepository : IRidersRepository {
        public IEnumerable<Rider> GetAllRiders() {
            return new List<Rider>();
        }

        public Rider GetRider(Guid id) {
            return new Rider();
        }
    }
}