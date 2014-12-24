using System.Collections.Generic;
using System.Web.Http;
using LeTourDeFrance.Backend.Models;
using LeTourDeFrance.Backend.Repositories;

namespace LeTourDeFrance.Backend.Controllers {
    public class IndexController : ApiController {
         private readonly IRepository _repository;

        public IndexController(IRepository repository) {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Rider> GetAllRiders() {
            return _repository.GetAllRiders();
        }

        [HttpGet]
        public Rider GetRider(int number) {
            return _repository.GetRider(number);
        }
    }
}