using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(CarColor entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CarColor entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CarColor Get(Expression<Func<CarColor, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<CarColor>().SingleOrDefault(filter);
            }
        }

        public List<CarColor> GetAll(Expression<Func<CarColor, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ?
                    context.Set<CarColor>().ToList() :
                    context.Set<CarColor>().Where(filter).ToList();
            }
        }

        public void Update(CarColor entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
