namespace Cookiesss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingDataToTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AppUsers(Name,UserName,Password)" +
               "VALUES('Sagar','Sagar@','7899@Vi#')," +
               "('Sandeep','Sandeep@','7019@Sa#')");
        }
        
        public override void Down()
        {
        }
    }
}
