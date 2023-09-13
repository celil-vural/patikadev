using BookStore.BookOperations.CreateBook;
using BookStore.BookOperations.DeleteBook;
using BookStore.BookOperations.GetBookDetail;
using BookStore.BookOperations.GetBooks;
using BookStore.BookOperations.UpdateBook;
using Microsoft.AspNetCore.Mvc;
using Repositoriy.Concrate.Ef;
using static BookStore.BookOperations.CreateBook.CreateBookQuery;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class BookController : ControllerBase
    {
        private readonly EfRepositoryContext _context;
        public BookController(EfRepositoryContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult Books()
        {
            GetBooksQuery query = new(_context);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute(Name = "id")] int id)
        {
            BookDetailViewModel result;
            try
            {
                GetBookDetailQuery query = new(_context);
                query.BookId = id;
                result = query.Handle();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddBook([FromForm] CreateBookModel newBook)
        {
            try
            {
                CreateBookQuery command = new(_context);
                command.Model = newBook;
                command.Handle();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromRoute] int id, [FromBody] UpdateBookModel updatedBook)
        {
            try
            {
                UpdateBookCommand command = new(_context);
                command.BookId = id;
                command.Model = updatedBook;
                command.Handle();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            try
            {
                DeleteBookCommand command = new(_context);
                command.BookId = id;
                command.Handle();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}