using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Interfaces.StatisticInterfaces
{
    public interface IStatisticRepository
    {
        int GetCarCount();
        int GetLocationCount();
        int GetAuthorCount();

        int GetBlogCount();
        int GetBrandCount();

        
        decimal GetAvgRentPriceForDaily();

        decimal GetAvgRentPriceForWeekly();
        decimal GetAvgRentPriceForMonthly();
        int GetCarCountByTransmissionIsAuto();
        string GetBrandNameByMostCar();

        string GetBlogTitleByMostBlogComment(); 

        int GetCarCountByKmLessThan30000();

        int GetCarCountByFuelGasolineOrDiesel();

        int GetCarCountByFuelElectric();

        string GetCarBrandAndModelByRentPriceDailyMax();
        string GetCarBrandAndModelByRentPriceDailyMin();


    }
}
