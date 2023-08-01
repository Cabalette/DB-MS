using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("permissions")]
    public class Permission
    {
        public short id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
