using CarBooking.Application.Interfaces.AppUserInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Persistence.Repositories.AppUserRepositories
{
	public class AppUserRepository : IAppUserRepository
	{
		private readonly CarBookingContext _context;

		public AppUserRepository(CarBookingContext context)
		{
			_context = context;
		}
		public async Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
		{
			throw new NotImplementedException();
		}
	}
}
