using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Client.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Response<int>>
    {
        public async Task<Response<int>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
