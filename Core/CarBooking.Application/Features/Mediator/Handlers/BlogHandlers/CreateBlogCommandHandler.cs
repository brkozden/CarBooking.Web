using CarBooking.Application.Features.Mediator.Commands.BlogCommands;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
             Title = request.Title,
             CategoryId = request.CategoryId,
             CoverImageUrl = request.CoverImageUrl,
             CreatedDate = request.CreatedDate,
             AuthorId = request.AuthorId,
             
            });
        }
    }
}
