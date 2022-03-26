using Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using static Conexion.CadenaConexion;

namespace Conexion
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ObtenerCadenaConexion)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Empleado> Empleados { get; set; }
        public IDbSet<Cliente> Clientes { get; set; }
        public IDbSet<Proveedor> Proveedores { get; set; }
        public IDbSet<Marca> Marcas { get; set; }
        public IDbSet<Rubro> Rubros { get; set; }
        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<Articulo> Articulos { get; set; }
        public IDbSet<Provincia> Provincias { get; set; }
        public IDbSet<Localidad> Localidades { get; set; }
        public IDbSet<CondicionIva> CondicionIvas { get; set; }
        public IDbSet<ListaPrecio> ListaPrecios { get; set; }
        public IDbSet<Precio> Precios { get; set; }
        public IDbSet<UnidadMedida> UnidadMedidas { get; set; }
        public IDbSet<Venta> Ventas { get; set; }
        public IDbSet<Compra> Compras { get; set; }
       // public IDbSet<Comprobante> Comprobantes { get; set; }
       // public IDbSet<DetalleComprobante> DetalleComprobantes { get; set; }
        public IDbSet<Factura> Facturas { get; set; }
        public IDbSet<Item> Items { get; set; }
        public IDbSet<Caja> Cajas { get; set; }
        public IDbSet<Movimiento> Movimientos { get; set; }

    }
}
