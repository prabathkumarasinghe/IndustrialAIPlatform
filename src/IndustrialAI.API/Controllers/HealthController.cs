using Microsoft.AspNetCore.Mvc;

namespace IndustrialAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Status = "Industrial AI API is running"
        });
    }
}