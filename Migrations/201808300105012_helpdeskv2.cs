namespace Helpdesk_CodeFirstv2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class helpdeskv2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category_Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DepartmentCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Department_Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HolidayCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Dates = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RoleCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SubCategoryCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubCategory_Name = c.String(),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CategoryCls", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.TicketCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Dtm_Crt = c.DateTime(nullable: false),
                        L1 = c.String(),
                        DueDateType = c.DateTime(nullable: false),
                        Last_update = c.DateTime(nullable: false),
                        OnProgressDate = c.DateTime(nullable: false),
                        OnWaitingDate = c.DateTime(nullable: false),
                        OnHoldDate = c.DateTime(nullable: false),
                        ResolvedTime = c.DateTime(nullable: false),
                        ClosedTime = c.DateTime(nullable: false),
                        Technician = c.String(),
                        Status = c.String(),
                        TypeID = c.String(),
                        UserID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        SubCategoryID = c.Int(nullable: false),
                        Type_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CategoryCls", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.SubCategoryCls", t => t.SubCategoryID, cascadeDelete: true)
                .ForeignKey("dbo.TypeCls", t => t.Type_ID)
                .ForeignKey("dbo.UserCls", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.CategoryID)
                .Index(t => t.SubCategoryID)
                .Index(t => t.Type_ID);
            
            CreateTable(
                "dbo.TypeCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Interval = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        RoleID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DepartmentCls", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.RoleCls", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TicketCls", "UserID", "dbo.UserCls");
            DropForeignKey("dbo.UserCls", "RoleID", "dbo.RoleCls");
            DropForeignKey("dbo.UserCls", "DepartmentID", "dbo.DepartmentCls");
            DropForeignKey("dbo.TicketCls", "Type_ID", "dbo.TypeCls");
            DropForeignKey("dbo.TicketCls", "SubCategoryID", "dbo.SubCategoryCls");
            DropForeignKey("dbo.TicketCls", "CategoryID", "dbo.CategoryCls");
            DropForeignKey("dbo.SubCategoryCls", "Category_ID", "dbo.CategoryCls");
            DropIndex("dbo.UserCls", new[] { "DepartmentID" });
            DropIndex("dbo.UserCls", new[] { "RoleID" });
            DropIndex("dbo.TicketCls", new[] { "Type_ID" });
            DropIndex("dbo.TicketCls", new[] { "SubCategoryID" });
            DropIndex("dbo.TicketCls", new[] { "CategoryID" });
            DropIndex("dbo.TicketCls", new[] { "UserID" });
            DropIndex("dbo.SubCategoryCls", new[] { "Category_ID" });
            DropTable("dbo.UserCls");
            DropTable("dbo.TypeCls");
            DropTable("dbo.TicketCls");
            DropTable("dbo.SubCategoryCls");
            DropTable("dbo.RoleCls");
            DropTable("dbo.HolidayCls");
            DropTable("dbo.DepartmentCls");
            DropTable("dbo.CategoryCls");
        }
    }
}
