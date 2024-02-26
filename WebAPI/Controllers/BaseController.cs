using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult HandleDataResult<T>(IDataResult<T> dataResult)
        {
            return dataResult.Succes ? Ok(dataResult) : BadRequest(dataResult);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult HandleResult(Core.Utilities.Results.IResult result)
        {
            return result.Succes ? Ok(result) : BadRequest(result);
        }
    }
}
