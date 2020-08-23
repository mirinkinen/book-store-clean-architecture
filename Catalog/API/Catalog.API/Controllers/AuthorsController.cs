using Catalog.UseCases;
using Catalog.UseCases.AddAuthor;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IUseCaseExecutor _useCaseExecutor;

        public AuthorsController(IUseCaseExecutor useCaseExecutor)
        {
            _useCaseExecutor = useCaseExecutor;
        }

        [HttpPost]
        public IActionResult AddAuthor([FromBody] AddAuthorUseCaseData data)
        {
            _useCaseExecutor.Execute(data);

            return Ok();
        }
    }
}