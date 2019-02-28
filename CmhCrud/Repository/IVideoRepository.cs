using System.Collections.Generic;
using System.Threading.Tasks;
using CmhCrud.Entity;

namespace CmhCrud.Repository
{
    public interface IVideoRepository
    {
        Task Create(Video video);
        Task<IEnumerable<Video>> GetAllVideos();
    }
}
