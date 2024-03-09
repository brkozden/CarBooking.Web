using CarBooking.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBooking.Application.Features.Mediator.Results.TagCloudResults;
using CarBooking.Application.Interfaces.TagCloudInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly ITagCloudRepository _repository;

        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetTagCloudByBlogId(request.Id);
            return values.Select(x => new GetTagCloudByBlogIdQueryResult
            {
              BlogId = x.BlogId,
              Title = x.Title,
              TagCloudId = x.TagCloudId

            }).ToList();
        }
    }
}
