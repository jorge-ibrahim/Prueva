using Presentacion.Base.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Factura
{
    public class FacturaDto : BaseDto
    {

        public FacturaDto()
        {
            if (Items == null)
                Items = new List<ItemDto>();
        }
        public string ApellidoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApyNomCliente => $"{ApellidoCliente}, {NombreCliente}";
        public long ClienteFacturaId { get; set; }
        public string DniCliente { get; set; }

        public long CajaId { get; set; }

        public long EmpleadoId { get; set; }

        public long UsuarioId { get; set; }

        public string ApellidoEmpleado { get; set; }

        public string NombreEmpleado { get; set; }

        public string NombreUsuario { get; set; }

        public DateTime Fecha { get; set; }

        public int Numero { get; set; }

        public decimal SubTotal { get; set; }

        public string SubTotalStr => SubTotal.ToString("C");

        public decimal Descuento { get; set; }

        public string DescuentoStr => Descuento.ToString("C");

        public decimal Total { get; set; }

        public string TotalStr => Total.ToString();
        public decimal MontoPagado { get; set; }

        public TipoComprobante TipoComprobante { get; set; }

        public EstadoComprobante EstadoComprobante { get; set; }

        public decimal Iva21 { get; set; }

        public string Iva21Str => Iva21.ToString("C");

        public decimal Iva105 { get; set; }

        public string Iva105Str => Iva105.ToString("C");

        public List<ItemDto> Items { get; set; }

    }
}
