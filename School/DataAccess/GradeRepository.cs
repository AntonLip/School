using School.Models.DbModels;
using School.Models.Interfaces.IRepository;

namespace School.DataAccess
{
    public class GradeRepository : BaseRepository<Grade>, IGradeRepository
    {
        public GradeRepository(DbContext context) : base(context)
        {
        }
    }
}
