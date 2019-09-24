using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCRUD.Admin
{
	public partial class ViewSuppliers1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void SupplierListView_ItemInserting(object sender, ListViewInsertEventArgs e)
        {
            // this fires just before the ListView calls the ObjectDataSource control to do an insert.
            ; // no-op 
        }

        protected void SupplierListView_ItemInserted(object sender, ListViewInsertedEventArgs e)
        {
            // this event is fired after after the ObjectDataSource has returned from performing and insert
            ;
        }

        protected void SuppliersDataSource_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
        {
            ; // before calling the BLL
        }

        protected void SuppliersDataSource_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
        {
            ; // after the call to the BLL
            if(e.Exception != null)
            {
                Exception inner = e.Exception;
                while (inner.InnerException != null)
                    inner = inner.InnerException;
                string message = $"Problem inserting: {inner.GetType().Name }<blockquote>{ inner.Message }</blockquote>";

                if(inner is DbEntityValidationException)
                {
                    // as => safe type-cast 
                    var actual = inner as DbEntityValidationException;
                    message += "<ul>";
                    foreach(var detail in actual.EntityValidationErrors)
                    {
                        message += $"<li>{detail.Entry.Entity.GetType().Name}";
                        message += "<ol>";
                        foreach (var error in detail.ValidationErrors)
                        {
                            message += $"<li>{error.ErrorMessage}</li>";
                        }
                        message += "</ol></li>";
                    }
                }

                MessageLabel.Text = message;
                e.ExceptionHandled = true;
            }
        }
    }
}