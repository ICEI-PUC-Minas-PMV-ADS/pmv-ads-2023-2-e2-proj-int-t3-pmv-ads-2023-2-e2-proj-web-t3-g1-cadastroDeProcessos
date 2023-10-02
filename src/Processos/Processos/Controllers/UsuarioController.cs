using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly AppDbContext _context;
        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Usuario.ToListAsync();

            return View(dados);
        }




        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuario.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Details(String? id)
        {

            var dados = _context.Usuario.Find(id);

            if (dados == null)
                return NotFound();



            return View(dados);

        }


        public IActionResult Delete(String? id)
        {

            var dados = _context.Usuario.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(String? id)
        {

            var dados = _context.Usuario.Find(id);

            if (dados == null)
                return NotFound();

            _context.Usuario.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(String? id)
        {
            var dados = _context.Usuario.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(String id, Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
