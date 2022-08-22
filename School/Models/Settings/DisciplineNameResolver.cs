using AutoMapper;
using School.Models.DbModels;
using School.Models.DtoModels;
using School.Models.Interfaces.IService;

namespace School.Models.Settings
{
    public class DisciplineNameResolver : IValueResolver<Timetable, TimetableDto, string>
    {
        private readonly IDisciplineService _disciplineService;
        public DisciplineNameResolver(IDisciplineService disciplineService)
        {
            _disciplineService = disciplineService;
        }

        public string Resolve(Timetable source, TimetableDto destination, string destMember, ResolutionContext context)
        {
            try
            {
                var item = _disciplineService.GetByIdAsync(source.DisciplineId).Result;
                destMember = item.DisciplineName;
                return  item.DisciplineName;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}