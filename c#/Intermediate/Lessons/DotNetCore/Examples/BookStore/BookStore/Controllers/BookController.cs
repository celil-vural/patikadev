using Entity.Concrete.Dtos.Books;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts.Books;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IActionResult Books()
        {
            var result = _bookService.GetHashSet();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute(Name = "id")] int id)
        {
            var result = _bookService.GetWithId(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddBook([FromForm] DtoForCreateBook newBook)
        {
            _bookService.CreateWithDto(newBook);
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody] DtoForUpdateBook updatedBook)
        {
            _bookService.Update(updatedBook);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            _bookService.Delete(id);
            return Ok();
        }
    }
}