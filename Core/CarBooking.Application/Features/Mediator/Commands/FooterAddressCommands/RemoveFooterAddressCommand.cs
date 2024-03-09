using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class RemoveFooterAddressCommand:IRequest
    {
        public int FooterAddressId { get; set; }

        public RemoveFooterAddressCommand(int footerAddressId)
        {
            FooterAddressId = footerAddressId;
        }
    }
}
