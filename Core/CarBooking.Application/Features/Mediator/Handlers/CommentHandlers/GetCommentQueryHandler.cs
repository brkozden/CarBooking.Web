using CarBooking.Application.Features.Mediator.Queries.CommentQueries;
using CarBooking.Application.Features.Mediator.Results.AuthorResults;
using CarBooking.Application.Features.Mediator.Results.CommentResults;
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
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCommentQueryResult
            {
                Name = x.Name,
                Description = x.Description,
                CreatedDate = DateTime.Now,
                BlogId = x.BlogId,
                

            }).ToList();
        }
    }
}
