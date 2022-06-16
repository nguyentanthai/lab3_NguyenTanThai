namespace lab3_NguyenTanThai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "DateTime");
        }
    }
}
