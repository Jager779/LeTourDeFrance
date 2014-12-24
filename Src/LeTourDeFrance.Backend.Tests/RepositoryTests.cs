using System.Linq;
using LeTourDeFrance.Backend.Repositories;
using LeTourDeFrance.Backend.Tests.Mocks;
using NUnit.Framework;

namespace LeTourDeFrance.Backend.Tests {
    [TestFixture]
    public class RepositoryTests {
        private IRepository _repositoryMock;


        [TestFixtureSetUp]
        public void SetUp() {
            _repositoryMock = RepositoryMock.SetupMock();
        }

        [TestFixtureTearDown]
        public void TearDown() {
            _repositoryMock = null;
        }

        [Test]
        public void GetAllRidersTest() {
            var riders = _repositoryMock.GetAllRiders();
            Assert.IsTrue(riders.Count() > 1);
        }

        [Test]
        public void GetAllStagesTest() {
            var stages = _repositoryMock.GetAllStages();
            Assert.IsTrue(stages.Count() > 1);
        }

        [Test]
        public void GetRiderNullTest() {
            var rider = _repositoryMock.GetRider(2);
            Assert.IsNull(rider);
        }

        [Test]
        public void GetRiderTest() {
            var rider = _repositoryMock.GetRider(1);
            Assert.IsTrue(rider.Number == 1);
        }

        [Test]
        public void GetStageNullTest() {
            var stage = _repositoryMock.GetStage(1000);
            Assert.IsNull(stage);
        }

        [Test]
        public void GetStageTest() {
            var stage = _repositoryMock.GetStage(2);
            Assert.IsNotNull(stage.Distance);
        }
    }
}