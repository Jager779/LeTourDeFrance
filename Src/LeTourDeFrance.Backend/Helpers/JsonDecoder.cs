using System;
using LeTourDeFrance.Backend.Models;
using Newtonsoft.Json.Linq;

namespace LeTourDeFrance.Backend.Helpers {
    internal class JsonDecoder {
        public static Rider DecodeRider(string json) {
            try {
                var o = JObject.Parse(json);

                return new Rider {
                    Name = o["Course"].ToString(),
                    Nationality = o["Nationality"].ToString(),
                    Number = Convert.ToInt32(o["No."].ToString()),
                    Team = o["Team"].ToString()
                };
            }
            catch (Exception) {
                throw new ArgumentException("Invalid json");
            }
        }

        public static Stage DecodeStage(string json) {
            try {
                var o = JObject.Parse(json);
                return new Stage {
                    Course = o["Course"].ToString(),
                    StageNumber = Convert.ToInt32(o["Stage"].ToString()),
                    Date = Convert.ToDateTime(o["Date"].ToString()),
                    Distance = o["Distance"].ToString(),
                    Types = o["Types"].ToString()
                };
            }
            catch (Exception) {
                throw new ArgumentException("Invalid json");
            }
        }
    }
}