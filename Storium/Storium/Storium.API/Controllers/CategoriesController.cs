using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Storium.Application.Features.Categories.CreateCategory;
using Storium.Application.Features.Categories.GetAllCategory;

namespace Storium.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private IMediator _mediator;

        public CategoriesController(IMediator mediator)

        {
            _mediator=mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }


        [HttpPost]
 -      public async Task<IActionResult> GetAll(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
