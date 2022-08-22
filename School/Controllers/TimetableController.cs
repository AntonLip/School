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
        private readonly ITimetableService _service;
        public TimetableController(ITimetableService service, IDisciplineService iplineService,
         IGradeService gradeService)
            : base(service)
        {
            _iplineService = iplineService;
            _gradeService = gradeService;
            _service   = service;
        }
        public override async Task<IActionResult> IndexAsync()
        {
            var grades = await _gradeService.GetAllAsync();
            ViewBag.Grades = new SelectList(grades, "Id", "GradeName");
            return View();
        }
        public override IActionResult CreateAsync()
        {
            try
            {
                var grades = _gradeService.GetAllAsync().Result;
                ViewBag.Grades = new SelectList(grades, "Id", "GradeName");
                var dicsiplines = _iplineService.GetAllAsync().Result;
                ViewBag.Disciplines = new SelectList(dicsiplines, "Id", "DisciplineName");
                return View();
            }
            catch (Exception ex)
            {
                return View("Home", "Error");
            }

        }

        public IActionResult GetTimetableByGrade(Guid id)
        {
            try
            {
                var timetable = _service.GetTimetableByGradeId(id);
                return View("Index", timetable);
            }
            catch (Exception ex)
            {
                return View("Home", "Error");
            }
        }
    }
}
