using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

// http://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx

namespace WebApp.Admin.Security
{
    /// <summary>
    /// Provide functionality for setting up the database for the ApplicationDbContext.
    /// The specific functionality is to create the database if it does not exist
    /// </summary>
    public class SecurityDbContextInitilizer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            // To "seed" a database is to prvide it with some initial data when the daabase is created

            #region Seed the security roles
            // Make the Identity's BLL instance to hep us manage roles
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            // The RoleManager<T> and RoleStore<T> are BLL classes that give flexability to the design/structure of how were using Asp.Net identity.
            // The IdentityRole is an Entity class that represents a security role

            // TODO: move these hard-coded security roles to Web.Config
            rolemanager.Create(new IdentityRole { Name = "Administrators" });
            rolemanager.Create(new IdentityRole { Name = "Registered Users" });
            #endregion

            #region Seed the users
            #endregion

            // Note: Keep this call to the base class so it can do is seeding work
            base.Seed(context);
        }
    }
}