using Entity.Concrete.Dtos.Users;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts.Users;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] DtoForCreateUser model)
        {
            service.CreateWithDto(model);
            return Ok();
        }
    }
}
