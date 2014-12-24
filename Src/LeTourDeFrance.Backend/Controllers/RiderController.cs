using System.Collections.Generic;
using System.Web.Http;
using LeTourDeFrance.Backend.Models;
using LeTourDeFrance.Backend.Repositories;

namespace LeTourDeFrance.Backend.Controllers {
    public class RiderController : ApiController {
        private readonly IRidersRepository _ridersRepository;

        public RiderController(IRidersRepository ridersRepository) {
            _ridersRepository = ridersRepository;
        }

        [HttpGet]
        public IEnumerable<Rider> GetAllRiders() {
            return _ridersRepository.GetAllRiders();
        }

        [HttpGet]
        public Rider GetRider(int number) {
            return _ridersRepository.GetRider(number);
        }
    }
}