using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2)
            {
                if (car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                    Console.WriteLine("{0} Açıklamalı aracınız, {1} lira fiyatı ile eklenmiştir", car.Description, car.DailyPrice);
                }
                else
                {
                    Console.WriteLine("HATA! Aracın günlük fiyatı 0'dan büyük olmalı");
                }
            }
            else
            {
                Console.WriteLine("HATA! Araç açıklaması minimum 2 karakter olmalıdır!");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
