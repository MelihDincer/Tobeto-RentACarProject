using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult HandleDataResult<T>(IDataResult<T> dataResult)
        {
            return dataResult.Succes ? Ok(dataResult) : BadRequest(dataResult);
        }
    }
}
