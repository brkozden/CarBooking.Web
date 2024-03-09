using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Dtos.StatisticsDtos
{
    public class ResultStatisticDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }

        public int AuthorCount { get; set; }

        public int BlogCount { get; set; }

        public int BrandCount { get; set; }

        public decimal AvgPriceForDaily { get; set; }
        public decimal AvgPriceForWeekly { get; set; }
        public decimal AvgPriceForMonthly { get; set; }

        public int CarCountByTransmissionIsAuto { get; set; }

        public string BrandNameByMostCar { get; set; }

        public int CarCountByKmLessThan30000 { get; set; }

        public int CarCountByFuelGasolineOrDiesel { get; set; }

        public int CarCountByFuelElectric { get; set; }

        public  string CarBrandAndModelByRentPriceDailyMin { get; set; }
        public string carBrandAndModelByRentPriceDailyMax { get; set; }

        public string BlogTitleByMostBlogComment { get; set; }





    }
}
