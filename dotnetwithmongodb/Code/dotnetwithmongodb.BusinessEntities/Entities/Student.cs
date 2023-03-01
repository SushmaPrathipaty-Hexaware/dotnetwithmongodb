using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnetwithmongodb.BusinessEntities.Entities
{
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id  { get; set; }
        public string studentname  { get; set; }
        
    }

}
