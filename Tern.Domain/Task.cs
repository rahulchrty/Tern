using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tern.Domain
{
    public class Task
    {
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int? ListId { get; set; }
        public List List { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public ICollection<SubTask> SubTasks { get; set; }
    }
}
