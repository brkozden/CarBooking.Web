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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarId);
            value.BigImageUrl = command.BigImageUrl;
            value.Km = command.Km;
            value.Seat = command.Seat;
            value.Transmission = command.Transmission;
            value.LuggageCapacity = command.LuggageCapacity;
            value.Fuel = command.Fuel;
            value.BrandId = command.BrandId;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Model = command.Model;
            await _repository.UpdateAsync(value);
        }
    }
}
