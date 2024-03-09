using CarBooking.Application.Features.CQRS.Commands.AboutCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAboutCommand command)
        {
           await _repository.CreateAsync(new About
           {
               Description = command.Description,
               Title = command.Title,
               ImageUrl = command.ImageUrl
           });
        }
    }
}
