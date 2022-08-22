        
        using School.Models.Interfaces;

namespace School.Models.DtoModels
{
    public class TimetableDto :IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string DisciplineName { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int LessonNumber { get; set; }
    }
}