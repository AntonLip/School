using School.Models.DbModels;

namespace School.Models.Interfaces.IService
{
    public interface IGradeService : IService<Grade, Grade, Grade, Grade, Guid>
    {
    }
}
