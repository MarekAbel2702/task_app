using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Domain.Entities
{
    public enum TaskStatus
    {
        ToDo,
        InProgres,
        Done
    }

    public class ProjectTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? Deadline { get; set; } 
        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public int Priority { get; set; } = 1;

        public Guid ProjectId { get; set; }
        public Project Project { get; set; } = default!;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
