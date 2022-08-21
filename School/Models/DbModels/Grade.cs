using School.Models.Interfaces;

namespace School.Models.DbModels
{
    public class Grade :IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string GradeName { get; set; }
    }
}
