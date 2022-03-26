namespace Conexion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0103 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cajas",
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
                "dbo.Movimientos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CajaId = c.Long(nullable: false),
                        UsuarioId = c.Long(nullable: false),
                        FacturaId = c.Long(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 4000),
                        Fecha = c.DateTime(nullable: false),
                        TipoMovimiento = c.Int(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cajas", t => t.CajaId)
                .ForeignKey("dbo.Facturas", t => t.FacturaId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.CajaId)
                .Index(t => t.UsuarioId)
                .Index(t => t.FacturaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cajas", "UsuarioCierreId", "dbo.Usuario");
            DropForeignKey("dbo.Cajas", "UsuarioAperturaId", "dbo.Usuario");
            DropForeignKey("dbo.Movimientos", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Movimientos", "FacturaId", "dbo.Facturas");
            DropForeignKey("dbo.Movimientos", "CajaId", "dbo.Cajas");
            DropIndex("dbo.Movimientos", new[] { "FacturaId" });
            DropIndex("dbo.Movimientos", new[] { "UsuarioId" });
            DropIndex("dbo.Movimientos", new[] { "CajaId" });
            DropIndex("dbo.Cajas", new[] { "UsuarioCierreId" });
            DropIndex("dbo.Cajas", new[] { "UsuarioAperturaId" });
            DropTable("dbo.Movimientos");
            DropTable("dbo.Cajas");
        }
    }
}
