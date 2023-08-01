using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("roles")]
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? higher_role_id { get; set; }
        public int organization_id { get; set; }
        public Organization organization { get; set; }
        public Role role { get; set; }
        public Vacancy vacancy { get; set; }
        public RolePermission role_permission { get; set; }
    }
}
