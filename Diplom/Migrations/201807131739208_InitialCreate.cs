namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        CartItemId = c.Int(nullable: false, identity: true),
                        ProductQuantityt = c.Int(nullable: false),
                        CartProduct_ProductId = c.Int(),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.CartItemId)
                .ForeignKey("dbo.Products", t => t.CartProduct_ProductId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.CartProduct_ProductId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductAmountOnStore = c.Int(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductImage = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductPictures",
                c => new
                    {
                        ProductPictureId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProductPictureUrl = c.String(),
                    })
                .PrimaryKey(t => t.ProductPictureId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        ShoppingCartId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ShoppingCartId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerLastName = c.String(),
                        CustomerMiddleNname = c.String(),
                        CustomerPhoneNumber = c.String(),
                        CustomerEmail = c.String(),
                        CustomerPassword = c.String(),
                        CustomerAddress = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        OrderPrice = c.Double(nullable: false),
                        CustomerId_CustomerId = c.Int(),
                        ManagerId_ManagerId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId)
                .ForeignKey("dbo.Managers", t => t.ManagerId_ManagerId)
                .Index(t => t.CustomerId_CustomerId)
                .Index(t => t.ManagerId_ManagerId);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerId = c.Int(nullable: false, identity: true),
                        ManagerName = c.String(),
                        ManagerLastName = c.String(),
                        ManagerMiddleNname = c.String(),
                        ManagerPhoneNumber = c.String(),
                        ManagerEmail = c.String(),
                        ManagerPassword = c.String(),
                    })
                .PrimaryKey(t => t.ManagerId);
            
            CreateTable(
                "dbo.StorePositions",
                c => new
                    {
                        StorePositionId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        AmountOfProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StorePositionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ManagerId_ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Orders", "CustomerId_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CartItems", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.CartItems", "CartProduct_ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductPictures", "ProductId", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "ManagerId_ManagerId" });
            DropIndex("dbo.Orders", new[] { "CustomerId_CustomerId" });
            DropIndex("dbo.ProductPictures", new[] { "ProductId" });
            DropIndex("dbo.CartItems", new[] { "Order_OrderId" });
            DropIndex("dbo.CartItems", new[] { "CartProduct_ProductId" });
            DropTable("dbo.StorePositions");
            DropTable("dbo.Managers");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.ProductPictures");
            DropTable("dbo.Products");
            DropTable("dbo.CartItems");
        }
    }
}
