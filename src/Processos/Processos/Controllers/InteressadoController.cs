using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class InteressadoController : Controller
    {

        private readonly AppDbContext _context;
        public InteressadoController(AppDbContext context)
        {
            _context = context;
        }

        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Interessado.ToListAsync();

            return View(dados);
        }




        [HttpPost]
        public async Task<IActionResult> Create(Interessado interessado)
        {
            if (ModelState.IsValid)
            {
                _context.Interessado.Add(interessado);
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

            var dados = _context.Interessado.Find(id);

            if (dados == null)
                return NotFound();



            return View(dados);

        }


        public IActionResult Delete(int? id)
        {

            var dados = _context.Interessado.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {

            var dados = _context.Interessado.Find(id);

            if (dados == null)
                return NotFound();

            _context.Interessado.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(int? id)
        {
            var dados = _context.Interessado.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Interessado interessado)
        {
            _context.Interessado.Update(interessado);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
