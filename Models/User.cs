using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("users")]
    public class User
    {
        public string uid { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string middle_name { get; set; }
        public string phone { get; set; }
        public int avatar_id { get; set; }
        public bool email_confirmed { get; set; }
        public Vacancy vacancy { get; set; }
        public ICollection<Project> project { get; set; }
        public ChatMember chat_member { get; set; }
        public ICollection<Message> messages { get; set; }
        public Password password { get; set; }
    }
}
