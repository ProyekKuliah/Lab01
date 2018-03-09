namespace Lab01_151524010_FerdhikaYudira.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255, unicode: false),
                        LastName = c.String(maxLength: 255, unicode: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Height = c.Int(),
                        Weight = c.Int(),
                        Email = c.String(nullable: false, maxLength: 20, unicode: false),
                        Phone = c.String(maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Member");
        }
    }
}
