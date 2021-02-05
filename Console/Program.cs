using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            

            //carManager.Add(new Entities.Concrete.Car { Id = 5, BrandId = 1, ColorId = 1, DailyPrice =2 , Description = "Deneme" });

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                System.Console.WriteLine("İd:"+car.Id + car.ModelYear+ "\tGünlük Fiyatı:" + car.DailyPrice+ "\tAraba İsmi:" + car.Description);
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
