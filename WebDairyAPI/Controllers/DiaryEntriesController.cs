using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDairyAPI.Data;
using WebDairyAPI.Model;

namespace WebDairyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryEntriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DiaryEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<DiaryEntry> GetDiaryEntries()
        {
            return _context.DiaryEntries.ToList();
        }

    }
}
