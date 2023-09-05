using Application.Features.Tenants.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateTenantCommand createTenantCommand)
        {
            CreatedTenantResponse response = await Mediator.Send(createTenantCommand);
            return Ok(response);
        }
    }
}
