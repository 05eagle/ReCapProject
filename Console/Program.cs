using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            //carManager.Add(new Entities.Concrete.Car { Id = 8, BrandId = 1,ModelYear=2000, ColorId = 1, DailyPrice = 2, Description = "Deneme" });

            carManager.Delete(new Car { Id = 8, BrandId = 2, ModelYear = 2001, ColorId = 1, DailyPrice = 2, Description = "deneme2" });

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("İd:"+car.Id + "\t" + "Model"+ car.ModelYear+ "\tGünlük Fiyatı:" + car.DailyPrice+ "\tAraba Açıklaması:" + car.Description);
            }
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                System.Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                System.Console.WriteLine(car.Description);
            }
            
        }
    }
}
