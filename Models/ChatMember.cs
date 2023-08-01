using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("chat_members")]
    public class ChatMember
    {
        public int id { get;set; }
        public int chat_id { get;set; }
        public int member_id { get;set; }
        public long last_readed_message_id { get;set; }
        public Chat chat { get;set; }
        public User user { get;set; }
        public ICollection<Message> messages { get; set; }
    }
}
