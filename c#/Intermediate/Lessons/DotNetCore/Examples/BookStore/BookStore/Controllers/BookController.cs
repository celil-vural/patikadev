using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositoriy.Concrate.Ef;

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
        public HashSet<Book?>? Books()
        {
            return _context.Books.OrderBy(e => e.Id).ToHashSet<Book?>();
        }
        [HttpGet("{id}")]
        public Book? GetById([FromRoute(Name = "id")] int id)
        {
            return _context.Books.FirstOrDefault(e => e.Id == id);
        }
        [HttpPost]
        public IActionResult AddBook([FromForm] Book newBook)
        {
            var book = _context.Books.FirstOrDefault(e => e.Title == newBook.Title);
            if (book is not null)
            {
                return BadRequest();
            }
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromRoute] int id, [FromBody] Book updatedBook)
        {
            var book = _context.Books.FirstOrDefault(e => e.Id == id);
            if (book is null) return BadRequest();
            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            book.Title = updatedBook.Title != default ? updatedBook.Title : book.Title;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            var book = _context.Books.FirstOrDefault(e => e.Id == id);
            if (book is null) return BadRequest();
            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}