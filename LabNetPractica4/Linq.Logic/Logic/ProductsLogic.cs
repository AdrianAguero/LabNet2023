using Linq.Data;
using Linq.Entities;
using Linq.Logic.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Logic.Logic
{
    public class ProductsLogic : IProducts, IBaseLogic<Products>
    { 
     DaoProduct daoProd = new DaoProduct();
    public List<Products> GetAll()
    {
        List<Products> lstProd = daoProd.GetAll();
        return lstProd;
    }

    public Products GetFirst(List<Products> lst)
    {
        Products p = daoProd.GetFirst(lst);
        return p;
    }

    public Products GetFirstOrNull(int id)
    {
        Products prod = daoProd.GetFirstOrNull(id);
        return prod;
    }

    public List<Products> GetOrderProductsList()
    {
        List<Products> lstProducts = daoProd.GetOrderProductsList();
        return lstProducts;
    }

    public List<Products> GetOrderProductsListByStock()
    {
        List<Products> lstProducts = daoProd.GetOrderProductsListByStock();
        return lstProducts;
    }

    public IQueryable<Products> GetProductsWhitoutStockMethod()
    {
        IQueryable<Products> entity = daoProd.GetProductsWhitoutStockMethod();
        return entity;

    }

    public IQueryable<Products> GetProductsWhitoutStockSintax()
    {
        IQueryable<Products> entity = daoProd.GetProductsWhitoutStockSintax();
        return entity;
    }

    public IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Method()
    {
        IQueryable<Products> entity = daoProd.GetProductsWhitStockUnitPriceGreaterThan3Method();
        return entity;
    }

    public IQueryable<Products> GetProductsWhitStockUnitPriceGreaterThan3Sintax()
    {

        IQueryable<Products> entity = daoProd.GetProductsWhitStockUnitPriceGreaterThan3Sintax();
        return entity;
    }
}
}
