using CarBooking.Application.Features.Mediator.Queries.BlogQueries;
using CarBooking.Application.Features.Mediator.Results.BlogResults;
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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
          var values =  await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
               BlogId = values.BlogId,
               AuthorId = values.AuthorId,
               CreatedDate = values.CreatedDate,
               CoverImageUrl = values.CoverImageUrl,
               CategoryId = values.CategoryId,
               Title = values.Title,
               Description = values.Description,
           
            };
        }
    }
}
