using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using LeTourDeFrance.Backend.Helpers;
using LeTourDeFrance.Backend.Models;

namespace LeTourDeFrance.Backend.Repositories {
    public class Repository : IRepository {
        private readonly string _dbFolderName;
        private List<Rider> _riders;
        private List<Stage> _stages;

        public Repository() {
            _dbFolderName = AppDomain.CurrentDomain.BaseDirectory + "Db";
            _riders = new List<Rider>();
            _stages = new List<Stage>();
            LoadRiders();
            LoadStages();
        }

        public IEnumerable<Rider> GetAllRiders() {
            return _riders.OrderBy(x => x.Name);
        }

        public IEnumerable<Stage> GetAllStages() {
            return _stages.OrderBy(x => x.StageNumber);
        }

        public Rider GetRider(int number) {
            return _riders.FirstOrDefault(x => x.Number == number);
        }

        public Stage GetStage(int stageNumber) {
            return _stages.FirstOrDefault(x => x.StageNumber == stageNumber);
        }

        public void LoadStages() {
            if (!Directory.Exists(_dbFolderName)) throw new ArgumentException("Db folder doesn't exist");
            var file = Directory.GetFiles(_dbFolderName, "stages.json").FirstOrDefault();
            _stages = JsonDecoder.DecodeStage(File.ReadAllText(file));
        }

        public void LoadRiders() {
            if (!Directory.Exists(_dbFolderName)) throw new ArgumentException("Db folder doesn't exist");
            var file = Directory.GetFiles(_dbFolderName, "riders.json").FirstOrDefault();
            _riders = JsonDecoder.DecodeRiders(File.ReadAllText(file));
        }
    }
}