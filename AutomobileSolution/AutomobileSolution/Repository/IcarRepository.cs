using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface IcarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);
        
    }
}
