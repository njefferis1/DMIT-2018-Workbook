using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    [DataObject] // for the <ObjectDataSource> control
    public class CRUDController
    {
        #region Products CRUD
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Product> ListProducts()
        {
            using (var context = new WestWindContext())
            {
                return context.Products.ToList();

                // list supliers, categories, addresses
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Supplier> listSuppliers()
        {
            using(var context = new WestWindContext())
            {
                return context.Suppliers.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Category> listCategories()
        {
            using (var context = new WestWindContext())
            {
                return context.Categories.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Address> listAddresses()
        {
            using (var context = new WestWindContext())
            {
                return context.Addresses.ToList();
            }
        }
        #endregion
    }
}
