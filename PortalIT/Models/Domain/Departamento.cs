using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace PortalIT.Models.Domain
{
    public class Departamento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public string Nome { get; set; }

        List<Curso> Curso;
    }
}
