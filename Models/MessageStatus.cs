using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("message_statuses")]
    public class MessageStatus
    {
        public short id { get; set; }
        public string name { get; set; }
        public Message message { get; set; }
    }
}
