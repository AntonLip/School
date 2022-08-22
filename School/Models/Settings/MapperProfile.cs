using AutoMapper;
using School.Models.DbModels;
using School.Models.DtoModels;

namespace School.Models.Settings
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Timetable, TimetableDto>()
            .ForMember(dest => dest.DisciplineName,
                    opt =>
                    {
                        opt.MapFrom<DisciplineNameResolver>();
                    });
        }
    }
}
