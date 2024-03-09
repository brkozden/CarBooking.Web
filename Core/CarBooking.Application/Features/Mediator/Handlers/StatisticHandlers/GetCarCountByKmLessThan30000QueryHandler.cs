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
    public class GetCarCountByKmLessThan30000QueryHandler : IRequestHandler<GetCarCountByKmLessThan30000Query, GetCarCountByKmLessThan30000QueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetCarCountByKmLessThan30000QueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmLessThan30000QueryResult> Handle(GetCarCountByKmLessThan30000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmLessThan30000();
            return new GetCarCountByKmLessThan30000QueryResult
            {
                CarCountByKmLessThan30000 = value,

            };
        }
    }
}
