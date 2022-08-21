using School.Models.Interfaces;

namespace School.Models.DbModels
{
    public class Timetable :IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid DisciplineId { get; set; }
        public Guid GradeId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int LessonNumber { get; set; }
    }
}
