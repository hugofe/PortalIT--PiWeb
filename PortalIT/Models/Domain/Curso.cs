using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PortalIT.Models.Domain
{
    public class Curso
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime TempoDeDuracao { get; set; }
    }
}
