using System.Linq;
using System.Net.Http;
using System.Web.Http;
using LeTourDeFrance.Backend.Controllers;
using LeTourDeFrance.Backend.Repositories;
using LeTourDeFrance.Backend.Tests.Mocks;
using NUnit.Framework;

namespace LeTourDeFrance.Backend.Tests.Controllers {
    [TestFixture]
    public class RidersControllerTests {
        private IRepository _repository;

        [TestFixtureSetUp]
        public void SetUp() {
            _repository = RepositoryMock.SetupMock();
        }

        [TestFixtureTearDown]
        public void TearDown() {
            _repository = null;
        }

        [Test]
        public void GetAllRiders() {
            var controller = SetupRidersController();
            var riders = controller.GetAllRiders();
            Assert.IsTrue(riders.Count() > 1);
        }

        private RidersController SetupRidersController() {
            return new RidersController(_repository) {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
        }
    }
}