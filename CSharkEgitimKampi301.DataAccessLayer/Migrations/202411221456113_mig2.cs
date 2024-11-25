namespace CSharkEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "Age", c => c.Int(nullable: false));
        }
    }
}
