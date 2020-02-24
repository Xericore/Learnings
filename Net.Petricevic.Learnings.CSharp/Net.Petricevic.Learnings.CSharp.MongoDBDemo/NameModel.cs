using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Net.Petricevic.Learnings.CSharp.MongoDBDemo
{
    public class NameModel
    {
        [BsonId] //_id
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}