using System.Collections.Generic;
using System.Web.Http;
using LeTourDeFrance.Backend.Models;
using LeTourDeFrance.Backend.Repositories;

namespace LeTourDeFrance.Backend.Controllers {
    public class RidersController : ApiController {
        private readonly IRepository _repository;

        public RidersController(IRepository repository) {
            _repository = repository;
        }

        public IEnumerable<Rider> GetAllRiders() {
            return _repository.GetAllRiders();
        }

        public IHttpActionResult GetRider(int number) {
            var rider = _repository.GetRider(number);

            if (rider == null)
                return NotFound();

            return Ok(rider);
        }
    }
}