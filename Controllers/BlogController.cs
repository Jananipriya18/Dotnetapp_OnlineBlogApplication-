using Microsoft.AspNetCore.Mvc;
using dotnetapp.Data;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    // BlogController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BlogController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Blog blog)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();

            return Ok(blog);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var blogs = _dbContext.Blogs.ToList();
            return Ok(blogs);
        }
    }
}