using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndustrialAI.API.Controllers;

public class AuthController : BaseApiController
{
    [AllowAnonymous]
    [HttpPost("register")]
    public async Task<IActionResult> Register()
    {
        return Ok();
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login()
    {
        return Ok();
    }

    [Authorize]
    [HttpPost("refresh")]
    public async Task<IActionResult> RefreshToken()
    {
        return Ok();
    }

    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        return Ok();
    }
}