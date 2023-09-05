using Linq.Data;
using Linq.Entities;
using Linq.Logic.Interface;
using System;
using System.Collections.Generic;

namespace Linq.Logic.Logic
{
    public class CustomerLogic : ICustomer
    {
        DaoCustomer daoCus = new DaoCustomer();
        public List<Customers> GetAllCustomers()
        {
            List<Customers> lstCustomers = new List<Customers>(daoCus.GetAllCustomers());
            return lstCustomers;
        }

        public List<Customers> GetCustomersNamesSintax()
        {
            var lstCustomersNames = daoCus.GetCustomersNamesSintax();
            return lstCustomersNames;
        }

        public IQueryable<Customers> GetCustomersRegionWAMethod()
        {
            var lstCustomers = daoCus.GetCustomersRegionWAMethod();
            return lstCustomers;
        }
        public List<Customers> GetTop3CustomersWARegion()
        {
            var lstCustomers = daoCus.GetTop3CustomersWARegion();
            return lstCustomers;
        }

    }
}
