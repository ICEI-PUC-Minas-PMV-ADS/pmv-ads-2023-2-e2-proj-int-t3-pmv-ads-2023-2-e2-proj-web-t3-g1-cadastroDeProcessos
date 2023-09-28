using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class Tipo_ProcessoController : Controller
    {

        private readonly AppDbContext _context;
        public Tipo_ProcessoController(AppDbContext context)
        {
            _context = context; 
        }

        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Tipo_Processos.ToListAsync();

            return View(dados);
        }

    


        [HttpPost]
        public async Task<IActionResult> Create(Tipo_Processo tipoProcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Tipo_Processos.Add(tipoProcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


        public  IActionResult Details(int? id)
        {

            var dados =  _context.Tipo_Processos.Find(id);

            if (dados == null)      
                return NotFound();



            return View(dados);

        }


        public IActionResult Delete(int? id)
        {

            var dados = _context.Tipo_Processos.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed (int? id)
        {

            var dados = _context.Tipo_Processos.Find(id);

            if (dados == null)
                return NotFound();

            _context.Tipo_Processos.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(int? id)
        {
            var dados = _context.Tipo_Processos.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task <IActionResult> Edit(int id, Tipo_Processo tipo_processo)
        {
            _context.Tipo_Processos.Update(tipo_processo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
