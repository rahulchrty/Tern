using System;
using System.ComponentModel.DataAnnotations;

namespace Tern.Domain
{
    public class SubTask
    {
        public int SubTaskId { get; set; }
        [Required]
        public string SubTaskName { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
