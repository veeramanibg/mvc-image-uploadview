namespace ImageUploadViewDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedqualificationdatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Qualification", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Qualification", c => c.Int(nullable: false));
        }
    }
}
