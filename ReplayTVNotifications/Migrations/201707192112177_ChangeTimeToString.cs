namespace ReplayTVNotifications.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTimeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notifications", "time", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notifications", "time", c => c.DateTime(nullable: false));
        }
    }
}
