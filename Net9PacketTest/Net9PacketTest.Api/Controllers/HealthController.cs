using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Net9PacketTest.Api.Controllers;

[Route("health")]
public class HealthController : Controller
{
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Get()
    {
        return Ok(new { status = "Ok" });
    }
}
