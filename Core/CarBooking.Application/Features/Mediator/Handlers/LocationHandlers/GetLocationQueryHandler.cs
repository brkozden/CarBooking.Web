﻿using CarBooking.Application.Features.Mediator.Queries.LocationQueries;
using CarBooking.Application.Features.Mediator.Results.FeatureResults;
using CarBooking.Application.Features.Mediator.Results.LocationResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    { private readonly IRepository<Location> _repository;

        public GetAuthorQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult
            {
                LocationId = x.LocationId,
                Name = x.Name

            }).ToList();
        }
    }
}
