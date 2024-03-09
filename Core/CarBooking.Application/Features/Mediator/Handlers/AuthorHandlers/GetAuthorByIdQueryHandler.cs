using CarBooking.Application.Features.Mediator.Queries.AuthorQueries;
using CarBooking.Application.Features.Mediator.Results.AuthorResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetBlogByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
          var values =  await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                AuthorId = values.AuthorId,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Name = values.Name
           
            };
        }
    }
}
