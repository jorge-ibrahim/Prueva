namespace Conexion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0102 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Items", new[] { "Factura_Id" });
            RenameColumn(table: "dbo.Items", name: "Factura_Id", newName: "FacturaId");
            AlterColumn("dbo.Items", "FacturaId", c => c.Long(nullable: false));
            CreateIndex("dbo.Items", "FacturaId");
            DropColumn("dbo.Items", "ComprobanteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "ComprobanteId", c => c.Long(nullable: false));
            DropIndex("dbo.Items", new[] { "FacturaId" });
            AlterColumn("dbo.Items", "FacturaId", c => c.Long());
            RenameColumn(table: "dbo.Items", name: "FacturaId", newName: "Factura_Id");
            CreateIndex("dbo.Items", "Factura_Id");
        }
    }
}
