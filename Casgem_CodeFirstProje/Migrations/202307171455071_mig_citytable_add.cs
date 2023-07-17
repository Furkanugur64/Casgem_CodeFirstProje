namespace Casgem_CodeFirstProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_citytable_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        CityCount = c.String(),
                        CityImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cities");
        }
    }
}
