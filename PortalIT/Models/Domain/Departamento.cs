using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace PortalIT.Models.Domain
{
    public class Departamento
    {
      
        public int Id { get; set; }
        public string Nome { get; set; }
        public Curso Curso { get; set; }
    }
}
