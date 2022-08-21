using School.Models.Interfaces;

namespace School.Models.DbModels
{
    public class Discipline : IEntity<Guid>
    {
        public string DisciplineName { get; set; }
        public Guid Id { get; set; }
    }
}
