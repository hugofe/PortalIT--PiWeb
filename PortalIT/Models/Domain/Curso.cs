
using System;
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

        [Required]
        [DataType(DataType.Duration)]
        public DateTime? TempoDeDuracao { get; set; }

        [Required]
        public Departamento Departamento { get; set; }
    }
}
