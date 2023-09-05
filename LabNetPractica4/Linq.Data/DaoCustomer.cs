using Linq.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Data
{
    public class DaoCustomer: DaoBase<Customers>
    {
        public DaoCustomer(NorthwindContext context)
        {
            _context = context;
        }

        public DaoCustomer()
        {
        }

        NorthwindContext db = new NorthwindContext();

        public Customers GetCustomerSintax()
        {
            var queryCustomer = db.Customers.FirstOrDefault();
            return queryCustomer;
        }
   

        public List<Customers> GetCustomerMethod(string idCustomer)
        {

            var queryCustomer = db.Customers.Select(e => e).Where(e => e.CustomerID == idCustomer).ToList();

            return queryCustomer;
        }

        public List<Customers> GetAllCustomers()
        {
            var queryCustomer = db.Customers.Select(e => e).ToList();

            return queryCustomer;
        }

        public IQueryable<Customers> GetCustomersRegionWASintax()
        {
            var queryCustomer = from cust in db.Customers
                                where cust.Region == "WA"
                                select cust;

            return queryCustomer;

        }

        public IQueryable<Customers> GetCustomersRegionWAMethod()
        {
            var queryCustomer = db.Customers.Select(e => e).Where(e => e.Region == "WA");

            return queryCustomer;
        }

        public List<Customers> GetCustomersNamesSintax()
        {

            var queryCustomer = from cust in db.Customers
                                select cust.CompanyName;

            List<Customers> lstCustomersNames = new List<Customers>();

            foreach (var item in queryCustomer)
            {
                Customers c = new Customers();
                c.CompanyName = item;
                lstCustomersNames.Add(c);
            }

            return lstCustomersNames;
        }
        public List<string> GetUpperAndLower()
        {
            return _context.Customers.Select(c => c.ContactName.ToUpper())
                .Concat(_context.Customers.Select(c2 => c2.ContactName.ToLower())).ToList();
        }

        public List<CoustomersDataTrans> CustomerXOrder()
        {
            return (from Customers in _context.Customers
                    join Orders in _context.Orders
                    on Customers.CustomerID equals Orders.CustomerID

                    where Customers.Region == "WA" && Orders.OrderDate.Value.Year >= 1997
                    select new CoustomersDataTrans
                    {
                        cliente = Customers.ContactName,
                        region = Customers.Region,
                        fechaOrden = Orders.OrderDate.Value
                    }).ToList();

        }

        public List<Customers> GetTop3CustomersWARegion()
        {

            var queryCustomer = db.Customers.Select(e => e).Where(e => e.Region == "WA").Take(3).ToList();
            return queryCustomer;
        }

    }
}
