using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Dtos.CarDescriptionDtos
{
	public class ResultCarDescriptionDto
	{
		public int CarDescriptionId { get; set; }

		public int CarId { get; set; }

		public string Details { get; set; }
	}
}
