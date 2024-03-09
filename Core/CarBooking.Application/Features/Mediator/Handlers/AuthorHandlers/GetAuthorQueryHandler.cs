﻿using CarBooking.Application.Features.Mediator.Queries.AuthorQueries;
using CarBooking.Application.Features.Mediator.Results.AuthorResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;

        public GetBlogQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
              AuthorId = x.AuthorId,
              Description = x.Description,
              ImageUrl = x.ImageUrl,
              Name = x.Name

            }).ToList();
        }
    }
}
