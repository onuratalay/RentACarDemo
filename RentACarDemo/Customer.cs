using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public decimal Budget { get; set; }
        public decimal Depozit { get; set; }
        public int BranchId { get; set; }
    }
}
