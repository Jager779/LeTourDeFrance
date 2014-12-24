using System;
using LeTourDeFrance.Backend.Models;
using Newtonsoft.Json.Linq;

namespace LeTourDeFrance.Backend.Helpers {
    internal class JsonDecoder {
        public static Rider DecodeRider(string json) {
            try {
                var o = JObject.Parse(json);

                return new Rider();
            }
            catch (Exception) {
                throw new ArgumentException("u är sämst");
            }
        }

        public static Stage DecodeStage(string json) {
            try {
                var o = JObject.Parse(json);
                return new Stage();
            }
            catch (Exception) {
                
                throw new ArgumentException("u är sämst");
            }
        }
    }
}