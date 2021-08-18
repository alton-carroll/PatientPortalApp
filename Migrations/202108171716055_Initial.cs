namespace PatientPortalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appoinments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        AppointmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        Prefix = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Suffix = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Ssn = c.String(),
                        ActivePatient = c.Boolean(nullable: false),
                        Street = c.String(),
                        Apartment = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        PrimaryInsurance = c.String(),
                        PrimaryInsuranceID = c.String(),
                        PrimaryInsuranceHolder = c.String(),
                        SecondaryInsurance = c.String(),
                        SecondaryInsuranceID = c.String(),
                        SecondaryInsuranceHolder = c.String(),
                        CurrentBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedBy = c.String(),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.Referrals",
                c => new
                    {
                        ReferralId = c.Int(nullable: false, identity: true),
                        ReferralDate = c.DateTime(nullable: false),
                        Provider = c.String(),
                        RefProviderName = c.String(),
                        Procedure = c.String(),
                        Location = c.String(),
                        CreatedBy = c.String(),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReferralId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Referrals", "PatientId", "dbo.Patients");
            DropIndex("dbo.Referrals", new[] { "PatientId" });
            DropTable("dbo.Referrals");
            DropTable("dbo.Patients");
            DropTable("dbo.Appoinments");
        }
    }
}
