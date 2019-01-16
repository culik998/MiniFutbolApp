namespace MiniFutbolApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class safdjsn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Users", "SurName", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "SurName", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
        }
    }
}
