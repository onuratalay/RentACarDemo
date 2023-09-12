using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class RentDal:IRepository<Rent>
    {
        public List<Rent> GetAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Rents.ToList();
            }
        }

        public void Add(Rent rent)
        {
            using (RentACarContext context = new RentACarContext() )
            {
                var entity = context.Entry(rent);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Rent rent)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(rent);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Rent rent)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(rent);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
