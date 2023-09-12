﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDemo
{
    public class Branch:IEntity
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal Endorsement { get; set; }
    }
}
