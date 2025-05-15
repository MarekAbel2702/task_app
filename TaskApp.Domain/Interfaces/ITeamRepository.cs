using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Domain.Entities;

namespace TaskApp.Domain.Interfaces
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetAll();
        Team? GetById(Guid id);
        void Add(Team team);
        void Save();
    }
}
