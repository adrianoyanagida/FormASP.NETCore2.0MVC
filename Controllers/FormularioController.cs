using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormularioTeste.Data;
using FormularioTeste.Data.Interfaces;
using FormularioTeste.Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormularioTeste.Controllers
{
    public class FormularioController : Controller
    {
        private readonly IFormularioRepository _formularioRepository;

        public FormularioController(IFormularioRepository formularioRepository)
        {
            _formularioRepository = formularioRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Formulario formulario)
        {
            if (ModelState.IsValid)
            {
                _formularioRepository.CreateFormulario(formulario);
                return RedirectToAction (actionName: "Index", controllerName: "Home");
            }
            //Passa uma view com um Model
            return View(formulario);
        }
    }
}
