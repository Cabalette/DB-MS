using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("projects")]
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? avatar_id { get; set; }
        public int organization_id { get; set; } 
        public string? main_user_uid { get; set; }
        public Organization organization { get; set; }
        public File? file { get; set; }
        public ICollection<VacancyProject>? vacancy_projects { get; set; }
        public User? main_user { get; set; }
    }
}
