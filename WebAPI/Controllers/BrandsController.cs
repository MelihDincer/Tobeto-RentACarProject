using Business.Abstracts;
using Business.Requests.Brands;
using Business.Responses.Brands;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CreateBrandRequest request)
        {
            return HandleDataResult(await _brandService.AddAsync(request));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return HandleDataResult(await _brandService.GetAllAsync());
        }

        [HttpGet("{name}")]
        public async Task<List<GetAllBrandResponse>> GetAllBrandName([FromRoute] string name)
        {
            return await _brandService.GetAllBrandName(name);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteBrandRequest deleteBrandRequest)
        {
            return HandleResult(await _brandService.DeleteAsync(deleteBrandRequest));
        }
    }
}
