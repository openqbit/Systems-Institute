namespace OpenQbit.Institute.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "PersonId", c => c.Int(nullable: false));
            AddColumn("dbo.Lecture", "EmployeeId", c => c.Int(nullable: false));
            AddColumn("dbo.Staff", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Student", "PersonId");
            CreateIndex("dbo.BranchResourceAllocation", "BranchId");
            CreateIndex("dbo.BranchResourceAllocation", "ResourceId");
            CreateIndex("dbo.Lecture", "EmployeeId");
            CreateIndex("dbo.Staff", "EmployeeId");
            AddForeignKey("dbo.Student", "PersonId", "dbo.Person", "PersonId", cascadeDelete: true);
            AddForeignKey("dbo.BranchResourceAllocation", "BranchId", "dbo.Branch", "BranchId", cascadeDelete: true);
            AddForeignKey("dbo.BranchResourceAllocation", "ResourceId", "dbo.Resource", "ResourceID", cascadeDelete: true);
            AddForeignKey("dbo.Lecture", "EmployeeId", "dbo.Employee", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.Staff", "EmployeeId", "dbo.Employee", "EmployeeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staff", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Lecture", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.BranchResourceAllocation", "ResourceId", "dbo.Resource");
            DropForeignKey("dbo.BranchResourceAllocation", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Student", "PersonId", "dbo.Person");
            DropIndex("dbo.Staff", new[] { "EmployeeId" });
            DropIndex("dbo.Lecture", new[] { "EmployeeId" });
            DropIndex("dbo.BranchResourceAllocation", new[] { "ResourceId" });
            DropIndex("dbo.BranchResourceAllocation", new[] { "BranchId" });
            DropIndex("dbo.Student", new[] { "PersonId" });
            DropColumn("dbo.Staff", "EmployeeId");
            DropColumn("dbo.Lecture", "EmployeeId");
            DropColumn("dbo.Student", "PersonId");
        }
    }
}
