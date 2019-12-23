namespace ImageUploadViewDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Notmappedhttppostimagefie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Qualification", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Qualification", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String());
        }
    }
}
