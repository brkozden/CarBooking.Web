using CarBooking.Application.Interfaces.CarInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Persistence.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookingContext _context;

        public CarRepository(CarBookingContext context)
        {
            _context = context;
        }

       
        public List<Car> GetCarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }

     

        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarId).Take(5).ToList();
            return values;
        }
    }
}
