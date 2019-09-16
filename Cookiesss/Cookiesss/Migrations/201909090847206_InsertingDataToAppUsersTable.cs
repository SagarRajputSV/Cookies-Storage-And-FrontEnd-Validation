namespace Cookiesss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingDataToAppUsersTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppUsers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.AppUsers", "UserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AppUsers", "UserName", c => c.String());
            AlterColumn("dbo.AppUsers", "Name", c => c.String());
        }
    }
}
