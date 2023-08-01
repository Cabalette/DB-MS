using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("vacancies")]
    public class Vacancy
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int role_id { get; set; }
        public string user_uid { get; set; }
        public bool confirmed { get; set; }
        public ICollection<Task> tasks { get; set; }
        public VacancyGroup vacancy_group { get; set; }
        public Group group { get; set; }
        public Invite invite { get; set; }
        public VacancyProject vacancy_project { get; set; }
        public Role role { get; set; }
        public Invite invite { get; set; }
        public ICollection <User > users { get; set; }
    }
}
