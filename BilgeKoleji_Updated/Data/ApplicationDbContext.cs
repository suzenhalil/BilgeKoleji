using BilgeKoleji_Updated.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using System;

namespace BilgeKoleji_Updated.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ders> Derslers { get; set; } 
    
        public DbSet<Student> Students { get; set; }
       public DbSet<Teacher> Teachers { get; set; }

        
    }
}   