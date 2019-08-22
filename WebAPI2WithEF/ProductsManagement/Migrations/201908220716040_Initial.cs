namespace ProductsManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        p_id = c.Int(nullable: false, identity: true),
                        p_cate = c.String(),
                        p_prize = c.Int(nullable: false),
                        p_name = c.String(),
                    })
                .PrimaryKey(t => t.p_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
