using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;

namespace WebAPI6AM.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<Category>GetCategory()
        {
          return  _db.Categories.ToList();
        }
    }
}
