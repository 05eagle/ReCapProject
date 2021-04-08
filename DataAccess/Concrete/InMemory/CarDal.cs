using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class CarDal : ICarDal
    {
        List<Car> cars;
        public CarDal()
        {
            cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=500,ModelYear=2005,Description="Kullanışlı"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=600,ModelYear=2006,Description="Kullanışlı"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=700,ModelYear=2007,Description="Kullanışlı"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=800,ModelYear=2008,Description="Kullanışlı"},
            };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public List<CarDetailDto> CarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> CarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carDelete;
            carDelete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return cars.Where(c => c.Id == Id).ToList();
        }

      

        public void Update(Car car)
        {
            Car carUpdate;
            carUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.Description = car.Description;
        }
    }
}
