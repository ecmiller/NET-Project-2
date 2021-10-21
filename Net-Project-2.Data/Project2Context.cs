using System;
using Microsoft.EntityFrameworkCore;
using NET_Project_2.Domain;

namespace Net_Project_2.Data
{
    public class Project2Context : DbContext
    {
        // DbSets for our classes go here
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        public Project2Context(DbContextOptions options) : base(options) { }


        //Fluent API - we may need this later
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           
            
            modelBuilder.Entity<User>()
                        .HasMany(u => u.Plan)
                        .WithMany(p => p.Users)
                        .UsingEntity<UserPlan>(up => up.HasOne<Plan>().WithMany(),
                                                 up => up.HasOne<User>().WithMany())
                        .Property(up => up.CreatedAt)
                        .HasDefaultValue(1);

        }*/
    }


}
