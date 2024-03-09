using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.ContactCommands
{
    public class RemoveContactCommand
    {
        public int ContactId { get; set; }

        public RemoveContactCommand(int contactId)
        {
            ContactId = contactId;
        }
    }
}
