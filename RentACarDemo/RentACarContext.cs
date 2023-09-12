using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class RentACarContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}
