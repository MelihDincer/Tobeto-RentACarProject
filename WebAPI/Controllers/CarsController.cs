using Business.Abstracts;
using Business.Requests.Car;
using Business.Responses.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<List<GetAllCarResponse>> GetAllAsync()
        {
            return await _carService.GetAllAsync();
        }

        [HttpPost]
        public async Task<CreateCarResponse> AddAsync(CreateCarRequest request)
        {
            return await _carService.AddAsync(request);
        }
    }
}
