using School.Models.DbModels;

namespace School.Models.Interfaces.IRepository
{
    public interface IGradeRepository : IRepository<Grade, Guid>
    {
    }
}
