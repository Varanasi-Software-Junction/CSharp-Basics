using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly Infrastructure.Data.LibraryContext context;
        public   BookController(Infrastructure.Data.LibraryContext context)
        {
            this.context = context;

        }
        [HttpGet]
        public async Task< ActionResult<List<Core.Entities.Book>>> GetBooks()
        {
        var books=await context.Books.ToListAsync();
        return books;
        }


    }
}