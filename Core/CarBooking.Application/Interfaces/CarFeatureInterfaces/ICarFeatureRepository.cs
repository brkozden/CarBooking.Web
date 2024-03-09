using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarId(int carId);

        void ChangeCarFeatureAvailableToFalse(int id);

        void ChangeCarFeatureAvailableToTrue(int id);

    }
}
