using AutoMapper;
using School.Models.DbModels;
using School.Models.Interfaces.IRepository;
using School.Models.Interfaces.IService;

namespace School.Services
{
    public class TimetableService : BaseService<Timetable, Timetable, Timetable, Timetable>, ITimetableService
    {
        public TimetableService(ITimetableRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}
