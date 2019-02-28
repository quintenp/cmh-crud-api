using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CmhCrud.Context;
using CmhCrud.Entity;
using MongoDB.Driver;

namespace CmhCrud.Repository
{
    public class VideoRepository : IVideoRepository
    {
        private readonly IVideoContext _videoContext;

        public VideoRepository(IVideoContext context)
        {
            _videoContext = context;
        }

        public async Task Create(Video game)
        {
            await _videoContext.Videos.InsertOneAsync(game);
        }

        public async Task<IEnumerable<Video>> GetAllVideos()
        {
            return await _videoContext
                .Videos
                .Find(_ => true)
                .ToListAsync();
        }
    }
}
