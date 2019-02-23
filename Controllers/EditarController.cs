using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormularioTeste.Data;
using FormularioTeste.Data.Models;
using FormularioTeste.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormularioTeste.Controllers
{
    public class EditarController : Controller
    {
        private readonly AppDbContext _db;

        [BindProperty]
        public Formulario Formulario { get; set; }

        public EditarController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Edit(int id)
        {
            Formulario = await _db.Formularios.FindAsync(id);
            if (Formulario == null)
            {
                return RedirectToAction(actionName: "Edit", controllerName: "Editar");
            }
            return View(Formulario);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _db.Attach(Formulario).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new Exception($"Formulario {Formulario.FormularioId} não encontrado!", e);
            }

            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }
    }
}
