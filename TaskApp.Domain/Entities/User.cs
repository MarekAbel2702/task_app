using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public string Role { get; set; } = "User";

        public List<Project> OwnedProjects { get; set; } = new List<Project>();
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
