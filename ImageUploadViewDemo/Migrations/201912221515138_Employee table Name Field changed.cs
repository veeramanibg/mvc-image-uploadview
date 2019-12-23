namespace ImageUploadViewDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeetableNameFieldchanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Name", c => c.String());
            DropColumn("dbo.Employees", "EmployeeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeeName", c => c.String());
            DropColumn("dbo.Employees", "Name");
        }
    }
}
