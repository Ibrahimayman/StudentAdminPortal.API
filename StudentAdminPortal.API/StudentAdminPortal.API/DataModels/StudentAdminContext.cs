using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext : DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Address> Address { get; set; }
    }
}
