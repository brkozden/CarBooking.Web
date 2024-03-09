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
    public class GetAvgRentPriceForDailyQueryHandler : IRequestHandler<GetAvgRentPriceForDailyQuery, GetAvgPriceForDailyQueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetAvgRentPriceForDailyQueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgPriceForDailyQueryResult> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForDaily();
            return new GetAvgPriceForDailyQueryResult
            {
                AvgPriceForDaily = value,

            };
        }
    }
}
