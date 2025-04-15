using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Guid TaskId { get; set; }
        public ProjectTask Task { get; set; } = default!;

        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
