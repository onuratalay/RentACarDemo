using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class CarDal:IRepository<Car>
    {
        public List<Car> GetAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.ToList();
            }
        }

        public void Add(Car car)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(car);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Car car)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(car);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(car);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
