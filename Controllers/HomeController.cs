using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormularioTeste.Data;
using FormularioTeste.Data.Interfaces;
using FormularioTeste.Data.Models;
using FormularioTeste.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormularioTeste.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IFormularioRepository _formularioRepository;

        public HomeController(IFormularioRepository formularioRepository, AppDbContext db)
        {
            _db = db;
            _formularioRepository = formularioRepository;
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            IEnumerable<Formulario> formularios;

            formularios = _formularioRepository.Formularios.OrderBy(n => n.FormularioId);

            var formularioListViewModel = new FormularioListViewModel
            {
                Formularios = formularios
            };

            return View(formularioListViewModel);
        }

        //Método pra excluir
        public async Task<IActionResult> Delete(int id)
        {
            var formulario = await _db.Formularios.FindAsync(id);
            if(formulario != null)
            {
                _db.Formularios.Remove(formulario);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(actionName: "Index");
        }
    }
}
