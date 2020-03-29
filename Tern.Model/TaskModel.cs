namespace Tern.Model
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public StatusModel Status { get; set; }
        public ListModel List { get; set; }
    }
}
