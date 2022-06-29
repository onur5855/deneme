using deneme.Data;
using deneme.Models;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Controllers
{
    public class StkController : Controller
    {
        private readonly TestContext db;

        public StkController(TestContext testContext)
        {
            db = testContext;
        }
        public IActionResult Index()
        {
            
            return View(db.Stks.ToList());
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Stk model)
        {
            db.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            //db.Stks.Where(a => a.Id == id);
            return View(db.Stks.FirstOrDefault(a=>a.Id==id));
        }
        [HttpPost]
        public IActionResult Delete(Stk model)
        {
            Stk stk = db.Stks.FirstOrDefault(a=>a.Id==model.Id);
            db.Remove(stk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(db.Stks.FirstOrDefault(a => a.Id == id));
        }
        [HttpPost]
        public IActionResult Edit(Stk model)
        {
            //mal kodu pk oldugu için hata fırlatıyor ya mal kodu değiştirmezsek hata fırlatmaz
            var yd = db.Stks.FirstOrDefault(a=>a.Id==model.Id);
            yd.Id = model.Id;
            yd.MalKodu = model.MalKodu;
            yd.MalAdi=model.MalAdi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
