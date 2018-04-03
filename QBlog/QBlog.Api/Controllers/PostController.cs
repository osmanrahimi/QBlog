using Microsoft.AspNetCore.Mvc;
using QBlog.DataAccess.Services;
using System.Threading.Tasks;

namespace QBlog.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Post")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("[action]/{page}")]
        public async  Task<IActionResult> Get(int page=0)
        {
            if (page > 0)
                page--;
            var data =await _postService.Get(page);   
            return Ok(data);
        }

        [HttpGet("Get/{id}/post")]
        public async Task<IActionResult> GetItem(int id)
        {
            var result = _postService.GetItem(id);
            return Ok(result);
        }

    }
}