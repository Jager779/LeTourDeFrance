using System;
using System.Collections.Generic;
using LeTourDeFrance.Backend.Models;
using Newtonsoft.Json.Linq;

namespace LeTourDeFrance.Backend.Helpers {
    internal class JsonDecoder {
        public static List<Rider> DecodeRiders(string json) {
            List<Rider> riders;
            try {
                var jArray = JArray.Parse(json);
                riders = jArray.ToObject<List<Rider>>();
            }
            catch (Exception e) {
                throw new Exception(e.ToString());
            }
            return riders;
        }

        public static List<Stage> DecodeStage(string json) {
            List<Stage> stages;
            try {
                var jArray = JArray.Parse(json);
                stages = jArray.ToObject<List<Stage>>();
            }
            catch (Exception e) {
                throw new ArgumentException(e.ToString());
            }
            return stages;
        }
    }
}