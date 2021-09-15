namespace TestEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertRoles : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Roles Values('Librarian')");
            Sql("Insert into Roles Values('Student')");
        }
        
        public override void Down()
        {
        }
    }
}
