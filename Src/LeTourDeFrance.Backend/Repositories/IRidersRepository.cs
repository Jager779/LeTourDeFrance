using System;
using System.Collections.Generic;
using LeTourDeFrance.Backend.Models;

namespace LeTourDeFrance.Backend.Repositories {
    public interface IRidersRepository {
        IEnumerable<Rider> GetAllRiders();
        Rider GetRider(Guid id);
    }
}