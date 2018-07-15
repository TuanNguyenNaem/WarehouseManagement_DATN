namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext()
            : base("name=WarehouseDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractDetail> ContractDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EnterWarehouse> EnterWarehouses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OutWarehouse> OutWarehouses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<VIP> VIPs { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.Account);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.ContractDetails)
                .WithRequired(e => e.Contract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contract>()
                .HasOptional(e => e.EnterWarehouse)
                .WithRequired(e => e.Contract);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Accumulation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EnterWarehouses)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.OutWarehouses)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasOptional(e => e.OutWarehouse)
                .WithRequired(e => e.Order);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ImportPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Retail)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Wholesale)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ContractDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.Warehouse)
                .WithRequired(e => e.Product);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VIP>()
                .Property(e => e.VIPName)
                .IsUnicode(false);

            modelBuilder.Entity<VIP>()
                .Property(e => e.Accumulation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIP>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<VIP>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.VIP)
                .WillCascadeOnDelete(false);
        }
    }
}
