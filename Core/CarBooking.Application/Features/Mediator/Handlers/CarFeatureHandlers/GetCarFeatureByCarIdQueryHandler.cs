using CarBooking.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBooking.Application.Features.Mediator.Results.CarFeatureResults;
using CarBooking.Application.Interfaces;
using CarBooking.Application.Interfaces.CarFeatureInterfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery,List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly ICarFeatureRepository _repository;

        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetCarFeaturesByCarId(request.Id);
            return values.Select(x => new GetCarFeatureByCarIdQueryResult
            {
                Available = x.Available,
                CarFeatureId = x.CarFeatureId,
                FeatureId = x.FeatureId,
                CarId = x.CarId,
                FeatureName = x.Feature.Name


            }).ToList();
        }
    }
}
