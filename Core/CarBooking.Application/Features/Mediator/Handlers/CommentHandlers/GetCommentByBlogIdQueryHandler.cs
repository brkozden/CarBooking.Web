using CarBooking.Application.Features.Mediator.Queries.CommentQueries;
using CarBooking.Application.Features.Mediator.Results.CommentResults;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Interfaces.CommentInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentByBlogIdQueryHandler : IRequestHandler<GetCommentByBlogIdQuery, List<GetCommentByBlogIdQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetCommentByBlogIdQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCommentByBlogIdQueryResult>> Handle(GetCommentByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCommentsByBlogId(request.Id);
            return values.Select(x => new GetCommentByBlogIdQueryResult
            {
                BlogId = x.BlogId,
               CreatedDate = x.CreatedDate,
               CommentId = x.CommentId,
               Description = x.Description,
               Name = x.Name

            }).ToList();
        }
    }
}
