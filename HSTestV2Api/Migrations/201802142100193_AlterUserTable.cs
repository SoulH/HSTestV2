namespace HSTestV2Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Firstname", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Firstname");
        }
    }
}
