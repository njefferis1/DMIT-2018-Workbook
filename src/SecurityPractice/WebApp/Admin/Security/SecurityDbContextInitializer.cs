using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PracticeSystem.BAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Admin.Security
{
    public class SecurityDbContextInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region seed security roles
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            rolemanager.Create(new IdentityRole { Name = "Administrators" });
            rolemanager.Create(new IdentityRole { Name = "Registered users" });
            #endregion

            #region seed users
            var adminUser = new ApplicationUser
            {
                UserName = "WebAdmin",
                Email = "Elections2020@Hackers.ru",
                EmailConfirmed = true
            };

            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var result = userManager.Create(adminUser, "Pa$$w0rd");
            if (result.Succeeded)
            {
                var adminId = userManager.FindByName("WebAdmin").Id;
                userManager.AddToRole(adminId, "Administrators");
            }

            var demoManager = new StaffController();
            var staff = demoManager.ListStaff();
            foreach(var employee in staff)
            {
                var user = new ApplicationUser
                {
                    //UserName = $"{staff.FirstName}.{staff.LastName}" <- this is where i am yeet
                }
            }

            #endregion


            base.Seed(context);
        }
    }
}