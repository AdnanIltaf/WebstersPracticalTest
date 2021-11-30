namespace WebstersPracticalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FineNew2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fine", "FineName", c => c.String(nullable: false));
            AlterColumn("dbo.Fine", "FineCharges", c => c.String(nullable: false));
            AlterColumn("dbo.Payments", "PaymentDate", c => c.DateTime());
            AlterColumn("dbo.Person", "PersonName", c => c.String(nullable: false));
            AlterColumn("dbo.Violators", "ViolatorName", c => c.String(nullable: false));
            AlterColumn("dbo.Violators", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Violators", "Location", c => c.String());
            AlterColumn("dbo.Violators", "ViolatorName", c => c.String());
            AlterColumn("dbo.Person", "PersonName", c => c.String());
            AlterColumn("dbo.Payments", "PaymentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Fine", "FineCharges", c => c.String());
            AlterColumn("dbo.Fine", "FineName", c => c.String());
        }
    }
}
