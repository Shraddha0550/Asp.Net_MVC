namespace DropDown1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBContext : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.tbl_Data");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tbl_Data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
