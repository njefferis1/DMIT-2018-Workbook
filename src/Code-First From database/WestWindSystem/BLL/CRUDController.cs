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
        #endregion

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Supplier> listSuppliers()
        {
            using(var context = new WestWindContext())
            {
                return context.Suppliers.Include(nameof(Supplier.Address)).ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void AddSupplier(Supplier item)
        {
            using (var context = new WestWindContext())
            {
                context.Suppliers.Add(item);
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void UpdateSupplier(Supplier item)
        {
            using (var context = new WestWindContext())
            {
                var existing = context.Entry(item);
                existing.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void DeleteSupplier(Supplier item)
        {
            using(var context = new WestWindContext())
            {
                var existing = context.Suppliers.Find(item.SupplierID);
                context.Suppliers.Remove(existing);
                context.SaveChanges();
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
        
    }
}
