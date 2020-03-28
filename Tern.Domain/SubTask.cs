using System;
using System.Collections.Generic;
using System.Text;

namespace Tern.Domain
{
    public class SubTask
    {
        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public string Description { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
