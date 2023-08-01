using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table ("task_files")]
    public class TaskFile
    {
        public int id { get; set; }
        public int task_id { get; set; }
        public int attachment_id { get; set; }
        public Task task { get; set; }
        public File file { get; set; }
    }
}
