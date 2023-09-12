using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public decimal Price { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public int StockAmount { get; set; }
        public string Gear { get; set; }
        public int BranchId { get; set; }
        public int RentId { get; set; }
    }
}
