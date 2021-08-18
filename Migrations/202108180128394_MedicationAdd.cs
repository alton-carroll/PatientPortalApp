namespace PatientPortalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MedicationAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medications",
                c => new
                    {
                        MedicationId = c.Int(nullable: false, identity: true),
                        MedicationName = c.String(),
                        MedDescription = c.String(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicationId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medications", "PatientId", "dbo.Patients");
            DropIndex("dbo.Medications", new[] { "PatientId" });
            DropTable("dbo.Medications");
        }
    }
}
