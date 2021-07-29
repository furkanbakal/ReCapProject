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

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User{FirstName="Feyza", LastName="Bakal", EMail="feyza.bakal@gmail.com", Password="12334"});



            // CarManager carManager = GetCar();

            //carManager.Add(new Car { BrandId = 2, ColorId = 4, DailyPrice = 200, Description = "deneme model", ModelYear = 2014 });

            //CarDtoDeneme();

            //BrandDeneme();

            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetail();

            //foreach (var car in result.Data)
            //{
            //    Console.WriteLine(car.BrandName+"============="+car.ColorName);
            //}

        }
    }
}
