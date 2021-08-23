namespace PatientPortalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VitalRevision : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vitals", "PatientId", "dbo.Patients");
            DropPrimaryKey("dbo.Vitals");
            AddColumn("dbo.Vitals", "VitalId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Vitals", "VitalId");
            AddForeignKey("dbo.Vitals", "PatientId", "dbo.Patients", "PatientId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vitals", "PatientId", "dbo.Patients");
            DropPrimaryKey("dbo.Vitals");
            DropColumn("dbo.Vitals", "VitalId");
            AddPrimaryKey("dbo.Vitals", "PatientId");
            AddForeignKey("dbo.Vitals", "PatientId", "dbo.Patients", "PatientId");
        }
    }
}
