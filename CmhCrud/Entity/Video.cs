using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CmhCrud.Entity
{
    public class Video
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Url { get; set; }
    }
}
