namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreValue1 : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE Genres SET Id = Id + 1");
        }
        
        public override void Down()
        {
        }
    }
}
