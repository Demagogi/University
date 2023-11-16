using AutoMapper;
using University.Application.Features.Lectors;
using University.Application.Features.Students;
using University.Domain.Entities;

namespace University.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lector, LectorListVm>().ReverseMap();
            CreateMap<Student, StudentsListVm>().ReverseMap();
            CreateMap<Subject, StudentSubjectsListVm>().ReverseMap();
        }
    }
}
