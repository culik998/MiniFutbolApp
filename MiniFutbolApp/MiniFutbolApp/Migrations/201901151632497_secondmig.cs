namespace MiniFutbolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "HomeTeamScore", c => c.Byte(nullable: false));
            AddColumn("dbo.Games", "AwayTeamScore", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "AwayTeamScore");
            DropColumn("dbo.Games", "HomeTeamScore");
        }
    }
}
