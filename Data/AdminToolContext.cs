using System;
using Admin_tools.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Admin_Tool.Models
{
    public partial class AdminToolContext : DbContext
    {
        public AdminToolContext()
        {
        }

        public AdminToolContext(DbContextOptions<AdminToolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUser {get;set;}
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AppExceptions> AppExceptions { get; set; }
        public virtual DbSet<BdxMaintenanceTwoajgrebchcjx> BdxMaintenanceTwoajgrebchcjx { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<EkoEvtCompany> EkoEvtCompany { get; set; }
        public virtual DbSet<EkoEvtEvent> EkoEvtEvent { get; set; }
        public virtual DbSet<EkoEvtPerson> EkoEvtPerson { get; set; }
        public virtual DbSet<EkoEvtToken> EkoEvtToken { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventImage> EventImage { get; set; }
        public virtual DbSet<Licenses> Licenses { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<MaintenanceReminders> MaintenanceReminders { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsImage> NewsImage { get; set; }
        public virtual DbSet<OfflineActivations> OfflineActivations { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsErrorLog> ProductsErrorLog { get; set; }
        public virtual DbSet<ReleaseNotes> ReleaseNotes { get; set; }
        public virtual DbSet<Reseller> Reseller { get; set; }
        public virtual DbSet<Resellers> Resellers { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceImage> ServiceImage { get; set; }
        public virtual DbSet<StaticPage> StaticPage { get; set; }
        public virtual DbSet<StaticPageImage> StaticPageImage { get; set; }
        public virtual DbSet<TcoinstallLog> TcoinstallLog { get; set; }
        public virtual DbSet<TrialCodes> TrialCodes { get; set; }
        public virtual DbSet<UpgradeDetails> UpgradeDetails { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Version> Version { get; set; }

        // Unable to generate entity type for table 'dbo.SharePointUpdateInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_DownloadData_FWSUSKLBPCSNL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_Licenses_OGCGFJHPDZRJSUGXM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_ResetUsedLicen_MPMERLIJHAM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_TCOActivations_BPQZATTTBQS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_Customer_OQRLYJQZLUQOYKBUR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_DownloadData_XUNCSMKDGSFTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_Licenses_XESPDNFHBBHBGRKYR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_ResetUsedLicen_HYPFDKLVTQE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_TCOActivations_GFSUKLQTWLX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_Customer_SMXMZGOGPUOPCPQAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_DownloadData_OUQXYJNKWISUV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_Licenses_HVZLVJOBWIOVITVEV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_ResetUsedLicen_SXFHXRDZCFU'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_TCOActivations_FYXIVDPUOMC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ChangedLicenseStates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_Customer_ULWSIMCKWUEIRWOSL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_ResetUsedLicen_XWPBHBEUQEM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_TCOActivations_YDSBOAWFQDI'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DownloadData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_ReleaseNotes_QDHDSLYMVWSMR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_ResetUsedLicen_DAAOQPWRSWE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TCOActivations'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_TCOActivations_HTOVGCYURDS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BDX_ReleaseNotes_IAOXYYUKQBTGW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TCOActivations_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'ekobithr_admin.OrderDetails_TestMngr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ResetUsedLicenses'. Please see the warning messages.

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer();
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppExceptions>(entity =>
            {
                entity.HasKey(e => e.Idexception);

                entity.Property(e => e.Idexception).HasColumnName("IDException");

                entity.Property(e => e.ExceptionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StackTrace)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TargetSite)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdxMaintenanceTwoajgrebchcjx>(entity =>
            {
                entity.ToTable("BDX_Maintenance_TWOAJGREBCHCJX");

                entity.Property(e => e.Id)
                    .HasColumnName("_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdCustomer)
                    .IsRequired()
                    .HasColumnName("id_customer");

                entity.Property(e => e.MaintenanceDate)
                    .IsRequired()
                    .HasColumnName("maintenance_date");

                entity.Property(e => e.OrderNr)
                    .IsRequired()
                    .HasColumnName("order_nr");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasColumnName("product_id");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");

                entity.Property(e => e.ConfigurationName).HasMaxLength(100);

                entity.Property(e => e.ConfigurationValue).HasMaxLength(1000);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.HasIndex(e => e.Email)
                    .HasName("IX_Customer")
                    .IsUnique();

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lang)
                    .HasColumnName("lang")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("phone_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Customer_Address");
            });

            modelBuilder.Entity<EkoEvtCompany>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("ekoEvtCompany");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mb)
                    .IsRequired()
                    .HasColumnName("MB")
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postal)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EkoEvtEvent>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("ekoEvtEvent");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EkoEvtPerson>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("ekoEvtPerson");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Oib)
                    .HasColumnName("OIB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Postal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TshirtSize)
                    .HasColumnName("TShirtSize")
                    .HasMaxLength(10);

                entity.HasOne(d => d.PerCmp)
                    .WithMany(p => p.EkoEvtPerson)
                    .HasForeignKey(d => d.PerCmpId)
                    .HasConstraintName("FK_ekoEvtPerson_ekoEvtCompany");

                entity.HasOne(d => d.PerEvt)
                    .WithMany(p => p.EkoEvtPerson)
                    .HasForeignKey(d => d.PerEvtId)
                    .HasConstraintName("FK_ekoEvtPerson_ekoEvtEvent");
            });

            modelBuilder.Entity<EkoEvtToken>(entity =>
            {
                entity.HasKey(e => e.TokenId);

                entity.ToTable("ekoEvtToken");

                entity.Property(e => e.TokenId).ValueGeneratedNever();

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EkoEvtToken)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ekoEvtToken_ekoEvtEvent");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EkoEvtToken)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ekoEvtToken_ekoEvtPerson");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.Error)
                    .IsRequired()
                    .HasColumnName("error")
                    .HasColumnType("text");

                entity.Property(e => e.InputData)
                    .IsRequired()
                    .HasColumnName("input_data")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate)
                    .HasColumnName("log_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventMainPicture).HasColumnType("image");

                entity.Property(e => e.EventPublishDate).HasColumnType("datetime");

                entity.Property(e => e.EventShortText).HasMaxLength(1000);

                entity.Property(e => e.EventText).HasColumnType("ntext");

                entity.Property(e => e.EventTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<EventImage>(entity =>
            {
                entity.Property(e => e.EventImageId).HasColumnName("EventImageID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventImageImage).HasColumnType("image");

                entity.Property(e => e.EventImageThumbnail).HasColumnType("image");

                entity.Property(e => e.EventImageTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<Licenses>(entity =>
            {
                entity.HasKey(e => new { e.LicenseKey, e.Version });

                entity.Property(e => e.LicenseKey)
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CanExtendUntil)
                    .HasColumnName("can_extend_until")
                    .HasColumnType("date");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.NumExpired)
                    .HasColumnName("num_expired")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalLicenses).HasColumnName("total_licenses");

                entity.Property(e => e.TotalLicensesV5).HasColumnName("total_licenses_v5");

                entity.Property(e => e.UsedLicenses)
                    .HasColumnName("used_licenses")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UsedLicensesV5).HasColumnName("used_licenses_v5");

                entity.Property(e => e.ValidUntil)
                    .HasColumnName("valid_until")
                    .HasColumnType("date");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Licenses)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licenses_Customer");
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.HasKey(e => new { e.OrderNr, e.IdCustomer, e.ProductId, e.MaintenanceDate });

                entity.Property(e => e.OrderNr)
                    .HasColumnName("order_nr")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.MaintenanceDate)
                    .HasColumnName("maintenance_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("invoice_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseKey)
                    .IsRequired()
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LicensesExtended).HasColumnName("licenses_extended");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<MaintenanceReminders>(entity =>
            {
                entity.HasIndex(e => new { e.Date, e.LicenseKey })
                    .HasName("IX_MaintenanceReminders")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasColumnName("customer_email")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("customer_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DaysValid).HasColumnName("days_valid");

                entity.Property(e => e.LicenseKey)
                    .IsRequired()
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderSent).HasColumnName("reminderSent");

                entity.Property(e => e.TotalLicenses).HasColumnName("total_licenses");

                entity.Property(e => e.ValidUntil)
                    .HasColumnName("valid_until")
                    .HasColumnType("date");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.NewsPublishDate).HasColumnType("datetime");

                entity.Property(e => e.NewsShortText).HasMaxLength(1000);

                entity.Property(e => e.NewsText).HasColumnType("ntext");

                entity.Property(e => e.NewsTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<NewsImage>(entity =>
            {
                entity.Property(e => e.NewsImageId).HasColumnName("NewsImageID");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.NewsImageImage).HasColumnType("image");

                entity.Property(e => e.NewsImageThumbnail).HasColumnType("image");

                entity.Property(e => e.NewsImageTitle).HasMaxLength(150);
            });

            modelBuilder.Entity<OfflineActivations>(entity =>
            {
                entity.HasKey(e => new { e.LicenseKey, e.ActivationDate });

                entity.Property(e => e.LicenseKey)
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationDate)
                    .HasColumnName("activation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicensedTo)
                    .IsRequired()
                    .HasColumnName("licensed_to")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machineName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedBy)
                    .IsRequired()
                    .HasColumnName("requested_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TcoVersion)
                    .HasColumnName("tcoVersion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.OrderNr, e.IdCustomer, e.IdReseller, e.ProductId, e.PurchaseDate });

                entity.Property(e => e.OrderNr).HasColumnName("order_nr");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdReseller).HasColumnName("id_reseller");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("purchase_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CanActivate)
                    .IsRequired()
                    .HasColumnName("can_activate")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("invoice_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseKey)
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LicensesPurchased).HasColumnName("licenses_purchased");

                entity.Property(e => e.Notification)
                    .HasColumnName("notification")
                    .HasColumnType("text");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_OrderDetails_Address_2");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Customer_2");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Products_2");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductMainPicture).HasColumnType("image");

                entity.Property(e => e.ProductPublishDate).HasColumnType("datetime");

                entity.Property(e => e.ProductShortText).HasMaxLength(1000);

                entity.Property(e => e.ProductText).HasColumnType("ntext");

                entity.Property(e => e.ProductTitle).HasMaxLength(100);

                entity.Property(e => e.ProductType).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.ProductImageId).HasColumnName("ProductImageID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductImageImage).HasColumnType("image");

                entity.Property(e => e.ProductImageThumbnail).HasColumnType("image");

                entity.Property(e => e.ProductImageTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LicensedUsers).HasColumnName("licensed_users");

                entity.Property(e => e.ProductFamily)
                    .HasColumnName("product_family")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductsErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorId);

                entity.Property(e => e.ErrorId).HasColumnName("error_id");

                entity.Property(e => e.ErrorInfo)
                    .IsRequired()
                    .HasColumnName("error_info")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenseKey)
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserComment)
                    .HasColumnName("user_comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ReleaseNotes>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .ValueGeneratedNever();

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Reseller>(entity =>
            {
                entity.HasKey(e => e.IdReseller);

                entity.Property(e => e.IdReseller).HasColumnName("id_reseller");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lang)
                    .HasColumnName("lang")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("phone_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResellerName)
                    .HasColumnName("reseller_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Resellers>(entity =>
            {
                entity.HasKey(e => e.Idreseller);

                entity.Property(e => e.Idreseller).HasColumnName("IDReseller");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResellerData).HasColumnType("text");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Web)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServicePublishDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceShortText).HasMaxLength(1000);

                entity.Property(e => e.ServiceText).HasColumnType("ntext");

                entity.Property(e => e.ServiceTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<ServiceImage>(entity =>
            {
                entity.Property(e => e.ServiceImageId).HasColumnName("ServiceImageID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceImageImage).HasColumnType("image");

                entity.Property(e => e.ServiceImageThumbnail).HasColumnType("image");

                entity.Property(e => e.ServiceImageTitle).HasMaxLength(150);
            });

            modelBuilder.Entity<StaticPage>(entity =>
            {
                entity.Property(e => e.StaticPageId).HasColumnName("StaticPageID");

                entity.Property(e => e.StaticPagePath).HasMaxLength(100);

                entity.Property(e => e.StaticPagePicture).HasColumnType("image");

                entity.Property(e => e.StaticPageText).HasColumnType("ntext");

                entity.Property(e => e.StaticPageTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<StaticPageImage>(entity =>
            {
                entity.Property(e => e.StaticPageImageId).HasColumnName("StaticPageImageID");

                entity.Property(e => e.StaticPageId).HasColumnName("StaticPageID");

                entity.Property(e => e.StaticPageImageImage).HasColumnType("image");

                entity.Property(e => e.StaticPageImageThumbnail).HasColumnType("image");

                entity.Property(e => e.StaticPageImageTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<TcoinstallLog>(entity =>
            {
                entity.HasKey(e => e.UpgradeId);

                entity.ToTable("TCOInstallLog");

                entity.Property(e => e.UpgradeId).HasColumnName("upgrade_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstalledOn)
                    .HasColumnName("installed_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicenseKey)
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasColumnName("machineName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewVersion)
                    .IsRequired()
                    .HasColumnName("newVersion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldVersion)
                    .HasColumnName("oldVersion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VersionInfo)
                    .HasColumnName("versionInfo")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrialCodes>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Activated).HasColumnName("activated");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpgradeDetails>(entity =>
            {
                entity.HasKey(e => new { e.OrderNr, e.IdCustomer, e.ProductId, e.UpgradeDate });

                entity.Property(e => e.OrderNr)
                    .HasColumnName("order_nr")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UpgradeDate)
                    .HasColumnName("upgrade_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("invoice_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseKey)
                    .IsRequired()
                    .HasColumnName("license_key")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LicensesUpgraded).HasColumnName("licenses_upgraded");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.UpgradeEmail)
                    .HasColumnName("upgrade_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserEmail).HasMaxLength(50);

                entity.Property(e => e.UserFullName).HasMaxLength(100);

                entity.Property(e => e.UserLogin).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(50);

                entity.Property(e => e.UserTelephone).HasMaxLength(50);
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasKey(e => e.Version1);

                entity.Property(e => e.Version1)
                    .HasColumnName("version")
                    .ValueGeneratedNever();

                entity.Property(e => e.LatestVersion)
                    .HasColumnName("latestVersion")
                    .HasMaxLength(15);

                entity.Property(e => e.MaxVersion).HasColumnName("maxVersion");
            });
        }
    }
}
