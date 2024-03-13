using CarBooking.Application.Interfaces.CarDescriptionInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookingContext _context;

        public CarDescriptionRepository(CarBookingContext context)
        {
            _context = context;
        }

        public CarDescription GetCarDescription(int carId)
        {
           var values = _context.CarDescriptions.Where(x=>x.CarId == carId).FirstOrDefault();
            return values;
        }
    }
}
