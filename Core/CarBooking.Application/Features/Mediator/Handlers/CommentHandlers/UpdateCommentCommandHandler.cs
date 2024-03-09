using CarBooking.Application.Features.Mediator.Commands.CommentCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public UpdateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.CommentId);
            value.Name = request.Name;
            value.Description = request.Description;
            value.CreatedDate = request.CreatedDate;
            value.BlogId = request.BlogId;
            
            await _repository.UpdateAsync(value);
        }
    }
}
