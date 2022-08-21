using School.Models.DbModels;
using School.Models.Interfaces.IService;

namespace School.Controllers
{
    public class DisciplineController : BaseController<Discipline, Discipline, Discipline, Discipline>
    {
        public DisciplineController(IDisciplineService service)
            : base(service)
        {

        }
    }
}
