namespace AndrewsApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre = c.String(),
                        DirectorName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
