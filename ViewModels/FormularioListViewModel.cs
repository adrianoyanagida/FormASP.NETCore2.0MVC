using FormularioTeste.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioTeste.ViewModels
{
    public class FormularioListViewModel
    {
        public IEnumerable<Formulario> Formularios { get; set; }
    }
}
