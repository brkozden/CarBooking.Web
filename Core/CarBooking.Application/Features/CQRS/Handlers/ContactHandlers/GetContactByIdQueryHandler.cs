using CarBooking.Application.Features.CQRS.Queries.ContactQueries;
using CarBooking.Application.Features.CQRS.Results.ContactResults;
using CarBooking.Application.Interfaces;
using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.ContactId);
            return new GetContactByIdQueryResult
            {
                ContactId = query.ContactId,
                Name = values.Name,
                Email = values.Email,
                Subject = values.Subject,
                Message = values.Message,
                SendDate = values.SendDate,


            };
        }
    }
}
