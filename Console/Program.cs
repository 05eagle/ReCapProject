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

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //brandManager.Add(new Brand { BrandId = 2, BrandName = "Opel" });
            //colorManager.Add(new Color { ColorId = 2, ColorName = "Mavi" });
            //carManager.Add(new Entities.Concrete.Car { Id = 8, BrandId = 1,ModelYear=2000, ColorId = 1, DailyPrice = 2, Description = "Deneme" });
            //carManager.Add(new Entities.Concrete.Car { Id = 8, BrandId = 1,ModelYear=2000, ColorId = 1, DailyPrice = 2, Description = "Deneme" });

            //carManager.Add(new Car { Id = 12, BrandId = 2, ModelYear = 2001, ColorId = 1, DailyPrice = 2, Description = "deneme2" });


            //CustomerAdd(customerManager);

            RentAdd(rentalManager);

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("{0} Numaralı Aracın Tarih Bilgileri..", rental.CarId);
                Console.WriteLine("Kiralama tarihi:" + rental.RentDate + "\t" + "Teslim Tarihi:" + rental.ReturnDate);
            }

            //foreach (var car in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine("{0} marka  / {1} renk  / Günlük Fiyatı {2}", car.BrandName, car.ColorName, car.DailyPrice);
            //}


        }

        private static void RentAdd(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental { Id = 2, CarId = 2, CustomerId = 1, RentDate = new DateTime(2020, 02, 13),ReturnDate=null});

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);

            }
        }

        private static void CustomerAdd(CustomerManager customerManager)
        {
            var result = customerManager.Add(new Customer { UserId = 1, CompanyName = "Kartal" });

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
