using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsumeSubCategory.Models
{
    public partial class SlipCartDatabaseContext : DbContext
    {
        public SlipCartDatabaseContext(DbContextOptions<SlipCartDatabaseContext> options)

 : base(options)

        {

        }
        public virtual DbSet<AddToCart> AddToCart { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Distributor> Distributor { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderedProductB2c> OrderedProductB2c { get; set; }
        public virtual DbSet<OrderProductB2b> OrderProductB2b { get; set; }
        public virtual DbSet<ProcessOrder> ProcessOrder { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierProduct> SupplierProduct { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrder { get; set; }
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
            modelBuilder.Entity<AddToCart>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AddToCart)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__AddToCart__Custo__4E1E9780");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.AddToCart)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__AddToCart__ProdI__4F12BBB9");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("CatID");

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

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGender).HasColumnType("char(1)");

                entity.Property(e => e.CustomerLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMailId)
                    .HasColumnName("CustomerMailID")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPassword)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("('true')");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
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

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.InvoiceNo).HasMaxLength(10);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(10);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__OrderDeta__Custo__5A846E65");
            });

            modelBuilder.Entity<OrderedProductB2c>(entity =>
            {
                entity.HasKey(e => e.OrderedProductId);

                entity.ToTable("OrderedProductB2C");

                entity.Property(e => e.OrderedProductId).HasColumnName("OrderedProductID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderedProductB2c)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderedPr__Order__6BAEFA67");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.OrderedProductB2c)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK__OrderedPr__ProdI__6CA31EA0");
            });

            modelBuilder.Entity<OrderProductB2b>(entity =>
            {
                entity.HasKey(e => e.OrderProdB2bid);

                entity.ToTable("OrderProductB2B");

                entity.Property(e => e.OrderProdB2bid).HasColumnName("OrderProdB2BID");

                entity.Property(e => e.ProcessOrderCode).HasMaxLength(20);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.ProcessOrderCodeNavigation)
                    .WithMany(p => p.OrderProductB2b)
                    .HasForeignKey(d => d.ProcessOrderCode)
                    .HasConstraintName("processProductFK1");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.OrderProductB2b)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("processProdFK1");
            });

            modelBuilder.Entity<ProcessOrder>(entity =>
            {
                entity.HasKey(e => e.ProcessOrderCode);

                entity.Property(e => e.ProcessOrderCode)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessOrderId)
                    .HasColumnName("ProcessOrderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SuppId).HasColumnName("SuppID");

                entity.HasOne(d => d.Supp)
                    .WithMany(p => p.ProcessOrder)
                    .HasForeignKey(d => d.SuppId)
                    .HasConstraintName("SuppProcessFK");
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

                entity.Property(e => e.SubCatId).HasColumnName("SubCatID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__Product__CatID__693CA210");

                entity.HasOne(d => d.SubCat)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SubCatId)
                    .HasConstraintName("SbCFk");
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

                entity.Property(e => e.IsActive).HasDefaultValueSql("('false')");

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

                entity.Property(e => e.ProcessOrderCode).HasMaxLength(50);

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
