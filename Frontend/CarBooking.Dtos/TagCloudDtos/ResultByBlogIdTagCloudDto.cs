﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Dtos.TagCloudDtos
{
    public class ResultByBlogIdTagCloudDto
    {
        public int TagCloudId { get; set; }
        public string Title { get; set; }

        public int BlogId { get; set; }
    }
}
