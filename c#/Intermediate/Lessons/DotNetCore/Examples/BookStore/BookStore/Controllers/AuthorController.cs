using Entity.Concrete.Dtos.Author;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts.Authors;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService service;

        public AuthorController(IAuthorService service)
        {
            this.service = service;
        }

        [HttpGet(("api/Author/Get/{id}"))]
        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            var result = service.GetWithId(id);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = service.GetHashSet();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromForm] DtoForCreateAuthor dto)
        {
            var result = service.CreateWithDto(dto);
            return Ok(result);
        }
        [HttpDelete("api/Author/Delete/{id}")]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            service.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] DtoForUpdateAuthor dto)
        {
            var result = service.Update(dto);
            return Ok(result);
        }
    }
}
