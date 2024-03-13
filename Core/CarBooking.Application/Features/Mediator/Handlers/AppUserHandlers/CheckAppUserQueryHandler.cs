using CarBooking.Application.Features.Mediator.Queries.AppUserQueries;
using CarBooking.Application.Features.Mediator.Results.AppUserResults;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Interfaces.AppUserInterfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.AppUserHandlers
{
	public class CheckAppUserQueryHandler : IRequestHandler<CheckAppUserQuery, CheckAppUserQueryResult>
	{
		private readonly IRepository<AppUser> _appUserRepository;
		private readonly IRepository<AppRole> _appRoleRepository;

		public CheckAppUserQueryHandler(IRepository<AppUser> appUserRepository, IRepository<AppRole> appRoleRepository)
		{
			_appUserRepository = appUserRepository;
			_appRoleRepository = appRoleRepository;
		}

		public async Task<CheckAppUserQueryResult> Handle(CheckAppUserQuery request, CancellationToken cancellationToken)
		{
			var values = new CheckAppUserQueryResult();
			var user = await _appUserRepository.GetByFilterAsync(x=>x.UserName==request.Username && x.Password==request.Password);
			if (user != null) 
			{ 
				values.IsExist = true;
				values.Username = user.UserName;
				values.Role = (await _appRoleRepository.GetByFilterAsync(x => x.AppRoleId == user.AppRoleId)).AppRoleName;
				values.Id = user.AppUserId;
			}
			else
			{
				values.IsExist = false;
			}
			return values;
		}
	}
}
