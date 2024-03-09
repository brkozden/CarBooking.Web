﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Dtos.CarDtos
{
    public class ResultLast5CarsWithBrandDto
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }
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
