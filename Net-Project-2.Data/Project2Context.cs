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
    }
}
