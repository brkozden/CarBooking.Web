using CarBooking.Application.Features.Mediator.Queries.RentACarQueries;
using CarBooking.Application.Features.Mediator.Results.LocationResults;
using CarBooking.Application.Features.Mediator.Results.RentACarResults;
using CarBooking.Application.Interfaces.RentACarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationId == request.LocationId && x.Available == true);
            var results = values.Select(x => new GetRentACarQueryResult
            {
               CarId = x.CarId,
               BrandName = x.Car.Brand.Name,
               Model = x.Car.Model,
               CoverImageUrl = x.Car.CoverImageUrl,
               
               

            }).ToList();
            return results;
        }
    }
}
