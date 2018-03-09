namespace Lab01_151524010_FerdhikaYudira.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class MemberModels : DbContext
    {
        // Your context has been configured to use a 'Member' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab01_151524010_FerdhikaYudira.Models.Member' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Member' 
        // connection string in the application configuration file.
        public MemberModels()
            : base("name=db_lab01") // nama connection string
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Member> Member { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .Property(e => e.MemberId);

            modelBuilder.Entity<Member>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.DateOfBirth);

            modelBuilder.Entity<Member>()
                .Property(e => e.Height);

            modelBuilder.Entity<Member>()
                .Property(e => e.Weight);

            modelBuilder.Entity<Member>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}