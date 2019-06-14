using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace PortalIT.Models.Domain
{
    public class Aluno
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }

        List<Curso> Curso = new List<Curso>();
    }
}
