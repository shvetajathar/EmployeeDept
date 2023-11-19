using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace dotnetapp.Models;

public class ApplicationDbContext:DbContext
{
    public virtual DbSet<Department> Departments{get;set;}
    public virtual DbSet<Employee> Employees{get;set;}
    public ApplicationDbContext(){}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=RideShareDB;trusted_connection=false;Persist Security Info=False;Encrypt=False;");

        }
    }
    

}