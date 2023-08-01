using System.ComponentModel.DataAnnotations.Schema;

namespace DB_MS.Models
{
    [Table("tasks")]
    public class Task
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int assigned_to_vacancy_id { get; set; }
        public int assigned_by_vacancy_id { get; set; }
        public short status_id { get; set; }
        public int higher_task_id { get; set; }
        public DateTime from_date { get; set; }
        public DateTime to_date { get; set; }
        public bool is_blocking { get; set; }
        public bool is_delegated { get; set; }
        public Task task { get; set; }
        public TaskFile task_file { get; set; }
        public TaskStatus task_status { get; set; }
        public ICollection<Vacancy > vacancies { get; set; }
    }
}
