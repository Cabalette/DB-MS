using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("messages")]
    public class Message
    {
        public long id { get; set; }
        public string text { get; set; }
        public int chat_id { get; set; }
        public short status_id { get; set; }
        public int user_uid { get; set; }
        public long quoted_message_id { get; set; }
        public Message message { get; set; }
        public MessageFile message_file { get; set; }
        public ChatMember chat_member { get; set; }
        public Chat chat { get; set; }
        public MessageStatus message_status { get; set; }
        public User user { get; set; }
    }
}
