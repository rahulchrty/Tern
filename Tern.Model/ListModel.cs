using System.Collections.Generic;

namespace Tern.Model
{
    public class ListModel
    {
        public int ListId { get; set; }
        public string ListName { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
