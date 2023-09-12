using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class Personnel:IEntity
    {
        public int PersonnelId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public decimal Salary { get; set; }
        public int BranchId { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
    }
}
