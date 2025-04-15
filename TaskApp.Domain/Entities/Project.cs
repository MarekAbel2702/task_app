using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Domain.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public Guid OwnerId { get; set; }
        public User Owner { get; set; } = default!;

        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
        public ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}
