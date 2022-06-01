
using labs_rksp.Data.DTOs;
using labs_rksp.Data.Services;
using labs_rksp.Data.Models;
using Microsoft.AspNetCore.Mvc;
namespace labs_rksp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AddressController : ControllerBase
    {
        private readonly AddressService _context;

        public AddressController(AddressService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddress()
        {
            return await _context.GetAddresses();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(int id)
        {
            var address = await _context.GetAddress(id);
            if (address == null)
                return NotFound();

            return address;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Address>> PutAddress(int id, [FromBody] Address address)
        {
            var result = await _context.UpdateAddress(id, address);
            if (result == null)
                return BadRequest();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress([FromBody] AddressDTO address)
        {
            var result = await _context.AddAddress(address);
            if (result == null)
                BadRequest();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var department = await _context.DeleteAddresses(id);
            if (department)
                return Ok();

            return BadRequest();
        }
    }
}