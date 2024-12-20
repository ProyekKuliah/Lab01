namespace Lab01_151524010_FerdhikaYudira.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class LabModels : DbContext
    {
        // Your context has been configured to use a 'LabModels' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab01_151524010_FerdhikaYudira.Models.LabModels' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LabModels' 
        // connection string in the application configuration file.
        public LabModels()
            : base("name=db_lab01") // nama connection string
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Competition> Competition { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Custom name many to many
            modelBuilder.Entity<Member>()
                .HasMany<Competition>(s => s.Competitions)
                .WithMany(c => c.Members)
                .Map(cs =>{
                    cs.MapLeftKey("MemberId");
                    cs.MapRightKey("CompetitionId");
                    cs.ToTable("MemberCompetition");
                });
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}