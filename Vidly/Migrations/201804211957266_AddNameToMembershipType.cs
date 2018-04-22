namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' Where Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' Where Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' Where Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' Where Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
