namespace MiniFutbolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsnad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "PhotoPath", c => c.String(nullable: false));
            AlterColumn("dbo.Teams", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String());
            DropColumn("dbo.Teams", "PhotoPath");
        }
    }
}
