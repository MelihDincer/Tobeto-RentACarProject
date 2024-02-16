using Business.Abstracts;
using Business.Requests.Brands;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public void AddAsync(CreateBrandRequest request)
        {
            _brandService.AddAsync(request);
        }
    }
}
