using System;
using Microsoft.EntityFrameworkCore;

namespace Net_Project_2.Data
{
    public class Project2Context : DbContext
    {
        // DbSets for our classes go here

        public Project2Context(DbContextOptions options) : base(options) { }
    }
}
