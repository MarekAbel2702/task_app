using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.DTOs;

namespace TaskApp.Application.Interfaces
{
    public interface ITeamService
    {
        IEnumerable<TeamDto> GetAll();
        Guid Create(CreateTeamDto dto);
        void AddMember(Guid teamId, Guid userId);
    }
}
