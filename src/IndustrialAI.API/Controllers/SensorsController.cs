
using Microsoft.AspNetCore.Mvc;

namespace IndustrialAI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorsController : BaseApiController
    {

    //    // GET: api/sensors
    //    [HttpGet]
    //    public async Task<IActionResult> GetAll()
    //    {
    //        var result = await Sender.Send(new GetAllSensorsQuery());
    //        return Ok(result);
    //    }

    //    // GET: api/sensors/{id}
    //    [HttpGet("{id:guid}")]
    //    public async Task<IActionResult> GetById(Guid id)
    //    {
    //        var result = await Sender.Send(new GetSensorByIdQuery(id));
    //        return Ok(result);
    //    }

    //    // POST: api/sensors
    //    [HttpPost]
    //    public async Task<IActionResult> Create(CreateSensorCommand command)
    //    {
    //        var result = await Sender.Send(command);

    //        return CreatedAtAction(
    //            nameof(GetById),
    //            new { id = result.Id },
    //            result);
    //    }

    //    // POST: api/sensors/upload
    //    [HttpPost("upload")]
    //    public async Task<IActionResult> Upload(UploadSensorDataCommand command)
    //    {
    //        var result = await Sender.Send(command);
    //        return Ok(result);
    //    }

    }
}
