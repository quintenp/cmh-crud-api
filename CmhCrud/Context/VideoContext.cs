using CmhCrud.Entity;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CmhCrud.Context
{
    public class VideoContext : IVideoContext
    {
        private readonly IMongoDatabase _db;

        public VideoContext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Video> Videos => _db.GetCollection<Video>("Videos");
    }
}
