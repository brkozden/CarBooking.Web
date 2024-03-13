using CarBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Interfaces.CarDescriptionInterfaces
{
    public interface ICarDescriptionRepository
    {
        CarDescription GetCarDescription(int carId);
    }
}
