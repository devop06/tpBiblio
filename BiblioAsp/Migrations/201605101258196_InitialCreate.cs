namespace BiblioAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auteurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 250, unicode: false),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(maxLength: 150),
                        DateParution = c.DateTime(nullable: false),
                        Auteur_Id = c.Int(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auteurs", t => t.Auteur_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Titre, unique: true)
                .Index(t => t.Auteur_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livres", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Livres", "Auteur_Id", "dbo.Auteurs");
            DropIndex("dbo.Livres", new[] { "Client_Id" });
            DropIndex("dbo.Livres", new[] { "Auteur_Id" });
            DropIndex("dbo.Livres", new[] { "Titre" });
            DropTable("dbo.Livres");
            DropTable("dbo.Clients");
            DropTable("dbo.Auteurs");
        }
    }
}
