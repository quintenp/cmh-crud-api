using System.Collections.Generic;
using CmhCrud.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CmhCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService _videoService;

        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        // GET: api/Link
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _videoService.TestService(), "value2" };
        }

        // GET: api/Link/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Link
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
