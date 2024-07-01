using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int HistId { get; set; }
        public string Commentary { get; set; }
    }
}
