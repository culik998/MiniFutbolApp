namespace MiniFutbolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fhds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PhotoPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PhotoPath");
        }
    }
}
