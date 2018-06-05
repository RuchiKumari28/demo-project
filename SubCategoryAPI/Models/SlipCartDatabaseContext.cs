using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SubCategoryAPI.Models
{
    public partial class SlipCartDatabaseContext : DbContext
    {

        public SlipCartDatabaseContext(DbContextOptions<SlipCartDatabaseContext> options)

 : base(options)

        {

        }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CustInvoice> CustInvoice { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Distributor> Distributor { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Leaves> Leaves { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Ordered> Ordered { get; set; }
        public virtual DbSet<ProcessOrder> ProcessOrder { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierProduct> SupplierProduct { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrder { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=LAP-L859\SQLEXPRESS;Initial Catalog=SlipCartDatabase;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CatCode).HasMaxLength(20);

                entity.Property(e => e.CatName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.CustInvoice)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .HasConstraintName("FK__CustInvoi__Order__3D2915A8");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CustInvoice)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__CustInvoi__Order__3C34F16F");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserCorrspndnceAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmailId)
                    .HasColumnName("UserEmailID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserGender).HasColumnType("char(1)");

                entity.Property(e => e.UserLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UserPermnntAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Distributor>(entity =>
            {
                entity.HasKey(e => e.DistId);

                entity.Property(e => e.DistId).HasColumnName("DistID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DistAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DistEmailId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistPassword).HasMaxLength(16);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.Property(e => e.InventoryId)
                    .HasColumnName("InventoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryCode).HasMaxLength(10);

                entity.Property(e => e.InventoryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("catInvenFk");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("prodInvenFk");
            });

            modelBuilder.Entity<Leaves>(entity =>
            {
                entity.HasKey(e => e.LeaveId);

                entity.Property(e => e.LeaveId)
                    .HasColumnName("LeaveID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.QtyPurchased)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__3864608B");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__OrderDeta__ProdI__395884C4");
            });

            modelBuilder.Entity<Ordered>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ordered)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Ordered__UserID__2DE6D218");
            });

            modelBuilder.Entity<ProcessOrder>(entity =>
            {
                entity.Property(e => e.ProcessOrderId).HasColumnName("ProcessOrderID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessOrderCode).HasMaxLength(20);

                entity.Property(e => e.ProdCode).HasMaxLength(20);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppId).HasColumnName("SuppID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProcessOrderProd)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("ReOrderfk");

                entity.HasOne(d => d.Supp)
                    .WithMany(p => p.ProcessOrderSupp)
                    .HasForeignKey(d => d.SuppId)
                    .HasConstraintName("ReOrderfk1");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProdCode).HasMaxLength(10);

                entity.Property(e => e.ProdDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProdImage).HasColumnType("binary(1)");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__Product__CatID__693CA210");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Status)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("statprodfk");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCatId);

                entity.Property(e => e.SubCatId).HasColumnName("SubCatID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                

                entity.Property(e => e.SubCatName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SubCatfk");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SuppId);

                entity.Property(e => e.SuppId).HasColumnName("SuppID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SuppAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppEmailId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppPhone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SupplierProduct>(entity =>
            {
                entity.HasKey(e => e.SuppProdId);

                entity.Property(e => e.SuppProdId).HasColumnName("SuppProdID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProdCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ProdDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProdName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SupplyOrder>(entity =>
            {
                entity.HasKey(e => e.SuppOrderId);

                entity.Property(e => e.SuppOrderId).HasColumnName("SuppOrderID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppOrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliedStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcessOrder)
                    .WithMany(p => p.SupplyOrder)
                    .HasForeignKey(d => d.ProcessOrderId)
                    .HasConstraintName("FK__SupplyOrd__Proce__3BFFE745");
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingDuration)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingType)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserType1)
                    .HasColumnName("UserType")
                    .HasMaxLength(20);
            });
        }
    }
}
