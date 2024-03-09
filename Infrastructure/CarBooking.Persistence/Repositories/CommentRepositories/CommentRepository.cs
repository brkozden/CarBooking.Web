using CarBooking.Application.Interfaces.CommentInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly CarBookingContext _context;

        public CommentRepository(CarBookingContext context)
        {
            _context = context;
        }
        public List<Comment> GetCommentsByBlogId(int id)
        {
            var values = _context.Comments.Where(x => x.BlogId == id).ToList();
            return values;
        }

        public int GetCountCommentByBlog(int id)
        {
            return _context.Comments.Where(x => x.BlogId == id).Count();
             
        }
    }
}
