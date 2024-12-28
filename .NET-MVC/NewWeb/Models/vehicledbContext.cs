using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewWeb.Models
{
    public partial class vehicledbContext : DbContext
    {
        public vehicledbContext()
        {
        }

        public vehicledbContext(DbContextOptions<vehicledbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bonu> Bonus { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Dept10> Dept10s { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Emp10> Emp10s { get; set; }
        public virtual DbSet<Emp100> Emp100s { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product1> Products1 { get; set; }
        public virtual DbSet<ProductsDetail> ProductsDetails { get; set; }
        public virtual DbSet<Salesman> Salesmen { get; set; }
        public virtual DbSet<Salesman1> Salesman1s { get; set; }
        public virtual DbSet<Salgrade> Salgrades { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=shreya;database=vehicledb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.2.0-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Bonu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bonus");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("category");

                entity.HasIndex(e => e.Cname, "cname")
                    .IsUnique();

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("cname");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer");

                entity.Property(e => e.Cname)
                    .HasMaxLength(20)
                    .HasColumnName("cname");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dept");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Dname)
                    .HasMaxLength(14)
                    .HasColumnName("DNAME");

                entity.Property(e => e.Loc)
                    .HasMaxLength(13)
                    .HasColumnName("LOC");
            });

            modelBuilder.Entity<Dept10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dept10");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Dname)
                    .HasMaxLength(14)
                    .HasColumnName("DNAME");

                entity.Property(e => e.Loc)
                    .HasMaxLength(13)
                    .HasColumnName("LOC");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp");

                entity.Property(e => e.Comm)
                    .HasPrecision(7, 2)
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Empno).HasColumnName("EMPNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<Emp10>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PRIMARY");

                entity.ToTable("emp10");

                entity.HasIndex(e => e.Deptno, "DEPTNO_idx");

                entity.Property(e => e.Empno)
                    .ValueGeneratedNever()
                    .HasColumnName("EMPNO");

                entity.Property(e => e.Comm)
                    .HasPrecision(7, 2)
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<Emp100>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PRIMARY");

                entity.ToTable("emp100");

                entity.Property(e => e.Empno)
                    .ValueGeneratedNever()
                    .HasColumnName("EMPNO");

                entity.Property(e => e.Comm)
                    .HasPrecision(7, 2)
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ename).HasMaxLength(45);

                entity.Property(e => e.Job).HasMaxLength(45);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.HasIndex(e => e.Cid, "fk_cid");

                entity.HasIndex(e => e.Sid, "fk_sid");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .HasColumnName("pname");

                entity.Property(e => e.Price)
                    .HasColumnType("float(6,2)")
                    .HasColumnName("price")
                    .HasDefaultValueSql("'20.00'");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_cid");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("fk_sid");
            });

            modelBuilder.Entity<Product1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("products");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(15)
                    .HasColumnName("pname");

                entity.Property(e => e.Price)
                    .HasPrecision(5, 2)
                    .HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<ProductsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("products_details");

                entity.Property(e => e.Amt)
                    .HasPrecision(5, 2)
                    .HasColumnName("amt");

                entity.Property(e => e.Pid).HasColumnName("pid");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("salesman");

                entity.Property(e => e.City)
                    .HasMaxLength(10)
                    .HasColumnName("city");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<Salesman1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("salesman1");

                entity.HasIndex(e => e.Sname, "sname")
                    .IsUnique();

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("sid");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasColumnName("city");

                entity.Property(e => e.CreditLimit).HasColumnName("credit_limit");

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<Salgrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("salgrade");

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.Hisal).HasColumnName("HISAL");

                entity.Property(e => e.Losal).HasColumnName("LOSAL");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vehicle");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .HasColumnName("details");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Milage).HasColumnName("milage");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Vid).HasColumnName("vid");

                entity.Property(e => e.Vname)
                    .HasMaxLength(15)
                    .HasColumnName("vname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
