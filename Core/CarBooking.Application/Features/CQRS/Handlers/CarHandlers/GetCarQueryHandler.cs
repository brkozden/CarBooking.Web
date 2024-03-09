using CarBooking.Application.Features.CQRS.Results.CarResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
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
