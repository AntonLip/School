using AutoMapper;
using School.Models.DbModels;
using School.Models.DtoModels;
using School.Models.Interfaces.IRepository;
using School.Models.Interfaces.IService;

namespace School.Services
{
    public class TimetableService : BaseService<Timetable, Timetable, Timetable, Timetable>, ITimetableService
    {
        private readonly ITimetableRepository _repository;
        public TimetableService(ITimetableRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
        }

        public  List<TimetableDto> GetTimetableByGradeId(Guid gradeId)
        {

            if (gradeId == Guid.Empty)
                throw new ArgumentException("guid is Empty");
            var timetable = _repository.GetWithInclude(p => p.GradeId == gradeId);
            return timetable is null ? throw new ArgumentException() : _mapper.Map<List<TimetableDto>>(timetable);

        }
    }
}
