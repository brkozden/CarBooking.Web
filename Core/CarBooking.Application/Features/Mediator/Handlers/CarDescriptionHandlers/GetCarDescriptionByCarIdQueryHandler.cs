using CarBooking.Application.Features.Mediator.Handlers.PricingHandlers;
using CarBooking.Application.Features.Mediator.Queries.CarDescriptionQueries;
using CarBooking.Application.Features.Mediator.Queries.PricingQueries;
using CarBooking.Application.Features.Mediator.Results.CarDescriptionResults;
using CarBooking.Application.Interfaces.CarDescriptionInterfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{

    public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionByCarIdQueryResult>
    {
        private readonly ICarDescriptionRepository _repository;

        public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDescriptionByCarIdQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetCarDescription(request.Id);
            return new GetCarDescriptionByCarIdQueryResult
            {
                CarId = values.CarId,
                Details = values.Details,
                CarDescriptionId = values.CarDescriptionId,
            };
        }
    }
}




