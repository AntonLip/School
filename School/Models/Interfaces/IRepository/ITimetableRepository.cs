using School.Models.DbModels;

namespace School.Models.Interfaces.IRepository
{
    public interface ITimetableRepository : IRepository<Timetable, Guid>
    {
    }
}
