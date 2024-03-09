
using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.CarCommands
{
    public class CreateCarCommand
    {
      

        public int BrandId { get; set; }

        public string Model { get; set; }

        public int Km { get; set; }

        public string Transmission { get; set; }

        public byte Seat { get; set; }

        public decimal LuggageCapacity { get; set; }

        public string Fuel { get; set; }

        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }

    }
}
