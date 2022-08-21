using AutoMapper;
using School.Models.DbModels;
using School.Models.Interfaces.IRepository;
using School.Models.Interfaces.IService;

namespace School.Services
{
    public class GradeService : BaseService<Grade, Grade, Grade, Grade>, IGradeService
    {
        public GradeService(IGradeRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
