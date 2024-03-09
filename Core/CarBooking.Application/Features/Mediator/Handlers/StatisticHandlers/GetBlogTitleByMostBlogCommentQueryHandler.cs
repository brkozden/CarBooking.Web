using CarBooking.Application.Features.Mediator.Queries.StatisticQueries;
using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetBlogTitleByMostBlogCommentQueryHandler : IRequestHandler<GetBlogTitleByMostBlogCommentQuery, GetBlogTitleByMostBlogCommentQueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetBlogTitleByMostBlogCommentQueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogTitleByMostBlogCommentQueryResult> Handle(GetBlogTitleByMostBlogCommentQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogTitleByMostBlogComment();
            return new GetBlogTitleByMostBlogCommentQueryResult
            {
                BlogTitleByMostBlogComment = value,

            };
        }
    }


}
