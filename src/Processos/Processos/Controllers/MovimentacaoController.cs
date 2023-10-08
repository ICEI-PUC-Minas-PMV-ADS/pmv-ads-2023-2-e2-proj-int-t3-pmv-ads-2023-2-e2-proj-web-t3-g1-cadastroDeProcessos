using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class MovimentacaoController : Controller
    {

        private readonly AppDbContext _context;
        private string codigoProcesso;

        public MovimentacaoController(AppDbContext context)
        {
            _context = context;
        }

        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Movimentacao.ToListAsync();

            return View(dados);
        }




        [HttpPost]
        public async Task<IActionResult> Create(Movimentacao movimentacao)
        {
            if (ModelState.IsValid)
            {
                _context.Movimentacao.Add(movimentacao);
                await _context.SaveChangesAsync();
                return Redirect("/Processo/Edit/" + movimentacao.codigoProcesso);
            }

            return Redirect("/Processo/Edit/" + movimentacao.codigoProcesso);
        }


        public IActionResult Create([FromQuery] int codProcesso)
        {
            Movimentacao m = new Movimentacao();
            m.codigoProcesso = codProcesso;
            m.dataHora = DateTime.Now;
            m.cpfUsuarioTramite = "04689352666";
            m.codigoSetorLocalizacao = 1;
            return View(m);
        }


        public IActionResult Delete(int? id)
        {

            var dados = _context.Movimentacao.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {

            var dados = _context.Movimentacao.Find(id);

            if (dados == null)
                return NotFound();

            _context.Movimentacao.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(int? id)
        {
            var dados = _context.Movimentacao.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Movimentacao movimentacao)
        {
            _context.Movimentacao.Update(movimentacao);
            _context.SaveChanges();
           
            return Redirect("/Processo/Edit/" + movimentacao.codigoProcesso);

        }


    }
}
