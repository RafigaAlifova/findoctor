using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class findoctorContext : DbContext
    {
        public DbSet<Doctor> Cars { get; set; }
        public DbSet<Patient> Employees { get; set; }
        public DbSet<Comment> ParkingSpaces { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = (localdb)\MSSQLLocalDB; Database = CarDB; Trusted_connection = true");
        }
       
    }

}
