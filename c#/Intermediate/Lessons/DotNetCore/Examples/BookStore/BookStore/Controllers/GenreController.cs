using Entity.Concrete.Dtos.Genre;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts.Genres;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService service;

        public GenreController(IGenreService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Genres()
        {
            var result = service.GetHashSet();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] DtoForCreateGenre dto)
        {
            var result = service.CreateWithDto(dto);
            return Ok(result);
        }

        [HttpDelete("api/Genre/Delete/{id}")]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            service.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] DtoForUpdateGenre dto)
        {
            var result = service.Update(dto);
            return Ok(result);
        }
    }
}
