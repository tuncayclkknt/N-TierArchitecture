﻿namespace CSharkEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "testAddition");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "testAddition", c => c.Boolean(nullable: false));
        }
    }
}
