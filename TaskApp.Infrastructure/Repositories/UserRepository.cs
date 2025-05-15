using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.Interfaces;
using TaskApp.Domain.Entities;
using TaskApp.Infrastructure.Persistence;

namespace TaskApp.Infrastructure.Repositories
{
    public class UserRepository :IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll() => _context.Users.ToList();

        public User? GetById(Guid id) => _context.Users.FirstOrDefault(u => u.Id == id);

        public void Add(User user) 
        {
            _context.Users.Add(user);
        }

        public void Delete(Guid id) 
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null) 
            {
                _context.Users.Remove(user);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
