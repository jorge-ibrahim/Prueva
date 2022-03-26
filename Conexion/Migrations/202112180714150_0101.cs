namespace Conexion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0101 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        MarcaId = c.Long(nullable: false),
                        RubroId = c.Long(nullable: false),
                        ProveedorId = c.Long(nullable: false),
                        UnidadMedidaId = c.Long(nullable: false),
                        Codigo = c.Long(nullable: false),
                        CodigoBarra = c.String(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        Detalle = c.String(maxLength: 250),
                        Stock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                        Compra_Id = c.Long(),
                        Venta_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId)
                .ForeignKey("dbo.Proveedor", t => t.ProveedorId)
                .ForeignKey("dbo.Compra", t => t.Compra_Id)
                .ForeignKey("dbo.Venta", t => t.Venta_Id)
                .ForeignKey("dbo.Rubros", t => t.RubroId)
                .ForeignKey("dbo.UnidadMedida", t => t.UnidadMedidaId)
                .Index(t => t.MarcaId)
                .Index(t => t.RubroId)
                .Index(t => t.ProveedorId)
                .Index(t => t.UnidadMedidaId)
                .Index(t => t.Compra_Id)
                .Index(t => t.Venta_Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Precios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ListaPrecioId = c.Long(nullable: false),
                        ArticuloId = c.Long(nullable: false),
                        PrecioCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioPublico = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaActualizacion = c.DateTime(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articulo", t => t.ArticuloId)
                .ForeignKey("dbo.ListaPrecios", t => t.ListaPrecioId)
                .Index(t => t.ListaPrecioId)
                .Index(t => t.ArticuloId);
            
            CreateTable(
                "dbo.ListaPrecios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        PorcentajeGanancia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NecesitaAutorizacion = c.Boolean(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RazonSocial = c.String(),
                        Cuil = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                        EstaEliminado = c.Boolean(nullable: false),
                        CondicionIva_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CondicionIva", t => t.CondicionIva_Id)
                .Index(t => t.CondicionIva_Id);
            
            CreateTable(
                "dbo.Compra",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CodigoCompra = c.Int(nullable: false),
                        EmpleadoId = c.Long(nullable: false),
                        ProveedorId = c.Long(nullable: false),
                        ArticuloId = c.Long(nullable: false),
                        NombreProveedor = c.String(nullable: false),
                        CodigoProducto = c.Int(nullable: false),
                        DescripcionProducto = c.String(nullable: false, maxLength: 250),
                        NuevoStock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCompra = c.DateTime(nullable: false),
                        PrecioArticulo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioArticuloStr = c.String(maxLength: 250),
                        MontoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MontoTotalStr = c.String(maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona_Empleado", t => t.EmpleadoId)
                .ForeignKey("dbo.Proveedor", t => t.ProveedorId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.ProveedorId);
            
            CreateTable(
                "dbo.Persona_Empleado",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Legajo = c.Int(nullable: false),
                        Apellido = c.String(nullable: false, maxLength: 250),
                        Nombre = c.String(nullable: false, maxLength: 250),
                        Dni = c.String(nullable: false),
                        Domicilio = c.String(nullable: false, maxLength: 300),
                        Telefono = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        EmpleadoId = c.Long(nullable: false),
                        NombreUsuario = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 50),
                        EstaBloqueado = c.Boolean(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona_Empleado", t => t.EmpleadoId)
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClienteId = c.Long(nullable: false),
                        EmpleadoId = c.Long(nullable: false),
                        UsuarioId = c.Long(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Numero = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iva21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iva105 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoComprobante = c.Int(nullable: false),
                        EstadoComprobante = c.Int(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.Persona_Empleado", t => t.EmpleadoId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CondicionIvaId = c.Long(nullable: false),
                        RazonSocial = c.String(nullable: false, maxLength: 250),
                        Nombre = c.String(nullable: false, maxLength: 250),
                        Apellido = c.String(nullable: false, maxLength: 250),
                        Dni = c.String(nullable: false, maxLength: 250),
                        Cuil = c.String(nullable: false, maxLength: 250),
                        Domicilio = c.String(nullable: false, maxLength: 250),
                        Telefono = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CondicionIva", t => t.CondicionIvaId)
                .Index(t => t.CondicionIvaId);
            
            CreateTable(
                "dbo.CondicionIva",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        TipoComprobante = c.Int(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        EmpleadoId = c.Long(nullable: false),
                        ClienteId = c.Long(nullable: false),
                        ArticuloId = c.Long(nullable: false),
                        NombreVendedor = c.String(nullable: false),
                        NombreCliente = c.String(nullable: false),
                        CodigoProducto = c.Int(nullable: false),
                        DescripcionProducto = c.String(nullable: false, maxLength: 250),
                        NuevoStock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaVenta = c.DateTime(nullable: false),
                        PrecioArticulo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioArticuloStr = c.String(maxLength: 250),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MontoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MontoTotalStr = c.String(maxLength: 250),
                        Vuelto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.Persona_Empleado", t => t.EmpleadoId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ComprobanteId = c.Long(nullable: false),
                        ArticuloId = c.Long(nullable: false),
                        Codigo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iva = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                        Factura_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facturas", t => t.Factura_Id)
                .Index(t => t.Factura_Id);
            
            CreateTable(
                "dbo.Rubros",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnidadMedida",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Localidades",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ProvinciaId = c.Long(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provincias", t => t.ProvinciaId)
                .Index(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Localidades", "ProvinciaId", "dbo.Provincias");
            DropForeignKey("dbo.Articulo", "UnidadMedidaId", "dbo.UnidadMedida");
            DropForeignKey("dbo.Articulo", "RubroId", "dbo.Rubros");
            DropForeignKey("dbo.Compra", "ProveedorId", "dbo.Proveedor");
            DropForeignKey("dbo.Facturas", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Items", "Factura_Id", "dbo.Facturas");
            DropForeignKey("dbo.Facturas", "EmpleadoId", "dbo.Persona_Empleado");
            DropForeignKey("dbo.Facturas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Venta", "EmpleadoId", "dbo.Persona_Empleado");
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Articulo", "Venta_Id", "dbo.Venta");
            DropForeignKey("dbo.Proveedor", "CondicionIva_Id", "dbo.CondicionIva");
            DropForeignKey("dbo.Clientes", "CondicionIvaId", "dbo.CondicionIva");
            DropForeignKey("dbo.Usuario", "EmpleadoId", "dbo.Persona_Empleado");
            DropForeignKey("dbo.Compra", "EmpleadoId", "dbo.Persona_Empleado");
            DropForeignKey("dbo.Articulo", "Compra_Id", "dbo.Compra");
            DropForeignKey("dbo.Articulo", "ProveedorId", "dbo.Proveedor");
            DropForeignKey("dbo.Precios", "ListaPrecioId", "dbo.ListaPrecios");
            DropForeignKey("dbo.Precios", "ArticuloId", "dbo.Articulo");
            DropForeignKey("dbo.Articulo", "MarcaId", "dbo.Marcas");
            DropIndex("dbo.Localidades", new[] { "ProvinciaId" });
            DropIndex("dbo.Items", new[] { "Factura_Id" });
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            DropIndex("dbo.Venta", new[] { "EmpleadoId" });
            DropIndex("dbo.Clientes", new[] { "CondicionIvaId" });
            DropIndex("dbo.Facturas", new[] { "UsuarioId" });
            DropIndex("dbo.Facturas", new[] { "EmpleadoId" });
            DropIndex("dbo.Facturas", new[] { "ClienteId" });
            DropIndex("dbo.Usuario", new[] { "EmpleadoId" });
            DropIndex("dbo.Compra", new[] { "ProveedorId" });
            DropIndex("dbo.Compra", new[] { "EmpleadoId" });
            DropIndex("dbo.Proveedor", new[] { "CondicionIva_Id" });
            DropIndex("dbo.Precios", new[] { "ArticuloId" });
            DropIndex("dbo.Precios", new[] { "ListaPrecioId" });
            DropIndex("dbo.Articulo", new[] { "Venta_Id" });
            DropIndex("dbo.Articulo", new[] { "Compra_Id" });
            DropIndex("dbo.Articulo", new[] { "UnidadMedidaId" });
            DropIndex("dbo.Articulo", new[] { "ProveedorId" });
            DropIndex("dbo.Articulo", new[] { "RubroId" });
            DropIndex("dbo.Articulo", new[] { "MarcaId" });
            DropTable("dbo.Provincias");
            DropTable("dbo.Localidades");
            DropTable("dbo.UnidadMedida");
            DropTable("dbo.Rubros");
            DropTable("dbo.Items");
            DropTable("dbo.Venta");
            DropTable("dbo.CondicionIva");
            DropTable("dbo.Clientes");
            DropTable("dbo.Facturas");
            DropTable("dbo.Usuario");
            DropTable("dbo.Persona_Empleado");
            DropTable("dbo.Compra");
            DropTable("dbo.Proveedor");
            DropTable("dbo.ListaPrecios");
            DropTable("dbo.Precios");
            DropTable("dbo.Marcas");
            DropTable("dbo.Articulo");
        }
    }
}
