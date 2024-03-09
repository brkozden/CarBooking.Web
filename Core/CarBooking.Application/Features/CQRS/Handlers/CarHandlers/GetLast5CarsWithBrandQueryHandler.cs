using CarBooking.Application.Features.CQRS.Results.CarResults;
using CarBooking.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarsWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLast5CarsWithBrands();
            return values.Select(x => new GetCarsWithBrandQueryResult
            {
                BrandName = x.Brand.Name,
                BigImageUrl = x.BigImageUrl,
                CoverImageUrl = x.CoverImageUrl,
                LuggageCapacity = x.LuggageCapacity,
                Model = x.Model,
                Km = x.Km,
                Fuel = x.Fuel,
                Seat = x.Seat,
                Transmission = x.Transmission,
                BrandId = x.BrandId,
                CarId = x.CarId


            }).ToList();
        }
    }
}
