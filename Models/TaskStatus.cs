using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table ("task_statuses")]
    public class TaskStatus
    {
        public short id { get; set; }
        public string name { get; set; }
    }
}
