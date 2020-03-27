using System.Collections.Generic;

namespace Tern.Domain
{
    public class List
    {
        public int ListId { get; set; }
        public string ListName { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
