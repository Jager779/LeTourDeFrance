using System;
using System.Collections.Generic;
using System.Linq;
using LeTourDeFrance.Backend.Models;
using LeTourDeFrance.Backend.Repositories;
using Moq;

namespace LeTourDeFrance.Backend.Tests.Mocks {
    public static class RepositoryMock {
        private static List<Rider> _riders;
        private static List<Stage> _stages;

        private static List<Stage> MockStages() {
            return new List<Stage> {
                new Stage {
                    StageNumber = 2,
                    Date = Convert.ToDateTime("6 July 2014"),
                    Course = "York – Sheffield (United Kingdom)",
                    Distance = "201 km (125 mi)",
                    Types = "Medium-mountain stage"
                },
                new Stage {
                    StageNumber = 6,
                    Date = Convert.ToDateTime("10 July 2014"),
                    Course = "Arras – Reims",
                    Distance = "194 km (121 mi)",
                    Types = "Flat stage"
                }
            };
        }

        private static List<Rider> MockRiders() {
            return new List<Rider> {
                new Rider {
                    Number = 1,
                    Name = "Chris Froome",
                    Nationality = "Great Britain",
                    Team = "Team Sky"
                },
                new Rider {
                    Number = 5,
                    Name = "Mikel Nieve",
                    Nationality = "Spain",
                    Team = "Team Sky"
                }
            };
        }

        public static IRepository SetupMock() {
            var mockRepo = new Mock<IRepository>();
            _riders = MockRiders();
            _stages = MockStages();

            mockRepo.Setup(r => r.GetAllRiders()).Returns(_riders);
            mockRepo.Setup(r => r.GetAllStages()).Returns(_stages);

            mockRepo.Setup(r => r.GetRider(It.IsAny<int>()))
                .Returns((int i) => _riders.FirstOrDefault(x => x.Number == i));
            mockRepo.Setup(r => r.GetStage(It.IsAny<int>()))
                .Returns((int i) => _stages.FirstOrDefault(x => x.StageNumber == i));

            return mockRepo.Object;
        }
    }
}