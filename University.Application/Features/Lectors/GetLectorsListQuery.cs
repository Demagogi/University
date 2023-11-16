using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.Features.Lectors
{
    public class GetLectorsListQuery : IRequest<List<LectorListVm>>
    {
    }
}
