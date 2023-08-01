using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("invites")]
    public class Invite
    {
        public int id { get; set; }
        public string email { get; set; }
        public int organization_id { get; set; }
        public int vacancy_id { get; set; }
        public int project_id { get; set; }

    }
}
