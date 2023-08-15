using MongoDB.Bson;
using MongoDB.Driver;

namespace DATA
{
    public class PostData
    {
        static void Data()
        {
            string connectionString = "";

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("blogs");
            var collection = database.GetCollection<BsonDocument>("psot");

            var filter = Builders<BsonDocument>.Filter.Eq("title", "La nueva era tech");
            var findDocuments = collection.Find(filter).ToList();

            //var newDocument = BsonDocument { { "":""} };

            //collection.InsertOne(newDocument);
            

        }
       
    }
}
