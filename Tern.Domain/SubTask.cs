﻿namespace Tern.Domain
{
    public class SubTask
    {
        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
