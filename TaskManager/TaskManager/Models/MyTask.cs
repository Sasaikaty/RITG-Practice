using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class MyTask
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string TaskState { get; set; }
        public string TaskPriorty { get; set; }
        public int UserId { get; set; }
        public DateTime TaskDeadline { get; set; }

    }
}
