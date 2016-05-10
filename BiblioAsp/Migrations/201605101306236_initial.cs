namespace BiblioAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Livres", new[] { "Titre" });
            AlterColumn("dbo.Livres", "Titre", c => c.String(nullable: false, maxLength: 150));
            CreateIndex("dbo.Livres", "Titre", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Livres", new[] { "Titre" });
            AlterColumn("dbo.Livres", "Titre", c => c.String(maxLength: 150));
            CreateIndex("dbo.Livres", "Titre", unique: true);
        }
    }
}
