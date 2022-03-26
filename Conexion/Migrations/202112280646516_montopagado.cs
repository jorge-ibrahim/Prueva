namespace Conexion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class montopagado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facturas", "MontoPagado", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facturas", "MontoPagado");
        }
    }
}
