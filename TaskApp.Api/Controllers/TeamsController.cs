using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskApp.Application.DTOs;
using TaskApp.Application.Interfaces;

namespace TaskApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_teamService.GetAll());

        [HttpPost]
        public IActionResult Create(CreateTeamDto dto)
        {
            var id = _teamService.Create(dto);
            return CreatedAtAction(nameof(GetAll), new { id }, null);
        }

        [HttpPost("{id}/members")]
        public IActionResult AddMembers(Guid id, AddMemberDto dto)
        {
            _teamService.AddMember(id, dto.UserId);
            return NoContent();
        }
    }
}
