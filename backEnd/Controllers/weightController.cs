using Microsoft.AspNetCore.Mvc;
using weight.Database;

namespace weight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeightController
    {
        private readonly WeightService _service;

        public Weight(WeightService weightService)
        {
            _service = weightService;
        }
        
        [HttpPost]
        public void SaveWeight(Weight weight)
        {
            _service.Create(weight);
        }

        [HttpDelete]
            public void DeleteWeight(Weight weight)
        {
            _service.Remove(weight);
        }
    }
}