namespace ClassLibrary3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Surname = c.String(nullable: false, maxLength: 25),
                        Address = c.String(maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 13),
                        CustomerTypesId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerTypes", t => t.CustomerTypesId, cascadeDelete: true)
                .Index(t => t.CustomerTypesId);
            
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false),
                        TypeCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DiscountTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Type = c.String(nullable: false, maxLength: 35),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsRatePercentage = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceNumber = c.String(nullable: false, maxLength: 25),
                        OrderTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HasDiscountApplied = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        OrderCode = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderCode, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.OrderCode);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderCode = c.Int(nullable: false),
                        ProductCount = c.Int(nullable: false),
                        OrderTotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductsId, cascadeDelete: true)
                .Index(t => t.ProductsId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DerivedProductCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "UserId", "dbo.Customers");
            DropForeignKey("dbo.Invoices", "OrderCode", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ProductsId", "dbo.Products");
            DropForeignKey("dbo.Customers", "CustomerTypesId", "dbo.CustomerTypes");
            DropIndex("dbo.Orders", new[] { "ProductsId" });
            DropIndex("dbo.Invoices", new[] { "OrderCode" });
            DropIndex("dbo.Invoices", new[] { "UserId" });
            DropIndex("dbo.Customers", new[] { "CustomerTypesId" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Invoices");
            DropTable("dbo.DiscountTypes");
            DropTable("dbo.CustomerTypes");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
