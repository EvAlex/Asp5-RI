//using MongoDB.Bson;
//using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asp5RIWebsite.Storage
{
    public class MongoStorage : IStorage
    {
        public MongoStorage()
        {
            //var client = new MongoClient("mongodb://localhost:27017");
            //var database = client.GetDatabase("foo");
            //var collection = database.GetCollection<BsonDocument>("bar");
        }

        public Company[] GetCompanies()
        {
            throw new NotImplementedException();
        }
    }
}
