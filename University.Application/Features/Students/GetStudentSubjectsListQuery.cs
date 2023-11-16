using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.Features.Students
{
    public class GetStudentSubjectsListQuery: IRequest<List<StudentSubjectsListVm>>
    {
        public Guid Id { get; set; }
    }
}
