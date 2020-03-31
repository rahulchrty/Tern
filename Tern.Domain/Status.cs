using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tern.Domain
{
    public class Status
    {
        public int StatusId { get; set; }
        [Required]
        public string StatusType { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<SubTask> SubTasks { get; set; }
    }
}
