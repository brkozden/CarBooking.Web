﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryByIdQueryResult
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}