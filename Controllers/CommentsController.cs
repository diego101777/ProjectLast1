using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Site.Models;

namespace Site.Controllers
{
    public class CommentsController : Controller
    {
        private CommentsContext db;
        public CommentsController(CommentsContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Comments.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Comment comment)
        {
            db.Comments.Add(comment);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}