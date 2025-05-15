using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Domain.Entities;
using TaskApp.Domain.Interfaces;
using TaskApp.Infrastructure.Persistence;

namespace TaskApp.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _context;

        public TeamRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Team team) => _context.Teams.Add(team);

        public IEnumerable<Team> GetAll() => _context.Teams.ToList();

        public Team? GetById(Guid id) =>
            _context.Teams.FirstOrDefault(t => t.Id == id);

        public void Save() => _context.SaveChanges();
    }
}
