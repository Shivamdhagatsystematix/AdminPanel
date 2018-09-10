namespace MVCUserRoles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2nd : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Subjects");
            AlterColumn("dbo.Subjects", "SubjectId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Subjects", "SubjectId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Subjects");
            AlterColumn("dbo.Subjects", "SubjectId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Subjects", "SubjectId");
        }
    }
}
