namespace lab3_NguyenTanThai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into  categories (id, name) values (1, 'DeveLopment')");
            Sql("Insert into  categories (id, name) values (2, 'Business')");
            Sql("Insert into  categories (id, name) values (3, 'Maketing')");
        }
        
        public override void Down()
        {
        }
    }
}
