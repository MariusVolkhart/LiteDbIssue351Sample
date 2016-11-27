using System.IO;
using LiteDB;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var database = new LiteDatabase(new MemoryStream()))
            {
                var doc1 = new BsonDocument {["name"] = "john doe"};
                var people = database.GetCollection("people");
                people.Insert(doc1);
                people.FindOne(Query.EQ("name", "john doe"));
            }
        }
    }
}