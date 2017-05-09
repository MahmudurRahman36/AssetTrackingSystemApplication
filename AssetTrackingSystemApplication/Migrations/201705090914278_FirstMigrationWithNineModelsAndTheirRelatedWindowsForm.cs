namespace AssetTrackingSystemApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrationWithNineModelsAndTheirRelatedWindowsForm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        Name = c.String(),
                        ShortName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: false)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Name = c.String(),
                        ShortName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneralCategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GeneralCategories", t => t.GeneralCategoryId, cascadeDelete: false)
                .Index(t => t.GeneralCategoryId);
            
            CreateTable(
                "dbo.GeneralCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subcategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneralCategoryId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: false)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.DetailCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GeneralCategoryId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        SubcategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subcategories", t => t.SubcategoryId, cascadeDelete: false)
                .Index(t => t.SubcategoryId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: false)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        Name = c.String(),
                        Designation = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.DetailCategories", "SubcategoryId", "dbo.Subcategories");
            DropForeignKey("dbo.Subcategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "GeneralCategoryId", "dbo.GeneralCategories");
            DropForeignKey("dbo.Branches", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Assets", "BranchId", "dbo.Branches");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "BranchId" });
            DropIndex("dbo.DetailCategories", new[] { "SubcategoryId" });
            DropIndex("dbo.Subcategories", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "GeneralCategoryId" });
            DropIndex("dbo.Branches", new[] { "OrganizationId" });
            DropIndex("dbo.Assets", new[] { "BranchId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.DetailCategories");
            DropTable("dbo.Subcategories");
            DropTable("dbo.GeneralCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Organizations");
            DropTable("dbo.Branches");
            DropTable("dbo.Assets");
        }
    }
}
