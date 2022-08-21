using Microsoft.AspNetCore.Mvc;
using School.Models.DbModels;
using School.Models.Interfaces.IService;

namespace School.Controllers
{
    public class GradeController : BaseController<Grade, Grade, Grade, Grade>
    {
        public GradeController(IGradeService service)
            : base(service)
        {

        }
    }
}
