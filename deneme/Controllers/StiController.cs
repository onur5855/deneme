using deneme.Data;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Controllers
{
    public class StiController : Controller
    {
        private readonly TestContext db;

        public StiController(TestContext testContext)
        {
            db = testContext;
        }
        public IActionResult Index()
        {
            db.Stis.OrderByDescending(a => a.Tarih);
            return View(db.Stis.ToList());
        }
    }
}
