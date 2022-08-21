using School.Models.DbModels;
using School.Models.Interfaces.IRepository;

namespace School.DataAccess
{
    public class TimetableRepository : BaseRepository<Timetable>, ITimetableRepository
    {
        public TimetableRepository(DbContext context) : base(context)
        {
        }
    }
}
