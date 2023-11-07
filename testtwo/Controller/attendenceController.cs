using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testtwo.Db;

namespace testtwo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class attendenceController : ControllerBase
    {
        private readonly ApplicationDBContext _context;


        public attendenceController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllAttendence()
        {
            var allData = await _context.StudentAttendenuuuuces.ToListAsync();
            return Ok(allData);
        }

        [HttpGet]
        [Route("getById/{id}")]

        public async Task<IActionResult>GEtAttendenceBYId(int id)
        {
            var specficData = await _context.StudentAttendenuuuuces.FindAsync(id);
            if(specficData != null)
            {
                return Ok(specficData);
            }
            return NotFound();
        }





    }
}
