using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{


    public class ProcessoController : Controller
    {

        private readonly AppDbContext _context;
        public ProcessoController(AppDbContext context)
        {
            _context = context;
        }

        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Processo.ToListAsync();

            return View(dados);
        }




        [HttpPost]
        public async Task<IActionResult> Create(Processo processo)
        {
            if (ModelState.IsValid)
            {
                _context.Processo.Add(processo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Create()
        {

            Funcoes f = new Funcoes(HttpContext);

            Processo p = new Processo();
            p.dataHora = DateTime.Now;            
            p.cpfProtocolista = f.LoginDaSessao();

            return View(p);
        }


        public IActionResult Details(int? id)
        {

            var dados = _context.Processo.Find(id);

            if (dados == null)
                return NotFound();



            return View(dados);

        }


        public IActionResult Delete(int? id)
        {

            var dados = _context.Processo.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {

            var dados = _context.Processo.Find(id);

            if (dados == null)
                return NotFound();

            _context.Processo.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(int? id)
        {
            var dados = _context.Processo.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Processo processo)
        {
            _context.Processo.Update(processo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
