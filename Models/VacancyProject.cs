using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("vacancy_projects")]
    public class VacancyProject
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int vacancy_id { get; set; }
        public Project project { get; set; }
        public Vacancy vacancy { get; set; }
    }
}
