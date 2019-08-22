namespace ProductsManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductsManagement.Models.ProductsManagementContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductsManagement.Models.ProductsManagementContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(p => p.p_id,
                new Models.Products { p_name="phone",p_cate="tecnology",p_prize=1000},
                new Models.Products { p_name = "pc", p_cate = "tecnology", p_prize = 3333 },
                new Models.Products { p_name = "desk", p_cate = "home appliances", p_prize = 222 }




                );

        }
    }
}
