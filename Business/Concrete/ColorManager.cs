using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(CarColor color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(CarColor color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<CarColor>> GetAll()
        {
            return new SuccessDataResult<List<CarColor>>(_colorDal.GetAll());
        }

        public IDataResult<CarColor> GetById(int id)
        {
            return new SuccessDataResult<CarColor>(_colorDal.Get(c => c.Id == id));

        }

        public IResult Update(CarColor color)
        {
             _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
