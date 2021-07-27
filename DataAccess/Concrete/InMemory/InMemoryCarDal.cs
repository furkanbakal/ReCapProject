using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ColorId=5, BrandId=1, DailyPrice=65000, Description="1.8 SEDAN", Id=1, ModelYear=2020},
                new Car{ColorId=5, BrandId=1, DailyPrice=160000, Description="1.6 DIZEL", Id=2, ModelYear=2020},
                new Car{ColorId=6, BrandId=2, DailyPrice=95000, Description="1.4 HACKPACK", Id=3, ModelYear=2015},
                new Car{ColorId=6, BrandId=2, DailyPrice=120000, Description="1.2 TSI", Id=4, ModelYear=2010},
                new Car{ColorId=6, BrandId=3, DailyPrice=100000, Description="1.8 SEDAN", Id=5, ModelYear=2016}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

       

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
