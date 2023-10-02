using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class SetorController : Controller
    {

        private readonly AppDbContext _context;
        public SetorController(AppDbContext context)
        {
            _context = context;
        }

        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Setor.ToListAsync();

            return View(dados);
        }




        [HttpPost]
        public async Task<IActionResult> Create(Setor setor)
        {
            if (ModelState.IsValid)
            {
                _context.Setor.Add(setor);
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

            var dados = _context.Setor.Find(id);

            if (dados == null)
                return NotFound();



            return View(dados);

        }


        public IActionResult Delete(int? id)
        {

            var dados = _context.Setor.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {

            var dados = _context.Setor.Find(id);

            if (dados == null)
                return NotFound();

            _context.Setor.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(int? id)
        {
            var dados = _context.Setor.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Setor setor)
        {
            _context.Setor.Update(setor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
