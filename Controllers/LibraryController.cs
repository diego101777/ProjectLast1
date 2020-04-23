using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Site.Models;

namespace Site.Controllers
{
    public class LibraryController : Controller
    {
        private LibraryContext db;
        public LibraryController(LibraryContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Books.ToListAsync());
        }

        public IActionResult Information(int Id)
        {
            ViewBag.book = db.Books.Find(Id);
            return View();
        }
        [HttpGet]
        public IActionResult Order(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Order(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо, " + order.FIO + ", за заказ!";
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            db.Books.Add(book);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}