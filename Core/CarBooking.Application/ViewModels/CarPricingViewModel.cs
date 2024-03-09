﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.ViewModels
{
	public class CarPricingViewModel
	{
        public CarPricingViewModel()
        {
            Amounts = new List<decimal>();
        }
        public string Model { get; set; }

        public List<decimal> Amounts { get; set; }
		public string CoverImageUrl { get; set; }
		public string Brand { get; set; }
	}
}
