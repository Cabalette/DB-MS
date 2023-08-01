using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("vacancy_groups")]
    public class VacancyGroup
    {
        public int id { get; set; }
        public int vacancy_id { get; set; }
        public int group_id { get; set; }
        public ICollection<Vacancy> vacancies { get; set; }
        public Group group { get; set; }
    }
}
