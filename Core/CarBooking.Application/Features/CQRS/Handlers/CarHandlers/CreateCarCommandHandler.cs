using CarBooking.Application.Features.CQRS.Commands.CarCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
              BigImageUrl = command.BigImageUrl,
              LuggageCapacity = command.LuggageCapacity,
              Km = command.Km,
              Model = command.Model,
              Seat = command.Seat,
              Transmission = command.Transmission,
              BrandId = command.BrandId,
              CoverImageUrl = command.CoverImageUrl,
              Fuel = command.Fuel
            });
        }
    }
}
