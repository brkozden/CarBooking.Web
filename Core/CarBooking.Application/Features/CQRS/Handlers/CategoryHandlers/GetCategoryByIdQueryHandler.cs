using CarBooking.Application.Features.CQRS.Queries.CategoryQueries;
using CarBooking.Application.Features.CQRS.Results.CategoryResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
               CategoryId = values.CategoryId,
                Name = values.Name


            };
        }
    }
}
