namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Titulo = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ProfesorId);
            
            AddColumn("dbo.Alumno", "profId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alumno", "profId");
            AddForeignKey("dbo.Alumno", "profId", "dbo.Profesors", "ProfesorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "profId", "dbo.Profesors");
            DropIndex("dbo.Alumno", new[] { "profId" });
            DropColumn("dbo.Alumno", "profId");
            DropTable("dbo.Profesors");
        }
    }
}
