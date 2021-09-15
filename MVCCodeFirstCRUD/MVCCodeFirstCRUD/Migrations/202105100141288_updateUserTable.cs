namespace MVCCodeFirstCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "UserTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserTypeName", c => c.String(nullable: false));
            DropColumn("dbo.Users", "UserTypeId");
        }
    }
}
