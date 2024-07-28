using EmrysSerenAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmrysSerenAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CommentPostController : Controller
    {
        private readonly ICommentPostRepository _commentPostRepository;

        public CommentPostController(ICommentPostRepository commentPostRepository)
        {
            _commentPostRepository = commentPostRepository;
        }

        [HttpGet]
        public IActionResult GetCommentPosts()
        {
            return Ok(_commentPostRepository.GetAllCommentPosts());
        }

        [HttpGet("{blogid}")]
        public IActionResult GetCommentPostsByBlogId(int blogid)
        {
            return Ok(_commentPostRepository.GetCommentPostsByBlogId(blogid));
        }

        [HttpGet("{userid}")]
        public IActionResult GetCommentPostsByUserId(int userid)
        {
            return Ok(_commentPostRepository.GetCommentPostsByUserId(userid));
        }
    }
}
