namespace ImageUploadViewDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialEmployeetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        Age = c.Int(nullable: false),
                        Qualification = c.Int(nullable: false),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
