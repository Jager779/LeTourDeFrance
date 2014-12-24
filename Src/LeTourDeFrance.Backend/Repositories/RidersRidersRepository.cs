using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using LeTourDeFrance.Backend.Helpers;
using LeTourDeFrance.Backend.Models;

namespace LeTourDeFrance.Backend.Repositories {
    public class RidersRidersRepository : IRidersRepository {
        private readonly string _dbFolderName;
        private readonly List<Rider> _riders;

        public RidersRidersRepository() {
            _dbFolderName = ConfigurationManager.AppSettings["DbFolder"];
            _riders = new List<Rider>();
            LoadRiders();
            LoadStages();
        }

        public IEnumerable<Rider> GetAllRiders() {
            return new List<Rider>();
        }

        public Rider GetRider(Guid id) {
            return new Rider();
        }

        public void LoadStages() {
            throw new NotImplementedException();
        }

        public void LoadRiders() {
            if (Directory.Exists(_dbFolderName)) return;
            Directory.CreateDirectory(_dbFolderName);
            Directory.GetFiles(_dbFolderName, "*.json").Foreach(
                fileName =>
                    _riders.Add(JsonDecoder.DecodeRider(File.ReadAllText(fileName))));
        }
    }
}