using AhmedTest.Data;
using AhmedTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AhmedTest.Controllers
{
    public class ItemsController : Controller
    {
        public ItemsController(AppDbContext db)
        {
            _db=db;
        }
        private readonly AppDbContext _db;
        public IActionResult Index()
        {
           IEnumerable<Item> itemsList=_db.Items.ToList();
            return View(itemsList);
        }

        
    }
}
