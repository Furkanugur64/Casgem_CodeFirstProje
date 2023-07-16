namespace Casgem_CodeFirstProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_travel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Travels", "TravelContent", c => c.String());
            AlterColumn("dbo.Travels", "TravelImageURL", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Travels", "TravelImageURL", c => c.Int(nullable: false));
            AlterColumn("dbo.Travels", "TravelContent", c => c.Int(nullable: false));
        }
    }
}
