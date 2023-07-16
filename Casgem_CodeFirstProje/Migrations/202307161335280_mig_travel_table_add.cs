namespace Casgem_CodeFirstProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_travel_table_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelID = c.Int(nullable: false, identity: true),
                        TravelTitle = c.String(),
                        TravelContent = c.Int(nullable: false),
                        TravelImageURL = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TravelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Travels");
        }
    }
}
