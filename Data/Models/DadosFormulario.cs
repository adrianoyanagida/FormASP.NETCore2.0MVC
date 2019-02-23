using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioTeste.Data.Models
{
    public class DadosFormulario
    {
        [Key]
        public int DadosFormularioId { get; set; }

        [ForeignKey("Formulario")]
        public int FormularioId { get; set; }

        public string NomeDoProprietario { get; set; }
        public virtual Formulario Formulario { get; set; }
    }
}
