using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("files")]
    public class File
    {
        public int id { get; set; }
        public short type_id { get; set; }
        public string? caption { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        //public ? crop { get; set; }
        public TaskFile task_file { get; set; }
        public FileType file_type { get; set; }
    }
}
