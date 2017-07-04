using OpenQbit.Institute.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OpenQbit.Institute.DAL.DataAccess
{
  

    public class InstituteDbContext : DbContext
    {


        public InstituteDbContext() : base("Institute")
        {
        }


        public DbSet<Batch> Batch { get; set; }
        public DbSet<BatchEnrolment> BatchEnrolment{ get; set; }
        public DbSet<Branch> Branch{ get; set; }
        public DbSet<BranchResourceAllocation> BranchResourceAllocation { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Common.Models.Institute> Institute { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<ParentInformation> ParentInformation { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student{ get; set; }
        public DbSet<Subject> Subject{ get; set; }
        public DbSet<SubjectEnrolment> SubjectEnrolment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<OpenQbit.Institute.Common.Models.Resource> Resources { get; set; }
    }
}
