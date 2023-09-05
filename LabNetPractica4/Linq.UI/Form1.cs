using Linq.Data;
using Linq.Entities;
using Linq.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Linq.UI
{
 public partial class Form1 : Form 
    {   
  DaoProduct daoproduct= new DaoProduct();
  DaoCustomer daoCustomer = new DaoCustomer();
  CustomerLogic costumerLogic = new CustomerLogic();
  ProductsLogic productLogic = new ProductsLogic();
  public Form1()
  {
      InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
      cmbOpciones.SelectedIndex = 0;

  }

  private void btnOption_Click(object sender, EventArgs e)
  {

   int option = cmbOpciones.SelectedIndex + 1;

   switch (option)
   {
     case 1:
         try
         {
             lstGenerica.Items.Clear();
             lblMostrar.Text = "Objeto customer.";

             lstGenerica.Items.Add(
                 $"{daoCustomer.GetCustomerSintax().ContactName} | {daoCustomer.GetCustomerSintax().Country}");

         }
         catch (Exception ex)
         { 
             MessageBox.Show("Error en la Opción 1: " + ex.Message);
         }
         break;

     case 2:
         try
         {
             lstGenerica.Items.Clear();
             LlenarProductos("Productos sin stock", 
                              productLogic.GetProductsWhitoutStockMethod().ToList());
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 2: " + ex.Message);
         }
         break;
     case 3:
         try
         {
             lstGenerica.Items.Clear();
             LlenarProductos("Productos que tienen stock y que cuestan más de 3 por unidad",
                              productLogic.GetProductsWhitStockUnitPriceGreaterThan3Method().ToList());
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 3: " + ex.Message);
         }
         break;
     case 4:
         try
         {
             lstGenerica.Items.Clear();
             LlenarCustomers("Todos los customers de la region WA", 
                              costumerLogic.GetCustomersRegionWAMethod().ToList());
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 4: " + ex.Message);
         }
         break;
     case 5:                   
         try
         {
             lstGenerica.Items.Clear();
             lblMostrar.Text = "primer elemento o nulo de una lista de productos donde el ID de\n" +
                 " producto sea igual a 789";

             if (productLogic.GetFirstOrNull(789) == null)
             {
                 MessageBox.Show("Objeto nulo");
             }
             else
             {
                 lstGenerica.Items.Add($" ID:{productLogic.GetFirstOrNull(789).ProductID.ToString()}" +
                                       $"Nombre: {productLogic.GetFirstOrNull(789).ProductName}");
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 5: " + ex.Message);
         }
         break;

     case 6:
         try
         {
             lstGenerica.Items.Clear();
             lblMostrar.Text = "Nombres de clienets en Mayusculas y minusculas";
             foreach (var item in daoCustomer.GetUpperAndLower())
             {
                 lstGenerica.Items.Add(item);
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 6: " + ex.Message);
         }
         break;
     case 7:
         try
         {
             lstGenerica.Items.Clear();
             lblMostrar.Text = "Clientes con region WA con ordenes mayores a 1/1/1997";
             foreach (var item in daoCustomer.CustomerXOrder())
             {
                 lstGenerica.Items.Add($"{item.cliente} , Region: {item.region}, Fecha Orden: {item.fechaOrden}");
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 7: " + ex.Message);
         }
         break;
     case 8:
         try
         {

             lstGenerica.Items.Clear();
             LlenarCustomers("Primeros 3 clientes con region WA", costumerLogic.GetTop3CustomersWARegion());

             
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 8: " + ex.Message);
         }
         break;
     case 9:
         try
         {

             lstGenerica.Items.Clear();
             LlenarProductos("Productos ordenados por nombre", productLogic.GetOrderProductsList());

         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 9: " + ex.Message);
         }
         break;
     case 10:
         try
         {
             lstGenerica.Items.Clear();
             LlenarProductos("Productos ordenados por stock", productLogic.GetOrderProductsListByStock());
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 10: " + ex.Message);
         }
         break;
     case 11:
         try
         {
             lstGenerica.Items.Clear();
             lblMostrar.Text = "Productos joineados a categorias";

             foreach (var item in daoproduct.GetCategories())
             {
                 lstGenerica.Items.Add($"ID: {item.id} , Producto: {item.producto} , Categoria: {item.categoria}");
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 11: " + ex.Message);
         }
         break;
     case 12:
         List<Products> lstAll = productLogic.GetAll();
         try
         {
             Products p = productLogic.GetFirst(lstAll);

             List<Products> lstFirts = new List<Products>();
             lstFirts.Add(p);

             lstGenerica.Items.Add(lstFirts);
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en la Opción 12: " + ex.Message);
         }
         break;
     default:
           break;
   }
   }



  private void LlenarProductos(string textolbl, List<Products> lproductos)
  {
      lstGenerica.Items.Clear();
      lblMostrar.Text = textolbl;
      foreach (var item in lproductos)
      {
          lstGenerica.Items.Add($"{item.ProductName} , Precio: {item.UnitPrice} " +
              $", Stock: {item.UnitsInStock}");
      }
  }
  private void LlenarCustomers(string textolbl, List<Customers> lcustomers)
  {
      lstGenerica.Items.Clear();
      lblMostrar.Text = textolbl;
      foreach (var item in lcustomers)
      {
          lstGenerica.Items.Add($"ID: {item.CustomerID} Nombre: {item.ContactName}, Region: {item.Region}");
      }
  }
 }
}

