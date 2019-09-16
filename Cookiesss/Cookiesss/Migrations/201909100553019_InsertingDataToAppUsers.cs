namespace Cookiesss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingDataToAppUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AppUsers(Name,UserName,Password)" +
                "VALUES('Ajit','Ajit@96','90089@Aj#')");
        }
        
        public override void Down()
        {
        }
    }
}
