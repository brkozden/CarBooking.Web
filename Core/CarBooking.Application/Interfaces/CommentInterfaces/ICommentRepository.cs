using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Interfaces.CommentInterfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetCommentsByBlogId(int id);

        int GetCountCommentByBlog(int id);
    }
}
