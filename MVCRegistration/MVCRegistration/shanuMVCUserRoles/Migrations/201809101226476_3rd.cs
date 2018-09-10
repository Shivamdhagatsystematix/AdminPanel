namespace MVCUserRoles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddRemoveTeachers", "SubjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.AddRemoveTeachers", "SubjectId");
            AddForeignKey("dbo.AddRemoveTeachers", "SubjectId", "dbo.Subjects", "SubjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddRemoveTeachers", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.AddRemoveTeachers", new[] { "SubjectId" });
            DropColumn("dbo.AddRemoveTeachers", "SubjectId");
        }
    }
}
