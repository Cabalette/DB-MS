using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table ("file_types")]
    public class FileType
    {
        public short id { get; set; }
        public string name { get; set; }
    }
}
