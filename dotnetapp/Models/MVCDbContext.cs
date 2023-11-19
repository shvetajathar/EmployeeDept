using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace dotnetapp.Models;

public class MVCDbContext:DbContext
{
    public virtual DbSet<Dept> Depts{get;set;}
    public virtual DbSet<Employee> Employees{get;set;}
    public MVCDbContext(){}
    public MVCDbContext(DbContextOptions<MVCDbContext> options):base(options){}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=MVCDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");

        }
    }
    

}