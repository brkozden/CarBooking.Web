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
    public class GetBrandNameByMostCarQueryHandler : IRequestHandler<GetBrandNameByMostCarQuery, GetBrandNameByMostCarQueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetBrandNameByMostCarQueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandNameByMostCarQueryResult> Handle(GetBrandNameByMostCarQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandNameByMostCar();
            return new GetBrandNameByMostCarQueryResult
            {
                BrandNameByMostCar = value,

            };
        }
    }
}
