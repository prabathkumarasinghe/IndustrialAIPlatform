using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndustrialAI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MachinesController : BaseApiController
    {

        // GET: api/machines
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        // GET: api/machines/{id}
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok();
        }

        // POST: api/machines
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }

        // PUT: api/machines/{id}
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id)
        {
            return Ok();
        }

        // DELETE: api/machines/{id}
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return NoContent();
        }

    }
}
