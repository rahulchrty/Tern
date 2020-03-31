using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tern.Domain
{
    public class List
    {
        public int ListId { get; set; }
        [Required]
        public string ListName { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
