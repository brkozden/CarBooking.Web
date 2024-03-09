using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Queries.ContactQueries
{
    public class GetContactByIdQuery
    {
        public int ContactId { get; set; }

        public GetContactByIdQuery(int contactId)
        {
            ContactId = contactId;
        }
    }
}
