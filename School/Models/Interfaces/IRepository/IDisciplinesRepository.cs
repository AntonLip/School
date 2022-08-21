using School.Models.DbModels;

namespace School.Models.Interfaces.IRepository
{
    public interface IDisciplinesRepository : IRepository<Discipline, Guid>
    {
    }
}
