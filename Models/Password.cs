using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("prohibitions")]
    public class Password
    {
        public string user_uid { get; set; }
        public string hash { get; set; }
        public string salt { get; set; }

    }
}
