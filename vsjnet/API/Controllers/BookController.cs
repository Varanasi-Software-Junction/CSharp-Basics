using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly LibraryContext context;
        public   BookController(LibraryContext context)
        {
            this.context = context;

        }
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
        var books=context.Books.ToList();
        return books;
        }


    }
}