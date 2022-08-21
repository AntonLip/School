using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Models.DbModels;
using School.Models.Interfaces.IService;

namespace School.Controllers
{
    public class TimetableController : BaseController<Timetable, Timetable, Timetable, Timetable>
    {
        private readonly IDisciplineService _iplineService;
        private readonly IGradeService _gradeService;
        public TimetableController(ITimetableService service, IDisciplineService iplineService, IGradeService gradeService)
            : base(service)
        {
            _iplineService = iplineService;
            _gradeService = gradeService;   
        }
        public override  IActionResult CreateAsync()
        {
            var grades =  _gradeService.GetAllAsync().Result;
            ViewBag.Grades = new SelectList(grades, "Id", "GradeName");
            var dicsiplines = _iplineService.GetAllAsync().Result;
            ViewBag.Disciplines = new SelectList(dicsiplines, "Id", "DisciplineName");
            return View();
        }
    }
}
