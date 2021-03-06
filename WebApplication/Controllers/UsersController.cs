using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : Controller
    {
        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get user by identifier", Description = "Return an user by it's identifier")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(UserModel))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponseHeader(StatusCodes.Status200OK,"X-Guid", "string","Guid of application")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }
    }
}