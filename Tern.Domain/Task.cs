namespace Tern.Domain
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int? ListId { get; set; }
        public List List { get; set; }
    }
}
