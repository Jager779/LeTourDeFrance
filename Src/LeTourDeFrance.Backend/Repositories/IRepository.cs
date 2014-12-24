using System.Collections.Generic;
using LeTourDeFrance.Backend.Models;

namespace LeTourDeFrance.Backend.Repositories {
    public interface IRepository {
        IEnumerable<Rider> GetAllRiders();
        IEnumerable<Stage> GetAllStages();
        Rider GetRider(int number);
        Stage GetStage(int stageNumber);
        void LoadRiders();
        void LoadStages();
    }
}