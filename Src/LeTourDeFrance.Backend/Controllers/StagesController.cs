using System.Collections.Generic;
using System.Web.Http;
using LeTourDeFrance.Backend.Models;
using LeTourDeFrance.Backend.Repositories;

namespace LeTourDeFrance.Backend.Controllers {
    public class StagesController : ApiController {
        private readonly IRepository _repository;

        public StagesController(IRepository repository) {
            _repository = repository;
        }

        public IEnumerable<Stage> GetAllStages() {
            return _repository.GetAllStages();
        }

        public IHttpActionResult GetStage(int number) {
            var stage = _repository.GetStage(number);
            if (stage == null)
                return NotFound();

            return Ok(stage);
        }
    }
}