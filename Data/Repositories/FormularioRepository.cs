using FormularioTeste.Data.Interfaces;
using FormularioTeste.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioTeste.Data.Repositories
{
    public class FormularioRepository : IFormularioRepository
    {
        private readonly AppDbContext _appDbContext;

        public IEnumerable<Formulario> Formularios => _appDbContext.Formularios;

        public FormularioRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateFormulario(Formulario formulario)
        {
            _appDbContext.Formularios.Add(formulario);
            var dadosFormulario = new DadosFormulario()
            {
                FormularioId = formulario.FormularioId,
                NomeDoProprietario = formulario.NomeDoProprietario
            };
            _appDbContext.DadosFormularios.Add(dadosFormulario);
            _appDbContext.SaveChanges();
        }
    }
}
