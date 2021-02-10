using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car GetCarId(int id);

        List<CarDetailDto> GetCarDetails();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
