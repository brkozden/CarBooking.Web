using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Commands.FeatureCommands
{
    public class RemoveFeatureCommand:IRequest
    {
        public int FeatureId { get; set; }

        public RemoveFeatureCommand(int featureId)
        {
            FeatureId = featureId;
        }
    }
}
