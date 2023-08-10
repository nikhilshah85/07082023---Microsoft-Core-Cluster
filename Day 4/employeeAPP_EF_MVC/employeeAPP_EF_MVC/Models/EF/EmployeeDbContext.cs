using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace employeeAPP_EF_MVC.Models.EF;

public partial class EmployeeDbContext : DbContext
{
    public EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=employeeDB;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__employee__AFB33592164C08D6");

            entity.ToTable("employeeInfo");

            entity.Property(e => e.EmpNo)
                .ValueGeneratedNever()
                .HasColumnName("empNo");
            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empDesignation");
            entity.Property(e => e.EmpIsPermenant).HasColumnName("empIsPermenant");
            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empName");
            entity.Property(e => e.EmpSalary).HasColumnName("empSalary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
