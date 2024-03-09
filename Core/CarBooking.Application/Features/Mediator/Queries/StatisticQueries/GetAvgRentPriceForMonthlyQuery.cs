using CarBooking.Application.Features.Mediator.Results.StatisticResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Features.Mediator.Queries.StatisticQueries
{
    public class GetAvgRentPriceForMonthlyQuery:IRequest<GetAvgPriceForMonthlyQueryResult>
    {
    }
}
