using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class FluxoController : Controller
    {

        private readonly AppDbContext _context;
        public FluxoController(AppDbContext context)
        {
            _context = context;
        }


        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Fluxo.ToListAsync();

            return View(dados);
        }




        [HttpPost]
        public async Task<IActionResult> Create(Fluxo fluxo)
        {
            if (ModelState.IsValid)
            {
                _context.Fluxo.Add(fluxo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Details(int? id)
        {

            var dados = _context.Fluxo.Find(id);

            if (dados == null)
                return NotFound();



            return View(dados);

        }


        public IActionResult Delete(int? id)
        {

            var dados = _context.Fluxo.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {

            var dados = _context.Fluxo.Find(id);

            if (dados == null)
                return NotFound();

            _context.Fluxo.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(int? id)
        {
            var dados = _context.Fluxo.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Fluxo fluxo)
        {
            _context.Fluxo.Update(fluxo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
