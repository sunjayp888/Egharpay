namespace Egharpay.Data
{
    using System.Data.Entity;
    using Egharpay.Entity;

    public partial class EgharpayDatabase : DbContext
    {
        public EgharpayDatabase() : base("name=EgharpayDatabase")
        {
        }

        public virtual DbSet<PersonnelGrid> PersonnelGrids { get; set; }
        public virtual DbSet<AspNetUsersAlertSchedule> AspNetUsersAlertSchedules { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<UserAuthorisationFilter> UserAuthorisationFilters { get; set; }
        public virtual DbSet<Centre> Centres { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentCategory> DocumentTypes { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
		public virtual DbSet<PincodeDataGrid> PincodeDataGrids { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<MaintenanceGrid> MaintenanceGrids { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
   //         modelBuilder.Entity<Personnel>()
   //             .Property(e => e.Telephone)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<Personnel>()
   //             .Property(e => e.Mobile)
   //             .IsUnicode(false);

          
   //         modelBuilder.Entity<Centre>()
   //               .Property(e => e.CentreCode)
   //               .IsUnicode(false);

   //         modelBuilder.Entity<Centre>()
   //             .Property(e => e.Name)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<Document>()
   //             .Property(e => e.FileName)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<Document>()
   //             .Property(e => e.Description)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<Document>()
   //             .Property(e => e.Location)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<DocumentCategory>()
   //             .Property(e => e.Name)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<DocumentCategory>()
   //             .Property(e => e.BasePath)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<DocumentCategory>()
   //             .HasMany(e => e.Documents)
   //             .WithRequired(e => e.DocumentType)
   //             .WillCascadeOnDelete(false);


   //         modelBuilder.Entity<Centre>()
   //             .Property(e => e.CentreCode)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<Centre>()
   //             .Property(e => e.Name)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<PersonnelGrid>()
   //            .Property(e => e.Telephone)
   //            .IsUnicode(false);

   //         modelBuilder.Entity<PersonnelGrid>()
   //             .Property(e => e.Mobile)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<PersonnelGrid>()
   //             .Property(e => e.NINumber)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<PersonnelGrid>()
   //             .Property(e => e.BankAccountNumber)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<PersonnelGrid>()
   //             .Property(e => e.BankSortCode)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<PersonnelGrid>()
   //             .Property(e => e.BankTelephone)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<PersonnelGrid>()
   //             .Property(e => e.Email)
   //             .IsUnicode(false);
				
			//modelBuilder.Entity<Maintenance>()
   //             .Property(e => e.Title)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<Maintenance>()
   //             .Property(e => e.RupeesInWords)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<MaintenanceGrid>()
   //             .Property(e => e.Title)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<MaintenanceGrid>()
   //             .Property(e => e.FirstName)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<MaintenanceGrid>()
   //             .Property(e => e.MiddleName)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<MaintenanceGrid>()
   //             .Property(e => e.LastName)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<MaintenanceGrid>()
   //             .Property(e => e.Wing)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<MaintenanceGrid>()
   //             .Property(e => e.Month)
   //             .IsUnicode(false);

   //         modelBuilder.Entity<MaintenanceGrid>()
   //             .Property(e => e.RupeesInWords)
   //             .IsUnicode(false);

            OnModelCreating(modelBuilder);
        }
    }
}
