namespace MVCUserRoles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1st : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AddRemoveTeachers", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.AddRemoveTeachers", new[] { "SubjectId" });
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        City = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.joins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.TeacherId);
            
            DropTable("dbo.AddRemoveTeachers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AddRemoveTeachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        SubjectAssign = c.String(),
                        City = c.String(),
                        Address = c.String(),
                        SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            DropForeignKey("dbo.joins", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.joins", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.joins", new[] { "TeacherId" });
            DropIndex("dbo.joins", new[] { "SubjectId" });
            DropTable("dbo.joins");
            DropTable("dbo.Teachers");
            CreateIndex("dbo.AddRemoveTeachers", "SubjectId");
            AddForeignKey("dbo.AddRemoveTeachers", "SubjectId", "dbo.Subjects", "SubjectId", cascadeDelete: true);
        }
    }
}
