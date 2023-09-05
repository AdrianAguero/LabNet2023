using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Data
{
    public class DaoCategories : DaoBase<Categories>
    {
        public DaoCategories()
        {

        }

        public DaoCategories(NorthwindContext context)
        {
            _context = context;
        }


    }
}
