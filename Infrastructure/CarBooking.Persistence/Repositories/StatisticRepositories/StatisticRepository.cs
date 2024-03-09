using CarBooking.Application.Interfaces.StatisticInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarBooking.Persistence.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly CarBookingContext _context;

        public StatisticRepository(CarBookingContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMostBlogComment()
        {
            var values = _context.Comments.GroupBy(x => x.BlogId).Select(y => new
            {
                BlogId = y.Key,
                Count = y.Count(),
            }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string blogTitle = _context.Blogs.Where(x => x.BlogId == values.BlogId).Select(y => y.Title).FirstOrDefault();
            return blogTitle;
        }

        public string GetBrandNameByMostCar()
        {
     

            var values = _context.Cars.GroupBy(x => x.BrandId).Select(y => new
            {
                BrandId = y.Key,
                Count = y.Count(),
            }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault();
            string brandName = _context.Brands.Where(x=>x.BrandId == values.BrandId).Select(y=>y.Name).FirstOrDefault();
            return brandName;
        }

        public int GetAuthorCount()
        {
            return _context.Authors.Count();
        }

        public decimal GetAvgRentPriceForDaily()
        {
            int id = _context.Pricings.Where(x => x.Name.ToLower() == "günlük").Select(z => z.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(y => y.PricingId == id).Average(w => w.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            int id = _context.Pricings.Where(x => x.Name.ToLower() == "aylık").Select(z => z.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(y => y.PricingId == id).Average(w => w.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(x => x.Name.ToLower() == "haftalık").Select(z => z.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(y => y.PricingId == id).Average(w => w.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            return _context.Blogs.Count();
        }

        public int GetBrandCount()
        {
            return _context.Brands.Count();
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
           
            int pricingId = _context.Pricings.Where(x => x.Name == "Günlük" || x.Name == "Daily").Select(y => y.PricingId).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingId == pricingId).Max(x => x.Amount);
            int carID = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarId).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarId == carID).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            int pricingId = _context.Pricings.Where(x => x.Name == "Günlük" || x.Name == "Daily").Select(y => y.PricingId).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingId == pricingId).Min(x => x.Amount);
            int carID = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarId).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarId == carID).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            return _context.Cars.Count();
        }


        public int GetCarCountByFuelElectric()
        {
            return _context.Cars.Where(x => x.Fuel == "elektrikli" || x.Fuel == "electric" || x.Fuel == "elektrik").Count();

        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            return _context.Cars.Where(x => x.Fuel.ToLower() == "benzin" || x.Fuel.ToLower() == "dizel" ||
            x.Fuel.ToLower() == "gasoline" || x.Fuel.ToLower() == "diesel").Count();
        }

        public int GetCarCountByKmLessThan30000()
        {
            return _context.Cars.Where(x => x.Km < 30000).Count();

        }



        public int GetLocationCount()
        {
            return _context.Locations.Count();
        }

        int IStatisticRepository.GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }
    }
}
