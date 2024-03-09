using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {


        public int CategoryId { get; set; }

        public RemoveCategoryCommand(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
