namespace MVCCodeFirstCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertUserTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into UserTypes values('Admin')");
            Sql("Insert into UserTypes values('Librarian')");
            Sql("Insert into UserTypes values('Student')");
        }
        
        public override void Down()
        {
        }
    }
}
