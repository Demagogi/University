using AutoMapper;
using University.Application.Features.Lectors.Commands.CreateLector;
using University.Application.Features.Lectors.Commands.DeleteLector;
using University.Application.Features.Lectors.Commands.UpdateLector;
using University.Application.Features.Lectors.Queries.GetLectorsList;
using University.Application.Features.Students.Queries.GetStudentsList;
using University.Application.Features.Students.Queries.GetStudentWithSubjectsList;
using University.Application.Features.Subjects.Queries.GetSubjectsList;
using University.Domain.Entities;

namespace University.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lector, LectorListVm>().ReverseMap();
            CreateMap<Student, StudentsListVm>().ReverseMap();
            CreateMap<Student, StudentWithSubjectsListVm>().ReverseMap();
            CreateMap<Subject, SubjectsListVm>().ReverseMap();
            CreateMap<Student, StudentWithSubjectsDto>();

            CreateMap<Lector, CreateLectorCommand>().ReverseMap();
            CreateMap<Lector, UpdateLectorCommand>().ReverseMap();
            CreateMap<Lector, DeleteLectorCommand>().ReverseMap();
        }
    }
}
