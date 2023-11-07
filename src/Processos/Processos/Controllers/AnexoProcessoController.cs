using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Processos.Models;

namespace Processos.Controllers
{
    public class AnexoProcessoController : Controller
    {

        private readonly AppDbContext _context;
        private string codigoProcesso;

        public AnexoProcessoController(AppDbContext context)
        {
            _context = context;
        }

        // Lista
        public async Task<IActionResult> Index()
        {
            var dados = await _context.AnexoProcesso.ToListAsync();

            return View(dados);
        }




        [HttpPost]
        public async Task<IActionResult> Create(AnexoProcesso ap, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                _context.AnexoProcesso.Add(ap);
                await _context.SaveChangesAsync();

                if (file.Length > 0)
                {
                    
                    String uploadPath = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: false).Build().GetValue<string>("AppSettings:uploadPath");
                                        
                    string filePath = Path.Combine(uploadPath, ap.codigoAnexo.ToString());
                                        
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        // Copy the uploaded file to the stream.
                        await file.CopyToAsync(fileStream);
                    }

                }


                return Redirect("/Processo/Edit/" + ap.codigoProcesso);
            }

            return Redirect("/Processo/Edit/" + ap.codigoProcesso);
        }


        public IActionResult Create([FromQuery] int codProcesso)
        {
            AnexoProcesso a = new AnexoProcesso();
            a.codigoProcesso = codProcesso;
            a.dataHora = DateTime.Now;
            return View(a);
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

            var dados = _context.AnexoProcesso.Find(id);

            if (dados == null)
                return NotFound();

            _context.AnexoProcesso.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }



        public IActionResult Edit(int? id)
        {
            var dados = _context.AnexoProcesso.Find(id);

            if (dados == null)
                return NotFound();


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AnexoProcesso anexoprocesso)
        {
            _context.AnexoProcesso.Update(anexoprocesso);
            _context.SaveChanges();

            return Redirect("/Processo/Edit/" + anexoprocesso.codigoProcesso);

        }


    }
}
