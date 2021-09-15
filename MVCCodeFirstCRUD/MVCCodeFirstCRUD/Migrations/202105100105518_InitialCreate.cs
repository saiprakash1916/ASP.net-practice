namespace MVCCodeFirstCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        UserTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeId = c.Int(nullable: false, identity: true),
                        UserTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTypes");
            DropTable("dbo.Users");
        }
    }
}
