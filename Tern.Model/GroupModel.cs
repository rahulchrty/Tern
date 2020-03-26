using System.Collections.Generic;

namespace Tern.Model
{
    public class GroupModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
