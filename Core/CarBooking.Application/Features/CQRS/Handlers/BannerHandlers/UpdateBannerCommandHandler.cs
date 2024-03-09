using CarBooking.Application.Features.CQRS.Commands.BannerCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.BannerId);
            value.Title = command.Title;
            value.Description = command.Description;
            value.VideoUrl = command.VideoUrl;
            value.VideoDescription = command.VideoDescription;

            await _repository.UpdateAsync(value);
        }
    }
}
