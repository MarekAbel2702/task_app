using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskApp.Application.DTOs;
using TaskApp.Application.Interfaces;

namespace TaskApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersControllers : ControllerBase
    {
        private readonly IUserService _service;

        public UsersControllers(IUserService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public ActionResult<UserDto> GetById(Guid id) => Ok(_service.GetById(id));

        [HttpPost]
        public ActionResult Create(CreateUserDto dto)
        {
            var newId = _service.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = newId }, null);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) 
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
