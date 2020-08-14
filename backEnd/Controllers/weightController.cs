using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using weight.Database;

namespace weight.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class WeightController : Controller
    {
        private readonly WeightRepository _service;

        public WeightController(WeightRepository WeightRepository)
        {
            _service = WeightRepository;
        }

        [HttpPost]
        [Authorize]

        public void SaveWeight(Weight weight)
        {
            _service.Create(weight);
        }

        [HttpDelete]
        [Authorize]
        public void DeleteWeight(Weight weight)
        {
            _service.Remove(weight);
        }


        [HttpGet]
        [Authorize]
        public List<Weight> GetAllFromUser() => _service.GetFromUser(User.Identity.Name);

        [HttpGet]
        [Route("Last")]
        [Authorize]
        public async Task<Weight> GetLastWeightAsync() => await _service.GetLastWeightAsync(User.Identity.Name);


    }
}