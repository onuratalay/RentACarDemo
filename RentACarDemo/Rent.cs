using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class Rent:IEntity
    {
        public int RentId { get; set; }
        public int BranchId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentalDate { get; set; }
        public int RentalPeriod { get; set; }
    }
}
