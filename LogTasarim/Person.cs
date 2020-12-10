using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogTasarim
{
        public class Person
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string _id   { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }
            public object music_type { get; set; }
        }
}
