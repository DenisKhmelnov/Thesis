namespace Diplom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveManager : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "ManagerId_ManagerId", "dbo.Managers");
            DropIndex("dbo.Orders", new[] { "ManagerId_ManagerId" });
            DropColumn("dbo.Orders", "ManagerId_ManagerId");
            DropTable("dbo.Managers");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.Orders", "ManagerId_ManagerId", c => c.Int());
            CreateIndex("dbo.Orders", "ManagerId_ManagerId");
            AddForeignKey("dbo.Orders", "ManagerId_ManagerId", "dbo.Managers", "ManagerId");
        }
    }
}
