using CarBooking.Application.Features.Mediator.Commands.AuthorCommands;
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
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public CreateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Comment
            {
                Name = request.Name,
                Description = request.Description,
                BlogId = request.BlogId,    
                CreatedDate = request.CreatedDate,
                Email = request.Email
                
            });
        }
    }
}
