using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace firstWebAPI.Models.EF;

public partial class EmployeeDbContext : DbContext
{
    public EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employeedetail> Employeedetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:corecluster-training.database.windows.net,1433;Initial Catalog=employeeDB;Persist Security Info=False;User ID=trainer;Password=Password@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employeedetail>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__employee__AFB335924DEA0F8F");

            entity.ToTable("employeedetails");

            entity.Property(e => e.EmpNo)
                .ValueGeneratedNever()
                .HasColumnName("empNo");
            entity.Property(e => e.EmpDesigantion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empDesigantion");
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
