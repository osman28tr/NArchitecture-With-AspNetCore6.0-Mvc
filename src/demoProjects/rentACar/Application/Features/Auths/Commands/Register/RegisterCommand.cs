using Application.Features.Auths.Dtos;
using AutoMapper;
using Core.Security.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auths.Commands.Register
{
	public class RegisterCommand:IRequest<RegisteredDto>
	{
        public UserForRegisterDto UserForRegisterDto { get; set; }
        public string IpAddress { get; set; }
		public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisteredDto>
		{
			private readonly IMapper _mapper;
			public Task<RegisteredDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
			{
				throw new NotImplementedException();
			}
		}
	}
}
