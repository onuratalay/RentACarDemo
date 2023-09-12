using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class PersonnelDal:IRepository<Personnel>
    {
        public List<Personnel> GetAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Personnels.ToList();
            }
        }

        public void Add(Personnel personnel)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(personnel);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Personnel personnel)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(personnel);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Personnel personnel)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(personnel);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
