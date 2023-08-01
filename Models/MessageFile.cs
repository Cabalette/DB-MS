using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("message_files")]
    public class MessageFile
    {
        public int id { get; set; }
        public long message_id { get; set; }
        public int file_id { get; set; }
        public File file { get; set; }
        public Message message { get; set; }
        public int attachment_id
        {
            get
            {
                return file.task_file.attachment_id;
            }
        }
    }
}
