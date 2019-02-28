using System.Collections.Generic;
using System.Threading.Tasks;
using CmhCrud.Entity;
using CmhCrud.Interface;
using CmhCrud.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CmhCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoRepository _videoRepository;

        public VideoController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _videoRepository.GetAllVideos());
        }

        // GET: api/Link/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Link
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Video video)
        {
            await _videoRepository.Create(video);

            return new OkObjectResult(video);
        }

        // PUT: api/Link/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
