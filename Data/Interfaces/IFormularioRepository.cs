using FormularioTeste.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioTeste.Data.Interfaces
{
    public interface IFormularioRepository
    {
        IEnumerable<Formulario> Formularios { get; }
        void CreateFormulario(Formulario formulario);
    }
}
