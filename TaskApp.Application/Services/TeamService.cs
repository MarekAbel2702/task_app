using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.DTOs;
using TaskApp.Application.Interfaces;
using TaskApp.Domain.Entities;
using TaskApp.Domain.Interfaces;

namespace TaskApp.Application.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepo;
        private readonly IUserRepository _userRepo;

        public TeamService(ITeamRepository teamRepo, IUserRepository userRepo)
        {
            _teamRepo = teamRepo;
            _userRepo = userRepo;
        }

        public void AddMember(Guid teamId, Guid userId)
        {
            var team = _teamRepo.GetById(teamId)
                               ?? throw new Exception("Team not found");
            var user = _userRepo.GetById(userId)
                                ?? throw new Exception("User not found");

            if (!team.Members.Contains(user))
            {
                team.Members.Add(user);
                _teamRepo.Save();
            }
        }

        public Guid Create(CreateTeamDto dto)
        {
            var team = new Team
            {
                Id = Guid.NewGuid(),
                Name = dto.Name
            };

            _teamRepo.Add(team);
            _teamRepo.Save();
            return team.Id;
        }

        public IEnumerable<TeamDto> GetAll()
        {
            return _teamRepo.GetAll().Select(t => new TeamDto
            {
                Id = t.Id,
                Name = t.Name,
                Members = t.Members.Select(m => new UserDto
                {
                    Id = m.Id,
                    Email = m.Email,
                    FullName = m.FullName,
                    Role = m.Role
                }).ToList()
            });
        }
    }
}
