namespace MyCompanyName.AbpZeroTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_TaStudent_Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaStudents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Sex = c.String(nullable: false, maxLength: 10),
                        Birthdate = c.DateTime(nullable: false),
                        SchoolId = c.Long(),
                        Grade = c.String(nullable: false, maxLength: 20),
                        HomeAddress = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        PhotoUrl = c.String(nullable: false, maxLength: 100),
                        IsDelete = c.Int(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaStudents");
        }
    }
}
