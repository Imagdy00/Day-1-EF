﻿using Demo.Configrations;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class appDbContext : DbContext
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    #region MyRegion
        //    ////modelBuilder.Entity<Employee>().HasKey("EmpId");
        //    //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
        //    //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

        //    //modelBuilder.Entity<Employee>()
        //    //    .Property(E => E.Name)
        //    //    .IsRequired().HasColumnType("varchar")
        //    //    .HasMaxLength(50)
        //    //    .HasColumnName("EmployeeName");



        //    //modelBuilder.Entity<Employee>().Property(E => E.Age).IsRequired(false);


        //    //modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("money");
        //    ////modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);
        //    //modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");

        //    //    modelBuilder.Entity<Employee>(E =>
        //    //    {
        //    //        //modelBuilder.Entity<Employee>().HasKey("EmpId");
        //    //        E.HasKey(nameof(Employee.EmpId));
        //    //        E.HasKey(E => E.EmpId);

        //    //        E
        //    //            .Property(E => E.Name)
        //    //            .IsRequired().HasColumnType("varchar")
        //    //            .HasMaxLength(50)
        //    //            .HasColumnName("EmployeeName");



        //    //        E.Property(E => E.Age).IsRequired(false);


        //    //        E.Property(E => E.Salary).HasColumnType("money");
        //    //        //modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);
        //    //        E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
        //    //    });

        //    //    base.OnModelCreating(modelBuilder);
        //    //} 
        //    #endregion

        //    modelBuilder.ApplyConfiguration(new EmployeeConfigration());
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = . ; Database = AppG03 ; Trusted_Connection = True ; TrustServerCertificate = True");
        //}
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }
    }
}
