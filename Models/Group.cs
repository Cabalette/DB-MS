using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("groups")]
    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? avatar_id { get; set; }
        public int higher_group_id { get; set; }
        public int main_vacancy_id { get; set; }
        public int organization_id { get; set; }
        public Organization organization { get; set; }
        public Group group { get; set; }
        public File file { get; set; }
        public ICollection<Vacancy> vacancy { get; set; }
        public ICollection<VacancyGroup> vacancy_group { get; set; }
    }
}
