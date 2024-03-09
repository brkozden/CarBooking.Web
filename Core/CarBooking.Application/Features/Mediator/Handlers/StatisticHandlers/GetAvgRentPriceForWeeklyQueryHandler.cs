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
    public class GetAvgRentPriceForWeeklyQueryHandler : IRequestHandler<GetAvgRentPriceForWeeklyQuery, GetAvgPriceForWeeklyQueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetAvgRentPriceForWeeklyQueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgPriceForWeeklyQueryResult> Handle(GetAvgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForWeekly();
            return new GetAvgPriceForWeeklyQueryResult
            {
                AvgPriceForWeekly = value,

            };
        }
    }
}
