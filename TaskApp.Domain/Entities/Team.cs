using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Domain.Entities
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;

        public List<User> Members { get; set; } = new List<User>();
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
