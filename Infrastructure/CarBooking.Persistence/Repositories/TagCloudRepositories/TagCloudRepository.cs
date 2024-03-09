using CarBooking.Application.Interfaces.TagCloudInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookingContext _context;

        public TagCloudRepository(CarBookingContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudByBlogId(int id)
        {
            var values = _context.TagClouds.Where(x=>x.BlogId ==id).ToList();
            return values;
        }
    }
}
