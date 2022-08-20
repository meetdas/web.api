using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web.Api.Context;
using web.Api.Models;

namespace web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public PostController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        [Route("[Action]")]
        [HttpGet]
        public List<Post> GetAllPost()
        {
            var Post = _dbContext.Posts.ToList();
            return Post;
        }

        [Route("[action]")]
        [HttpPost]
        public string Add(Post post)
        {
            if (post != null)
            {
                _dbContext.Posts.Add(post);
                bool isSaved = _dbContext.SaveChanges() > 0;
                if (isSaved)
                    return "successfull!";
                return "Failed";
            }
            return "Model is empty";
        }

    }
}
