namespace Conexion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0103 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caja",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UsuarioAperturaId = c.Long(nullable: false),
                        MontoInicial = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaApertura = c.DateTime(nullable: false),
                        FechaCierre = c.DateTime(),
                        UsuarioCierreId = c.Long(),
                        MontoCierre = c.Decimal(precision: 18, scale: 2),
                        TotalVentaEfectivo = c.Decimal(precision: 18, scale: 2),
                        TotalEfectivo = c.Decimal(precision: 18, scale: 2),
                        TotalEgresos = c.Decimal(precision: 18, scale: 2),
                        TotalTarjeta = c.Decimal(precision: 18, scale: 2),
                        TotalCheque = c.Decimal(precision: 18, scale: 2),
                        TotalCuentaCorriente = c.Decimal(precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.UsuarioAperturaId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioCierreId)
                .Index(t => t.UsuarioAperturaId)
                .Index(t => t.UsuarioCierreId);
            
            CreateTable(
                "dbo.Movimiento",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CajaId = c.Long(),
                        UsuarioId = c.Long(),
                        FacturaId = c.Long(),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        TipoMovimiento = c.Int(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Caja", t => t.CajaId)
                .ForeignKey("dbo.Facturas", t => t.FacturaId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.CajaId)
                .Index(t => t.UsuarioId)
                .Index(t => t.FacturaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Caja", "UsuarioCierreId", "dbo.Usuario");
            DropForeignKey("dbo.Caja", "UsuarioAperturaId", "dbo.Usuario");
            DropForeignKey("dbo.Movimiento", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Movimiento", "FacturaId", "dbo.Facturas");
            DropForeignKey("dbo.Movimiento", "CajaId", "dbo.Caja");
            DropIndex("dbo.Movimiento", new[] { "FacturaId" });
            DropIndex("dbo.Movimiento", new[] { "UsuarioId" });
            DropIndex("dbo.Movimiento", new[] { "CajaId" });
            DropIndex("dbo.Caja", new[] { "UsuarioCierreId" });
            DropIndex("dbo.Caja", new[] { "UsuarioAperturaId" });
            DropTable("dbo.Movimiento");
            DropTable("dbo.Caja");
        }
    }
}
