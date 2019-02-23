using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioTeste.Data.Models
{
    public class Formulario
    {
        [Key]
        public int FormularioId { get; set; }

        [Required]
        public string NomeDoAnimal { get; set; }
        [Required]
        public string RacaDoAnimal { get; set; }
        [Required]
        public string NomeDoProprietario { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
