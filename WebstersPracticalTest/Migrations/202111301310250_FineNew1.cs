namespace WebstersPracticalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FineNew1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fine",
                c => new
                    {
                        Fineid = c.Int(nullable: false, identity: true),
                        FineName = c.String(),
                        FineCharges = c.String(),
                    })
                .PrimaryKey(t => t.Fineid);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Fineid = c.Int(nullable: false),
                        ViolatorsId = c.Int(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Violators",
                c => new
                    {
                        ViolatorsId = c.Int(nullable: false, identity: true),
                        Fineid = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        ViolatorName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ViolatorsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Violators");
            DropTable("dbo.Person");
            DropTable("dbo.Payments");
            DropTable("dbo.Fine");
        }
    }
}
