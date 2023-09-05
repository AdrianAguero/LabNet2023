using Linq.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Logic.Interface
{
    public interface ICustomer
    {
        List<Customers> GetAllCustomers();
        IQueryable<Customers> GetCustomersRegionWAMethod();
        List<Customers> GetCustomersNamesSintax();
        List<Customers> GetTop3CustomersWARegion();
       

    }
}
