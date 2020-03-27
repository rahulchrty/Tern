using System.Collections.Generic;

namespace Tern.Domain
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusType { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
