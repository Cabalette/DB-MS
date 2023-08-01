using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("organizations")]
    public class Organization
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? avatar_id { get; set; }
        public ICollection<Project>? projects { get; set; }
        public ICollection<Chat>? chats { get; set; }
        public ICollection<Group>? groups { get; set; }
        public ICollection<Role>? roles { get; set; }
        public ICollection<Invite>? invites { get; set; }
        public File? file { get; set; }
    }
}