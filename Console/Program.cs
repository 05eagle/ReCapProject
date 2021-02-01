using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("Model:"+car.ModelYear+"\tBilgi:"+car.Description);
            }
        }
    }
}
