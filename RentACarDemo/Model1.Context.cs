﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarDemo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RentACarEntities : DbContext
    {
        public RentACarEntities()
            : base("name=RentACarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetCarsWithBranchName_Result> GetCarsWithBranchName(Nullable<int> branchId)
        {
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("BranchId", branchId) :
                new ObjectParameter("BranchId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCarsWithBranchName_Result>("GetCarsWithBranchName", branchIdParameter);
        }
    
        public virtual ObjectResult<GetPersonnelsWithBranchName_Result> GetPersonnelsWithBranchName(Nullable<int> branchId)
        {
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("BranchId", branchId) :
                new ObjectParameter("BranchId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPersonnelsWithBranchName_Result>("GetPersonnelsWithBranchName", branchIdParameter);
        }
    
        public virtual ObjectResult<GetCustomers_Result> GetCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomers_Result>("GetCustomers");
        }
    
        public virtual ObjectResult<GetNonRentalCars_Result> GetNonRentalCars(Nullable<int> branchId)
        {
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("BranchId", branchId) :
                new ObjectParameter("BranchId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetNonRentalCars_Result>("GetNonRentalCars", branchIdParameter);
        }
    
        public virtual int UpdateRentId(Nullable<int> rentId)
        {
            var rentIdParameter = rentId.HasValue ?
                new ObjectParameter("RentId", rentId) :
                new ObjectParameter("RentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateRentId", rentIdParameter);
        }
    
        public virtual ObjectResult<GetRentalCars_Result> GetRentalCars(Nullable<int> branchId)
        {
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("BranchId", branchId) :
                new ObjectParameter("BranchId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRentalCars_Result>("GetRentalCars", branchIdParameter);
        }
    }
}
