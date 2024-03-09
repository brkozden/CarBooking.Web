using CarBooking.Application.Features.Mediator.Queries.ServiceQueries;
using CarBooking.Application.Features.Mediator.Results.PricingResults;
using CarBooking.Application.Features.Mediator.Results.ServicesResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                ServiceId = x.ServiceId,
                Description = x.Description,
                IconUrl = x.IconUrl,
                Title = x.Title

            }).ToList();
        }
    }
}
