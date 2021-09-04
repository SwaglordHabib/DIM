﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SH.DIM.DataAccess.Entities
{
    public abstract class CommodityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
    }
}