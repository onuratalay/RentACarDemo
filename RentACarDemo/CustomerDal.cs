using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class CustomerDal:IRepository<Customer>
    {
        public List<Customer> GetAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Customers.ToList();
            }
        }

        public void Add(Customer customer)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Customer customer)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
