namespace OpenQbit.Institute.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prototype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batch",
                c => new
                    {
                        BatchId = c.Int(nullable: false, identity: true),
                        BatchName = c.String(),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BatchId)
                .ForeignKey("dbo.Branch", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                        Address = c.String(),
                        TelNo = c.Int(nullable: false),
                        InstituteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BranchId)
                .ForeignKey("dbo.Institute", t => t.InstituteId, cascadeDelete: true)
                .Index(t => t.InstituteId);
            
            CreateTable(
                "dbo.Institute",
                c => new
                    {
                        InstituteId = c.Int(nullable: false, identity: true),
                        InstituteName = c.String(),
                        WebSite = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.InstituteId);
            
            CreateTable(
                "dbo.BatchEnrolment",
                c => new
                    {
                        BatchEnrolmentId = c.Int(nullable: false, identity: true),
                        TimeDuration = c.Int(nullable: false),
                        BatchId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BatchEnrolmentId)
                .ForeignKey("dbo.Batch", t => t.BatchId, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.BatchId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Nic = c.String(),
                        TelNo = c.Int(nullable: false),
                        ParentInformationId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.ParentInformation", t => t.ParentInformationId, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.ParentInformationId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.ParentInformation",
                c => new
                    {
                        ParentInformationId = c.Int(nullable: false, identity: true),
                        MotherId = c.Int(nullable: false),
                        FatherId = c.Int(nullable: false),
                        PrimaryContactNumber = c.Int(nullable: false),
                        Father_PersonId = c.Int(),
                        Mother_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.ParentInformationId)
                .ForeignKey("dbo.Person", t => t.Father_PersonId)
                .ForeignKey("dbo.Person", t => t.Mother_PersonId)
                .Index(t => t.Father_PersonId)
                .Index(t => t.Mother_PersonId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Tel = c.Int(nullable: false),
                        ResourceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Resource", t => t.ResourceID, cascadeDelete: true)
                .Index(t => t.ResourceID);
            
            CreateTable(
                "dbo.Resource",
                c => new
                    {
                        ResourceID = c.Int(nullable: false, identity: true),
                        GlobalID = c.Int(nullable: false),
                        ResourceType = c.String(),
                    })
                .PrimaryKey(t => t.ResourceID);
            
            CreateTable(
                "dbo.BranchResourceAllocation",
                c => new
                    {
                        BranchResourceAllocationId = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        ResourceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BranchResourceAllocationId)
                .ForeignKey("dbo.Branch", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Resource", t => t.ResourceId, cascadeDelete: true)
                .Index(t => t.BranchId)
                .Index(t => t.ResourceId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeType = c.String(),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Person", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Lecture",
                c => new
                    {
                        LectureID = c.Int(nullable: false, identity: true),
                        LectureName = c.String(),
                        Telephone = c.Int(nullable: false),
                        Email = c.String(),
                        Address = c.String(),
                        Specify = c.String(),
                        SubjectID = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LectureID)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        StaffName = c.String(),
                        Address = c.String(),
                        Telephone = c.Int(nullable: false),
                        Category = c.String(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.SubjectEnrolment",
                c => new
                    {
                        SubjectEnrolmentId = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectEnrolmentId)
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectEnrolment", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.SubjectEnrolment", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Staff", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Lecture", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Lecture", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "PersonID", "dbo.Person");
            DropForeignKey("dbo.BranchResourceAllocation", "ResourceId", "dbo.Resource");
            DropForeignKey("dbo.BranchResourceAllocation", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.BatchEnrolment", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Student", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Student", "ParentInformationId", "dbo.ParentInformation");
            DropForeignKey("dbo.ParentInformation", "Mother_PersonId", "dbo.Person");
            DropForeignKey("dbo.ParentInformation", "Father_PersonId", "dbo.Person");
            DropForeignKey("dbo.Person", "ResourceID", "dbo.Resource");
            DropForeignKey("dbo.BatchEnrolment", "BatchId", "dbo.Batch");
            DropForeignKey("dbo.Batch", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Branch", "InstituteId", "dbo.Institute");
            DropIndex("dbo.SubjectEnrolment", new[] { "StudentId" });
            DropIndex("dbo.SubjectEnrolment", new[] { "SubjectId" });
            DropIndex("dbo.Staff", new[] { "EmployeeId" });
            DropIndex("dbo.Lecture", new[] { "EmployeeId" });
            DropIndex("dbo.Lecture", new[] { "SubjectID" });
            DropIndex("dbo.Employee", new[] { "PersonID" });
            DropIndex("dbo.BranchResourceAllocation", new[] { "ResourceId" });
            DropIndex("dbo.BranchResourceAllocation", new[] { "BranchId" });
            DropIndex("dbo.Person", new[] { "ResourceID" });
            DropIndex("dbo.ParentInformation", new[] { "Mother_PersonId" });
            DropIndex("dbo.ParentInformation", new[] { "Father_PersonId" });
            DropIndex("dbo.Student", new[] { "PersonId" });
            DropIndex("dbo.Student", new[] { "ParentInformationId" });
            DropIndex("dbo.BatchEnrolment", new[] { "StudentId" });
            DropIndex("dbo.BatchEnrolment", new[] { "BatchId" });
            DropIndex("dbo.Branch", new[] { "InstituteId" });
            DropIndex("dbo.Batch", new[] { "BranchId" });
            DropTable("dbo.SubjectEnrolment");
            DropTable("dbo.Staff");
            DropTable("dbo.Subject");
            DropTable("dbo.Lecture");
            DropTable("dbo.Employee");
            DropTable("dbo.BranchResourceAllocation");
            DropTable("dbo.Resource");
            DropTable("dbo.Person");
            DropTable("dbo.ParentInformation");
            DropTable("dbo.Student");
            DropTable("dbo.BatchEnrolment");
            DropTable("dbo.Institute");
            DropTable("dbo.Branch");
            DropTable("dbo.Batch");
        }
    }
}
