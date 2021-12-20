namespace Section2_IPG521.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Section2_IPG521.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Section2_IPG521.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Section2_IPG521.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);

            IdentityRole adminRole = new IdentityRole { Name = "Admin" };

            IdentityRole authorRole = new IdentityRole { Name = "Author" };

            if (!roleManager.RoleExists(adminRole.Name))
            {
                roleManager.Create(adminRole);
            }
            if (!roleManager.RoleExists(authorRole.Name))
            {
                roleManager.Create(authorRole);
            }

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            ApplicationUser adminUser = new ApplicationUser
            {
                UserName = "admin@sacla.co.za",
                Email = "admin@sacla.co.za"
            };

            var results = userManager.Create(adminUser, "admin123!");
            if (results.Succeeded)
            {
                userManager.AddToRole(adminUser.Id, adminRole.Name);
            }
            base.Seed(context);
        }
    }
}
