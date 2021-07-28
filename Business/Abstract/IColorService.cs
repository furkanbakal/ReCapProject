using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<CarColor> GetAll();
        CarColor GetById(int id);
        void Add(CarColor color);
        void Update(CarColor color);
        void Delete(CarColor color);
    }
}
