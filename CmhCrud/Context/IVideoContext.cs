using CmhCrud.Entity;
using MongoDB.Driver;

namespace CmhCrud.Context
{
    public interface IVideoContext
    {
        IMongoCollection<Video> Videos { get; }
    }
}
