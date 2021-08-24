namespace PatientPortalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        AppointmentDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        Reason = c.String(),
                        ProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Patients", t => t.PatientId)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.ProviderId);
            
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
                "dbo.Medications",
                c => new
                    {
                        MedicationId = c.Int(nullable: false, identity: true),
                        MedicationDate = c.DateTime(nullable: false),
                        MedicationName = c.String(),
                        MedDescription = c.String(),
                        CreatedBy = c.String(),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicationId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Referrals",
                c => new
                    {
                        ReferralId = c.Int(nullable: false, identity: true),
                        ReferralDate = c.DateTime(nullable: false),
                        Doctor = c.String(),
                        ReferralDoctor = c.String(),
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
            
            CreateTable(
                "dbo.Vitals",
                c => new
                    {
                        VitalId = c.Int(nullable: false, identity: true),
                        VitalDate = c.DateTime(nullable: false),
                        Weight = c.String(),
                        Height = c.String(),
                        Temperature = c.String(),
                        BloodPressure = c.String(),
                        Pulse = c.String(),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VitalId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        ProviderId = c.Int(nullable: false, identity: true),
                        ProviderName = c.String(),
                        Specialty = c.String(),
                    })
                .PrimaryKey(t => t.ProviderId);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        TreatmentId = c.Int(nullable: false, identity: true),
                        TreatmentDate = c.DateTime(nullable: false),
                        TreatDescription = c.String(),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TreatmentId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Treatments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Vitals", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Referrals", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Medications", "PatientId", "dbo.Patients");
            DropIndex("dbo.Treatments", new[] { "PatientId" });
            DropIndex("dbo.Vitals", new[] { "PatientId" });
            DropIndex("dbo.Referrals", new[] { "PatientId" });
            DropIndex("dbo.Medications", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "ProviderId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.Treatments");
            DropTable("dbo.Providers");
            DropTable("dbo.Vitals");
            DropTable("dbo.Referrals");
            DropTable("dbo.Medications");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
