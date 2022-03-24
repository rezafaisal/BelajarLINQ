using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.MySQL
{
    public partial class northwindContext : DbContext
    {
        public northwindContext()
        {
        }

        public northwindContext(DbContextOptions<northwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategorySalesFor1997> CategorySalesFor1997s { get; set; }
        public virtual DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public virtual DbSet<Customercustomerdemo> Customercustomerdemos { get; set; }
        public virtual DbSet<Customerdemographic> Customerdemographics { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeeterritory> Employeeterritories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        public virtual DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public virtual DbSet<OrdersQry> OrdersQries { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSalesFor1997> ProductSalesFor1997s { get; set; }
        public virtual DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public virtual DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public virtual DbSet<QuarterlyOrder> QuarterlyOrders { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<SalesByCategory> SalesByCategories { get; set; }
        public virtual DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public virtual DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;Database=northwind;Uid=root;Pwd=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlphabeticalListOfProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("alphabetical list of products");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Discontinued)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.QuantityPerUnit)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SupplierID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("'0.0000'");

                entity.Property(e => e.UnitsInStock)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UnitsOnOrder)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.HasIndex(e => e.CategoryName, "CategoryName");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Description)
                    .HasColumnType("mediumtext")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Picture)
                    .HasColumnType("longblob")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CategorySalesFor1997>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("category sales for 1997");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CategorySales)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CurrentProductList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("current product list");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.City, "City");

                entity.HasIndex(e => e.CompanyName, "CompanyName");

                entity.HasIndex(e => e.PostalCode, "PostalCode");

                entity.HasIndex(e => e.Region, "Region");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CustomerAndSuppliersByCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("customer and suppliers by city");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasDefaultValueSql("''''''");
            });

            modelBuilder.Entity<Customercustomerdemo>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerTypeId })
                    .HasName("PRIMARY");

                entity.ToTable("customercustomerdemo");

                entity.HasIndex(e => e.CustomerTypeId, "FK_CustomerCustomerDemo");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("CustomerTypeID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Customercustomerdemos)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCustomerDemo_Customers");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customercustomerdemos)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCustomerDemo");
            });

            modelBuilder.Entity<Customerdemographic>(entity =>
            {
                entity.HasKey(e => e.CustomerTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("customerdemographics");

                entity.Property(e => e.CustomerTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("CustomerTypeID");

                entity.Property(e => e.CustomerDesc)
                    .HasColumnType("mediumtext")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.HasIndex(e => e.ReportsTo, "FK_Employees_Employees");

                entity.HasIndex(e => e.LastName, "LastName");

                entity.HasIndex(e => e.PostalCode, "PostalCode");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BirthDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Extension)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HireDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Photo)
                    .HasColumnType("longblob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReportsTo)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Salary).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TitleOfCourtesy)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.ReportsToNavigation)
                    .WithMany(p => p.InverseReportsToNavigation)
                    .HasForeignKey(d => d.ReportsTo)
                    .HasConstraintName("FK_Employees_Employees");
            });

            modelBuilder.Entity<Employeeterritory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.TerritoryId })
                    .HasName("PRIMARY");

                entity.ToTable("employeeterritories");

                entity.HasIndex(e => e.TerritoryId, "FK_EmployeeTerritories_Territories");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.TerritoryId)
                    .HasMaxLength(20)
                    .HasColumnName("TerritoryID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeeterritories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeTerritories_Employees");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.Employeeterritories)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeTerritories_Territories");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("invoices");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Discount).HasColumnType("double(8,0)");

                entity.Property(e => e.ExtendedPrice)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("'0.0000'");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Quantity)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RequiredDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipAddress)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipName)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipPostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShippedDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipperName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10,4)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.CustomerId, "FK_Orders_Customers");

                entity.HasIndex(e => e.EmployeeId, "FK_Orders_Employees");

                entity.HasIndex(e => e.ShipVia, "FK_Orders_Shippers");

                entity.HasIndex(e => e.OrderDate, "OrderDate");

                entity.HasIndex(e => e.ShipPostalCode, "ShipPostalCode");

                entity.HasIndex(e => e.ShippedDate, "ShippedDate");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("'0.0000'");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RequiredDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipAddress)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipName)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipPostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipVia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShippedDate).HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Orders_Customers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Orders_Employees");

                entity.HasOne(d => d.ShipViaNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipVia)
                    .HasConstraintName("FK_Orders_Shippers");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("order_details");

                entity.HasIndex(e => e.ProductId, "FK_Order_Details_Products");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ProductID");

                entity.Property(e => e.Discount).HasColumnType("double(8,0)");

                entity.Property(e => e.Quantity)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10,4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Details_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Details_Products");
            });

            modelBuilder.Entity<OrderDetailsExtended>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("order_details extended");

                entity.Property(e => e.Discount).HasColumnType("double(8,0)");

                entity.Property(e => e.ExtendedPrice)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Quantity)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10,4)");
            });

            modelBuilder.Entity<OrderSubtotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("order subtotals");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<OrdersQry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("orders qry");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("'0.0000'");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RequiredDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipAddress)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipName)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipPostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShipVia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShippedDate).HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.HasIndex(e => e.CategoryId, "FK_Products_Categories");

                entity.HasIndex(e => e.SupplierId, "FK_Products_Suppliers");

                entity.HasIndex(e => e.ProductName, "ProductName");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ProductID");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Discontinued)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.QuantityPerUnit)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SupplierID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("'0.0000'");

                entity.Property(e => e.UnitsInStock)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UnitsOnOrder)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Products_Suppliers");
            });

            modelBuilder.Entity<ProductSalesFor1997>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("product sales for 1997");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ProductSales)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ProductsAboveAveragePrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("products above average price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("'0.0000'");
            });

            modelBuilder.Entity<ProductsByCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("products by category");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Discontinued)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.QuantityPerUnit)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitsInStock)
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QuarterlyOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("quarterly orders");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("region");

                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RegionID");

                entity.Property(e => e.RegionDescription)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SalesByCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sales by category");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ProductSales)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SalesTotalsByAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sales totals by amount");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.SaleAmount)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShippedDate).HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("shippers");

                entity.Property(e => e.ShipperId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ShipperID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SummaryOfSalesByQuarter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("summary of sales by quarter");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.ShippedDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SummaryOfSalesByYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("summary of sales by year");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.ShippedDate).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("double(25,8)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("suppliers");

                entity.HasIndex(e => e.CompanyName, "CompanyName");

                entity.HasIndex(e => e.PostalCode, "PostalCode");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SupplierID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HomePage)
                    .HasColumnType("mediumtext")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.ToTable("territories");

                entity.HasIndex(e => e.RegionId, "FK_Territories_Region");

                entity.Property(e => e.TerritoryId)
                    .HasMaxLength(20)
                    .HasColumnName("TerritoryID");

                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RegionID");

                entity.Property(e => e.TerritoryDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Territories)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Territories_Region");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
