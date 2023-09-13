using Entities.Concrete.Dtos.Book;
using Entities.Concrete.Dtos.Books;
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
            try
            {
                var result = _bookService.GetHashSet<DtoForGetBooks>();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute(Name = "id")] int id)
        {
            try
            {
                var result = _bookService.GetWithId<DtoForGetBookDetail>(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddBook([FromForm] DtoForCreateBook newBook)
        {
            try
            {
                _bookService.CreateWithDto(newBook);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody] DtoForUpdateBook updatedBook)
        {
            try
            {
                _bookService.Update(updatedBook);
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
                _bookService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}