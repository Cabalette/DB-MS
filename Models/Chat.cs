using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("chats")]
    public class Chat
    {
        public int id { get; set; }
        public string title { get; set; }
        public int organization_id { get; set; }
        public int? avatar_id { get; set; }
        public ICollection<ChatMember>? chat_members { get; set; }
        public Organization organization { get; set; }  
        public ICollection<Message>? messages { get; set; }
        public File? file { get; set; }
    }
}
