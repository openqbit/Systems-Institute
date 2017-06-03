namespace OpenQbit.Institute.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class institute : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batch",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        BranchId = c.Int(nullable: false),
                        Branch_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .Index(t => t.Branch_Id);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Address = c.String(),
                        TelNo = c.Int(nullable: false),
                        InstituteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institut", t => t.InstituteId, cascadeDelete: true)
                .Index(t => t.InstituteId);
            
            CreateTable(
                "dbo.Institut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WebSite = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BatchEnrolment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentLimit = c.Int(nullable: false),
                        TimeDuration = c.Int(nullable: false),
                        BatchId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Batch_Id = c.String(maxLength: 128),
                        Student_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Batch", t => t.Batch_Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Batch_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.BranchResourceAllocation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        ResourceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
                    })
                .PrimaryKey(t => t.LectureID)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParentInformation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MotherId = c.Int(nullable: false),
                        FatherId = c.Int(nullable: false),
                        PrimaryContactNumber = c.Int(nullable: false),
                        Father_PersonId = c.Int(),
                        Mother_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Father_PersonId)
                .ForeignKey("dbo.Person", t => t.Mother_PersonId)
                .Index(t => t.Father_PersonId)
                .Index(t => t.Mother_PersonId);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Telephone = c.Int(nullable: false),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.StaffID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Nic = c.String(),
                        TelNo = c.Int(nullable: false),
                        ParentInformationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParentInformation", t => t.ParentInformationId, cascadeDelete: true)
                .Index(t => t.ParentInformationId);
            
            CreateTable(
                "dbo.SubjectEnrolment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Student_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .ForeignKey("dbo.Subject", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectEnrolment", "SubjectId", "dbo.Subject");
            DropForeignKey("dbo.SubjectEnrolment", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.Student", "ParentInformationId", "dbo.ParentInformation");
            DropForeignKey("dbo.BatchEnrolment", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.ParentInformation", "Mother_PersonId", "dbo.Person");
            DropForeignKey("dbo.ParentInformation", "Father_PersonId", "dbo.Person");
            DropForeignKey("dbo.Lecture", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Employee", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Person", "ResourceID", "dbo.Resource");
            DropForeignKey("dbo.BatchEnrolment", "Batch_Id", "dbo.Batch");
            DropForeignKey("dbo.Batch", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Branch", "InstituteId", "dbo.Institut");
            DropIndex("dbo.SubjectEnrolment", new[] { "Student_Id" });
            DropIndex("dbo.SubjectEnrolment", new[] { "SubjectId" });
            DropIndex("dbo.Student", new[] { "ParentInformationId" });
            DropIndex("dbo.ParentInformation", new[] { "Mother_PersonId" });
            DropIndex("dbo.ParentInformation", new[] { "Father_PersonId" });
            DropIndex("dbo.Lecture", new[] { "SubjectID" });
            DropIndex("dbo.Person", new[] { "ResourceID" });
            DropIndex("dbo.Employee", new[] { "PersonID" });
            DropIndex("dbo.BatchEnrolment", new[] { "Student_Id" });
            DropIndex("dbo.BatchEnrolment", new[] { "Batch_Id" });
            DropIndex("dbo.Branch", new[] { "InstituteId" });
            DropIndex("dbo.Batch", new[] { "Branch_Id" });
            DropTable("dbo.SubjectEnrolment");
            DropTable("dbo.Student");
            DropTable("dbo.Staff");
            DropTable("dbo.ParentInformation");
            DropTable("dbo.Subject");
            DropTable("dbo.Lecture");
            DropTable("dbo.Resource");
            DropTable("dbo.Person");
            DropTable("dbo.Employee");
            DropTable("dbo.BranchResourceAllocation");
            DropTable("dbo.BatchEnrolment");
            DropTable("dbo.Institut");
            DropTable("dbo.Branch");
            DropTable("dbo.Batch");
        }
    }
}
