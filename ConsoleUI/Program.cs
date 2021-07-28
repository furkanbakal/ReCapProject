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
            // CarManager carManager = GetCar();

            //carManager.Add(new Car { BrandId = 2, ColorId = 4, DailyPrice = 200, Description = "deneme model", ModelYear = 2014 });

            //CarDtoDeneme();

            BrandManager brandManager = new BrandManager(new EfBrandDal());
           // brandManager.Add(new Brand { Name = "DenemeMarka" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
            
        }

        private static void CarDtoDeneme()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.CarName + " ======== " + car.BrandName + " ========= " + car.ColorName);
            }
        }

        private static CarManager GetCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.ModelYear);
            }

            return carManager;
        }
    }
}
