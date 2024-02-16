namespace OOO_AnimalShop.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Articul = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Init = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxDiscount = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        CategoryType = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        CountInPack = c.Int(nullable: false),
                        Description = c.String(),
                        ImagePreview = c.String(),
                    })
                .PrimaryKey(t => t.Articul)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ManufacturerId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductTypesArticul = c.String(maxLength: 128),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypesArticul)
                .Index(t => t.ProductTypesArticul);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Nomer = c.Int(nullable: false, identity: true),
                        DateOrder = c.DateTimeOffset(nullable: false, precision: 7),
                        DateSupplier = c.DateTimeOffset(nullable: false, precision: 7),
                        PunktVidachiId = c.Int(nullable: false),
                        FIOClient = c.String(),
                        Code = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Nomer)
                .ForeignKey("dbo.PunktVidachis", t => t.PunktVidachiId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.PunktVidachiId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.PunktVidachis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Index = c.String(nullable: false),
                        City = c.String(),
                        Street = c.String(),
                        Nomer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Patronimyc = c.String(),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RoleType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Order_Nomer = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Nomer, t.Product_Id })
                .ForeignKey("dbo.Orders", t => t.Order_Nomer, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Order_Nomer)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTypes", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "ProductTypesArticul", "dbo.ProductTypes");
            DropForeignKey("dbo.Orders", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Orders", "PunktVidachiId", "dbo.PunktVidachis");
            DropForeignKey("dbo.OrderProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "Order_Nomer", "dbo.Orders");
            DropForeignKey("dbo.ProductTypes", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.OrderProducts", new[] { "Product_Id" });
            DropIndex("dbo.OrderProducts", new[] { "Order_Nomer" });
            DropIndex("dbo.Orders", new[] { "StatusId" });
            DropIndex("dbo.Orders", new[] { "PunktVidachiId" });
            DropIndex("dbo.Products", new[] { "ProductTypesArticul" });
            DropIndex("dbo.ProductTypes", new[] { "SupplierId" });
            DropIndex("dbo.ProductTypes", new[] { "ManufacturerId" });
            DropTable("dbo.OrderProducts");
            DropTable("dbo.Users");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Status");
            DropTable("dbo.PunktVidachis");
            DropTable("dbo.Orders");
            DropTable("dbo.Products");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Manufacturers");
        }
    }
}
