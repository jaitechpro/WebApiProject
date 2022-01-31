using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        [HttpPost("Create")]
        public IActionResult Register(Student a)
        {
            _context.Students.Add(a);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("Update")]
        public void Update(Student b)
        {
            _context.Students.Update(b);
            _context.SaveChanges();
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult<bool>> Delete(Student b)
        {
            _context.Students.Remove(b);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("GetData")]
        public async Task<List<Student>> GetData()
        {
            var data = await _context.Students.ToListAsync();
            return data;

        }

    }
}
