
using CarBooking.Application.Features.CQRS.Queries.CarQueries;
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
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandId = values.BrandId,
               BigImageUrl = values.BigImageUrl,
               CoverImageUrl = values.CoverImageUrl,
               Fuel = values.Fuel,
               Km = values.Km,
               LuggageCapacity = values.LuggageCapacity,
               Model = values.Model,
               Seat = values.Seat,
               Transmission = values.Transmission,
               CarId = values.CarId


            };
        }
    }
}
