using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MovieRatingAPI.Controllers
{
    [Route("api/errors")]
    [ApiController]
    public class GlobalErrorsController : ControllerBase
    {
        [HttpGet]
        public IActionResult HandleErrors()
        {
            var exceptionBody = HttpContext.Features.Get<IExceptionHandlerFeature>();

            var responseStatus = exceptionBody.Error.GetType().Name switch
            {
                "NullReferenceException" => HttpStatusCode.BadRequest,
                _ => HttpStatusCode.ServiceUnavailable
            };

            return Problem(detail: exceptionBody.Error.Message, statusCode: (int)responseStatus);
        }
    }
}
