using AutoMapper;
using School.Models.DbModels;
using School.Models.Interfaces.IRepository;
using School.Models.Interfaces.IService;

namespace School.Services
{
    public class DisciplineService : BaseService<Discipline, Discipline, Discipline, Discipline>, IDisciplineService
    {
        public DisciplineService(IDisciplinesRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}
