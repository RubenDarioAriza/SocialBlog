using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entidad
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        [BsonIgnoreIfNull]
        public byte[] Image { get; set; }
    }
}
