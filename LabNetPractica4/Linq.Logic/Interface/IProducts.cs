using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Logic.Interface
{
    public interface IProducts
    {
        IQueryable<Products> GetProductsWhitoutStockMethod();
        IQueryable<Products> GetProductsWhitoutStockSintax();
        IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Method();
        IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Sintax();
        Products GetFirstOrNull(int id);
        List<Products> GetOrderProductsList();
        List<Products> GetOrderProductsListByStock();
       // List<Categories> GetCategories();
        Products GetFirst(List<Products> lst);

    }
}
