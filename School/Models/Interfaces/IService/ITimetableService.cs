using School.Models.DbModels;
using School.Models.DtoModels;

namespace School.Models.Interfaces.IService
{
    public interface ITimetableService : IService<Timetable, Timetable, Timetable, Timetable, Guid>
    {
        List<TimetableDto> GetTimetableByGradeId(Guid gradeId);
    }
}
