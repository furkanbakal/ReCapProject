using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        public IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(CarColor color)
        {
            _colorDal.Add(color);
        }

        public void Delete(CarColor color)
        {
            _colorDal.Delete(color);
        }

        public List<CarColor> GetAll()
        {
            return _colorDal.GetAll();
        }

        public CarColor GetById(int id)
        {
            return _colorDal.Get(c => c.Id == id);

        }

        public void Update(CarColor color)
        {
             _colorDal.Update(color);
        }
    }
}
