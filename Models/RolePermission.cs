using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table ("role_permissions")]
    public class RolePermission
    {
        public int id { get; set; }
        public int role_id { get; set; }
        public short permission_id { get; set; }
        public Role role { get; set; }
        public Permission permission { get; set; }
    }
}
