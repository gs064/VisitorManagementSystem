using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VisitorManagementSystem.Models;

namespace VisitorManagementSystem.Data
{
    public class VisitorDbContext : DbContext
    {
      
        

            // Here we add in all the tables we are using.
            public DbSet<StaffNames> StaffNames { get; set; }
            public DbSet<Visitors> Visitor { get; set; }
            // We need 2 constructors, one is empty, and the other injects in DbContextOptions
            public VisitorDbContext(DbContextOptions<VisitorDbContext> options)
            : base(options)
            {
            }
            public VisitorDbContext()
            {
            }
        }
    }




