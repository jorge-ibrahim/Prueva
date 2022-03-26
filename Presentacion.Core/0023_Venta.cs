using Presentacion.Base;
using Presentacion.Base.Clases;
using Servicios.Articulo;
using Servicios.Cliente;
using Servicios.CondicionIva;
using Servicios.Empleado;
using Servicios.Factura;
using Servicios.ListaPrecio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Core
{
    public partial class _0023_Venta : FormularioBase
    {
        private ArticuloLogica _articuloLogica;
        private ClienteLogica _clienteLogica;
        private ListaPrecioLogica _listaPrecioLogica;
        private CondicionIvaLogica _condicionIvaLogica;
        private FacturaView _factura; //seria como mi clase Venta
        private FacturaServicio _facturaLogica;
        private EmpleadoLogica _empleadoLogica;
        private ClienteDto _cliente;
        private EmpleadoDto _empleado;
        private ItemsView _itemSeleccionado;
        private decimal _cantidad;
 
        public _0023_Venta()
        {
            InitializeComponent();
            _articuloLogica = new ArticuloLogica();
            _clienteLogica = new ClienteLogica();
            _listaPrecioLogica = new ListaPrecioLogica();
            _condicionIvaLogica = new CondicionIvaLogica();
            _empleadoLogica = new EmpleadoLogica();
            _factura = new FacturaView();
            _factura.VendedorId = Identidad.EmpleadoId;
            _factura.ApyNomVendedor = Identidad.ApyNomUsuarioLogin;
            _empleado = new EmpleadoDto();
            _facturaLogica = new FacturaServicio();

            _itemSeleccionado = null;
            _cantidad = 1;

            CargarDatos();

        }       

        //BOTONES=================================================================
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            var formulario = new _0032_LoockUpEmpleado();
            formulario.ShowDialog();

            if (formulario.EntidadSeleccionada != null)
            {
                var empleadoSeleccionado = (EmpleadoDto)formulario.EntidadSeleccionada;
                CargarDatosVendedor(empleadoSeleccionado);
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var fLookUpCliente = new _0033_LoockUpCliente();
            fLookUpCliente.ShowDialog();
            if (fLookUpCliente.EntidadSeleccionada != null)
            {
                var clienteSeleccionado = (ClienteDto)fLookUpCliente.EntidadSeleccionada;
                CargarDatosCliente(clienteSeleccionado);
            }
        }
        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {//Error del loockup que traia automaticamnete el producto sin seleccionar se soluciono cuando cambie el .show() por el .showdialog()
            var floockUpArticulo = new _0031_LoockUpArticulo();
            floockUpArticulo.ShowDialog();
            if (floockUpArticulo.EntidadSeleccionada != null)
            {
                var entidad = (ArticuloDto)floockUpArticulo.EntidadSeleccionada;
                //AgregarProducto(((ArticuloDto)floockUpArticulo.EntidadSeleccionada).CodigoBarra, (long)cmbListaPrecio.SelectedValue);
                var articulo = _articuloLogica.ObtenerPorCodigo(entidad.CodigoBarra, (long)cmbListaPrecio.SelectedValue);

                var item = _factura.Items.FirstOrDefault(x => x.ArticuloId == articulo.Id && x.ListaPrecioId == (long)cmbListaPrecio.SelectedValue);

                if (item == null)//item nuevo
                {
                    _factura.Items.Add(new ItemsView
                    {
                        ArticuloId = articulo.Id,//itemview y articuloventadto
                        PrecioArticulo = articulo.PrecioArticulo,
                        CodigoArticulo = articulo.CodigoArticulo,
                        CodigoBarraArticulo = articulo.CodigoBarraArticulo,
                        DescripcionArticulo = articulo.DescripcionArticulo,
                        DetalleArticulo = articulo.DetalleArticulo,
                        Stock = articulo.Stock,
                        ListaPrecioId = (long)cmbListaPrecio.SelectedValue,
                        Cantidad = _cantidad
                    });
                }
                else//item existente => actualizar cantidad
                {
                    item.Cantidad += 1;
                }
                ActualizarTotales();
                PoblarGrillaItems();
                txtCodigoArticulo.Clear();
                txtCodigoArticulo.Focus();
            }
        }
        private void btnCambioCantidad_Click(object sender, EventArgs e)
        {
            
            if (dgvGrilla.RowCount <= 0) return;
            if (_itemSeleccionado == null) return;

            decimal ca = _itemSeleccionado.Cantidad;

            var fCantidadNueva = new _0036_CambioCantidadAriticulo(ca);
            fCantidadNueva.ShowDialog();

            var articulo = _articuloLogica.ObtenerPorCodigo(_itemSeleccionado.CodigoBarraArticulo, _itemSeleccionado.ListaPrecioId);
            if (fCantidadNueva.NuevaCantidad != 0)
                _cantidad = fCantidadNueva.NuevaCantidad - ca;

            AgregarProducto(articulo.CodigoBarraArticulo, _cantidad, _itemSeleccionado.ListaPrecioId);
            _cantidad = 1;
        }
        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar la Venta?", "Atencion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
        private void btnConsultaVentas_Click(object sender, EventArgs e)
        {
            var consultaV = new _0022_ConsultaVenta();
            consultaV.ShowDialog();
        }
        private void btnPendientes_Click(object sender, EventArgs e)
        {
            var pendientes = new _0034_PendientesDePagos();
            pendientes.ShowDialog();
        }
        private void btnCancelarLinea_Click_1(object sender, EventArgs e)
        {
            if (_itemSeleccionado != null)
            {
                if (MessageBox.Show("Desea eliminar el Item de la Lista?",
                    "Atención",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    _factura.Items.Remove(_itemSeleccionado);
                    _itemSeleccionado = null;
                    CargarDatosItems();
                    ActualizarTotales();
                }
            }
        }
        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            if(_factura.Items.Count > 0)
            {
                _facturaLogica.Grabar(new FacturaDto
                {
                    EmpleadoId = _factura.VendedorId,
                    UsuarioId = _factura.UsuarioId,
                    Fecha = _factura.Fecha,
                    Numero = _factura.Numerofactura,
                    SubTotal = _factura.Subtotal,
                    Descuento = _factura.MontoDescuento,
                    Total = _factura.Total,
                    TipoComprobante = _factura.TipoComprobante,
                    EstadoComprobante = EstadoComprobante.Pendiente,

                    Iva105 = _factura.Iva105,
                    Iva21 = _factura.Iva21,

                    ClienteFacturaId = _factura.ClienteId,
                    Items = CargarItemsView()
                });
                LimpiarParaNuevaFactura();
                MessageBox.Show("La Venta se Facturo Correctamente.");
            }                   
        }        

        //METODOS=================================================================
        private void CargarDatos()
        {
            CargarDatosCabecera();
            CargarDatosItems();
            CargarDatosPie();
        }
        public void CargarDatosItems()
        {
            dgvGrilla.DataSource = _factura.Items.ToList();
            FormatearGrilla(dgvGrilla);
            txtCodigoArticulo.Clear();
            txtCodigoArticulo.Focus();
        }
        private void CargarDatosCabecera() 
        {

            try
            {
                //Datos del Tipo de Factura/Comprobante
                PoblarComboBox(cmbTipoComprobante, Enum.GetValues(typeof(TipoComprobante)));
                cmbTipoComprobante.SelectedItem = TipoComprobante.B;

                txtNumeroFactura.Text = _facturaLogica.ObtenerSiguienteNumeroFactura().ToString();
                _factura.Numerofactura = Convert.ToInt32(txtNumeroFactura.Text);
                //FECHA FACTURA
                _factura.Fecha = DateTime.Now;
                dtpFechaFactura.Value = _factura.Fecha;

                _factura.UsuarioId = Identidad.UsuarioLogueadoId;
                //Lista de Precios
                var listap = _listaPrecioLogica.Obtener(string.Empty);
                PoblarComboBox(cmbListaPrecio, listap, "Descripcion", "Id");

                //Datos del Vendedor

                txtVendedor.Text = Identidad.ApyNomUsuarioLogin;

                //Datos Del Cliente
              
                var condicion = _condicionIvaLogica.Obtener(string.Empty);
                PoblarComboBox(cmbCondicionIva, condicion, "Descripcion", "Id");
                cmbCondicionIva.SelectedItem = TipoComprobante.B;

                txtApyNomCliente.Text = "Consumidor Final";
                txtDireccionCliente.Text = "Sin Direccion";
                txtDniCuitCuilCliente.Text = "9999999";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop)
                ;
                Close();
            }           
        }
        private void CargarDatosPie()
        {
            nudPorcentajeDescuento.Value = 0;
            txtVendedor.Text = _empleado.ApyNom;
            dtpFechaFactura.Value = DateTime.Now;
        }
        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgvGrilla.Columns["CodigoArticulo"].Visible = true;//elementos del itemview
            dgvGrilla.Columns["CodigoArticulo"].HeaderText = "CODIGO";
            dgvGrilla.Columns["CodigoArticulo"].Width = 100;
            //dgvGrilla.Columns["CodigoArticulo"].DefaultCellStyle.BackColor = Color.Red; //Celda color Rojo

            dgvGrilla.Columns["CodigoBarraArticulo"].Visible = true;
            dgvGrilla.Columns["CodigoBarraArticulo"].HeaderText = "CODIGO DE BARRAS";
            dgvGrilla.Columns["CodigoBarraArticulo"].Width = 100;

            dgvGrilla.Columns["DescripcionArticulo"].Visible = true;
            dgvGrilla.Columns["DescripcionArticulo"].HeaderText = "DESCRIPCION PRODUCTO";
            dgvGrilla.Columns["DescripcionArticulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["DetalleArticulo"].Visible = true;
            dgvGrilla.Columns["DetalleArticulo"].HeaderText = "DETALLE PRODUCTO";
            dgvGrilla.Columns["DetalleArticulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGrilla.Columns["Stock"].Visible = true;
            dgvGrilla.Columns["Stock"].HeaderText = "STOCK DISPONIBLE";
            dgvGrilla.Columns["Stock"].Width = 100;

            dgvGrilla.Columns["Cantidad"].Visible = true;
            dgvGrilla.Columns["Cantidad"].HeaderText = "CANTIDAD";
            dgvGrilla.Columns["Cantidad"].Width = 100;

            dgvGrilla.Columns["PrecioProductoStr"].Visible = true;
            dgvGrilla.Columns["PrecioProductoStr"].HeaderText = "PRECIO";
            dgvGrilla.Columns["PrecioProductoStr"].Width = 100;

            dgvGrilla.Columns["SubtotalStr"].Visible = true;
            dgvGrilla.Columns["SubtotalStr"].HeaderText = "SUB-TOTAL";
            dgvGrilla.Columns["SubtotalStr"].Width = 100;
        }
        private void CargarDatosVendedor(EmpleadoDto vendedor)
        {
            //Datos internos para el formulario
            _empleado.Id = vendedor.Id;
            _empleado.Apellido = vendedor.Apellido;
            _empleado.Nombre = vendedor.Nombre;
            _empleado.Legajo = vendedor.Legajo;


            //Datos para la factura
            _factura.VendedorId = vendedor.Id;
            _factura.UsuarioId = Identidad.UsuarioLogueadoId;
            _factura.ApyNomVendedor = vendedor.ApyNom;
            
            //Datos a mostrar en el formulario
            txtVendedor.Text = _empleado.ApyNom;
        }
        private void CargarDatosCliente(ClienteDto cliente)
        {
            //Datos para la Factura
            _factura.DireccionCliente = cliente.Domicilio;
            _factura.CuilCliente = cliente.Cuil;
            _factura.ApyNomCliente = cliente.ApyNom;
            _factura.ClienteId = cliente.Id;
            _factura.CondicionIvaClienteId = cliente.CondicionIvaId;
            //Datos a mostrar en el formulario
            txtApyNomCliente.Text = cliente.ApyNom;
            txtDireccionCliente.Text = cliente.Domicilio;
            txtDniCuitCuilCliente.Text = cliente.Cuil;
            cmbCondicionIva.SelectedValue = cliente.CondicionIvaId;
        }
        private void AgregarProducto(string codigoProducto, decimal cantidad, long listaPrecioId)//Agregar Items a la Factura
        {
            var articulo = _articuloLogica.ObtenerPorCodigo(codigoProducto, listaPrecioId);//articulo sera una articuloventadto

            if (articulo != null)
            {
                if(articulo.Stock >= cantidad)
                {
                    var item = _factura.Items.FirstOrDefault(x => x.ArticuloId == articulo.Id && x.ListaPrecioId == listaPrecioId);

                    if (item == null)//item nuevo
                    {
                        _factura.Items.Add(new ItemsView
                        {
                            ArticuloId = articulo.Id,//itemview y articuloventadto
                            PrecioArticulo = articulo.PrecioArticulo,
                            CodigoArticulo = articulo.CodigoArticulo,
                            CodigoBarraArticulo = articulo.CodigoBarraArticulo,
                            DescripcionArticulo = articulo.DescripcionArticulo,
                            DetalleArticulo = articulo.DetalleArticulo,
                            Stock = articulo.Stock,
                            ListaPrecioId = listaPrecioId,
                            Cantidad = cantidad
                        });

                    }
                    else//item existente => actualizar cantidad
                    {
                        item.Cantidad += _cantidad;
                    }
                    ActualizarTotales();
                    PoblarGrillaItems();
                    txtCodigoArticulo.Clear();
                    txtCodigoArticulo.Focus();
                }
                else
                {
                    MessageBox.Show($"No Existe el Stock suficiente del Articulo {articulo.DescripcionArticulo}");
                }
                              
            }
            else
            {
                //MessageBox.Show("El Codigo Ingresado no pertenece a un Articulo");
                var floockUpArticulo = new _0031_LoockUpArticulo();
                floockUpArticulo.ShowDialog();
                if (floockUpArticulo.EntidadSeleccionada != null)
                {
                    AgregarProducto(((ArticuloDto)floockUpArticulo.EntidadSeleccionada).CodigoBarra,cantidad, (long)cmbListaPrecio.SelectedValue);
                }
            }
        }
        private void PoblarGrillaItems()
        {
            dgvGrilla.DataSource = _factura.Items.ToList();
            FormatearGrilla(dgvGrilla);           
        }
        private void LimpiarParaNuevaFactura()
        {
            _factura.Items.RemoveAll(x => x.Cantidad != 0);
            CargarDatosItems();
            ActualizarTotales();
            CargarDatosCabecera();
            // 1 Paso: Obtener la Fecha Actual y poner  en formato corto
            //dtpFechaFactura.Value = DateTime.Now.ToShortDateString();
            // 2 Paso: Obtener el siguiente numero de factura

           // _factura.Numero = FacturaServicio.ObtenerSiguienteNumeroDeFactura();
           // txtNumeroFactura.Text = _factura.Numero.ToString();
        }
        private List<ItemDto> CargarItemsView()
        {
            var _items = new List<ItemDto>();
            foreach(var item in _factura.Items)
            {
                _items.Add(new ItemDto
                {
                    ArticuloId = item.ArticuloId,
                    Codigo = item.CodigoBarraArticulo,
                    Descripcion = item.DescripcionArticulo,
                    Cantidad = item.Cantidad,
                    Precio = item.PrecioArticulo,
                    Iva = item.Iva105 + item.Iva21,
                    SubTotal = item.Subtotal
                });
            }
            return _items;
        }

        //EVENTOS==================================================================


        private void _0023_Venta_Activated(object sender, EventArgs e)//evento que inicializa en el txtcodigo producto
        {
            txtCodigoArticulo.Clear();
            txtCodigoArticulo.Focus();
        }
        private void txtCodigoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtCodigoArticulo.Text))
                {
                    MessageBox.Show("Por favor ingrese un codigo de Articulo");
                    return;
                }
                AgregarProducto(txtCodigoArticulo.Text,_cantidad,(long)cmbListaPrecio.SelectedValue);
                ActualizarTotales();
            }
        }      
        private void ActualizarTotales()
        {
            _factura.PorcentajeDescuento = nudPorcentajeDescuento.Value;
            txtSubTotal.Text = _factura.Subtotal.ToString("C");
            txtTotal.Text = _factura.Total.ToString("C");
            txtMontoDescuento.Text = _factura.PorcentajeDescuento.ToString("C");
        }
        private void nudPorcentajeDescuento_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }
        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                _itemSeleccionado = (ItemsView)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _itemSeleccionado = null;
            }
        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _0023_Venta_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = Identidad.ApyNomUsuarioLogin;
        }
    }
}
