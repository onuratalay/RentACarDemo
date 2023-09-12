using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class BranchDal:IRepository<Branch>
    {
        public List<Branch> GetAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Branches.ToList();
            }
        }

        public void Add(Branch branch)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(branch);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Branch branch)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(branch);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Branch branch)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(branch);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
