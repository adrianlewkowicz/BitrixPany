using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.API.Data;
using Portfolio.API.Models;

namespace Portfolio.API.Controllers
{
    // http://localhost:5000
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly Database _context;

        public BlogController(Database context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValue()
        {
         var values =   await _context.Blogs.ToListAsync();
            return Ok(values);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Blogs.FirstOrDefaultAsync( x => x.Id == id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddValue([FromBody] Blog value )
        {
            _context.Blogs.Add(value);
            await _context.SaveChangesAsync();
            return Ok(value);
        }

        [HttpPut("id")]
        public async Task<IActionResult> EditValue(int id, [FromBody] Blog value)
        {
            var data = await _context.Blogs.FindAsync(id);
            
            data.Name = value.Name;
            data.Description = value.Description;
            data.AddDateTime = value.AddDateTime;

            await _context.SaveChangesAsync();
            return Ok(data);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delate(int id)
        {
            var data = await _context.Blogs.FindAsync(id);

            if(data == null)
                return NoContent();

            _context.Blogs.Remove(data);
            await _context.SaveChangesAsync();
            return Ok(data);
        }

    }
}