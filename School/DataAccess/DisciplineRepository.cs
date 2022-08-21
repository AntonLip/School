using School.Models.DbModels;
using School.Models.Interfaces.IRepository;

namespace School.DataAccess
{
    public class DisciplineRepository : BaseRepository<Discipline>, IDisciplinesRepository
    {
        public DisciplineRepository(DbContext context) : base(context)
        {
        }
    }
}
