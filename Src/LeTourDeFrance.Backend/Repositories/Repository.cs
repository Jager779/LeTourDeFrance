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
        private readonly List<Rider> _riders;
        private readonly List<Stage> _stages;

        public Repository() {
            _dbFolderName = ConfigurationManager.AppSettings["DbFolder"];
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
            Directory.GetFiles(_dbFolderName, "stages.json").Foreach(
                fileName => _stages.Add(JsonDecoder.DecodeStage(File.ReadAllText(fileName))));
        }

        public void LoadRiders() {
            if (!Directory.Exists(_dbFolderName)) throw new ArgumentException("Db folder doesn't exist");
            Directory.GetFiles(_dbFolderName, "riders.json").Foreach(
                fileName => _riders.Add(JsonDecoder.DecodeRider(File.ReadAllText(fileName))));
        }
    }
}