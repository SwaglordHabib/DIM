using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SH.DIM.DataAccess.Entities
{
    public abstract class CommodityBase
    {
        [NotNull]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("Id")]
        public string? Id { get; set; }

        [NotNull]
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string? Name { get; set; }
    }
}