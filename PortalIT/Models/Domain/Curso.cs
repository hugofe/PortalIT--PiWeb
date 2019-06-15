
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalIT.Models.Domain
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        
        [DataType(DataType.Time)]
        public DateTime? TempoDeDuracao { get; set; }

        [Required]
        public List<Departamento> Departamento { get; set; }
    }
}
