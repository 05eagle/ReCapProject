using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "Opel" });
            //colorManager.Add(new Color { ColorId = 2, ColorName = "Mavi" });
            //carManager.Add(new Entities.Concrete.Car { Id = 8, BrandId = 1,ModelYear=2000, ColorId = 1, DailyPrice = 2, Description = "Deneme" });
            //carManager.Add(new Entities.Concrete.Car { Id = 8, BrandId = 1,ModelYear=2000, ColorId = 1, DailyPrice = 2, Description = "Deneme" });

            //carManager.Add(new Car { Id = 9, BrandId = 2, ModelYear = 2001, ColorId = 1, DailyPrice = 2, Description = "deneme2" });

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} marka  / {1} renk  / Günlük Fiyatı {2}", car.BrandName,car.ColorName,car.DailyPrice);
            }
            
            
        }
    }
}
