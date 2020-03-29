namespace Tern.Model
{
    public class SubTaskModel
    {
        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public int TaskId { get; set; }
        public StatusModel Status { get; set; }
    }
}
