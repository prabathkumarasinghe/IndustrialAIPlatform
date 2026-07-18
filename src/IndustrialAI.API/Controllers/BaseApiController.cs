using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IndustrialAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    private ISender? _sender;

    protected ISender Sender =>
        _sender ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}