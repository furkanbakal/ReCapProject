using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.ModelYear);
            }

            carManager.Add(new Car { BrandId=2, ColorId=4, DailyPrice=200, Description="deneme model", ModelYear=2014 });
        }
    }
}
