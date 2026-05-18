using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Detalle_Ventas : Form
    {
        // para recargar automaticamente el grid de Ventas generales
        public event Action VentaGuardada;
        private int _idVenta = 0;
        private int _idCliente = 0;
        private decimal _montoTotal = 0;


        DataTable dtDetalle = new DataTable();
        float totalGeneral = 0;


        Cls_Ventas_Controlador controlador = new Cls_Ventas_Controlador();
        public Frm_Detalle_Ventas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Frm_Detalle_Ventas_Load(object sender, EventArgs e)
        {
            fun_EstadoInicial();
            fun_CargarClientes();
            fun_CargarSucursales();
            fun_CargarInventario();
            fun_CargarBodegas();
            //nuevo
            fun_InicializarDetalle();
            //nuevo para estado venta
            fun_CargarEstadoVenta();
            //nuevo para tipo operacion
            fun_CargarTipoOperacion();
            fun_CargarIdVenta();
            //Cbo_Id_Cliente.SelectedIndexChanged += Cbo_Id_Cliente_SelectedIndexChanged;
            Lbl_Fecha_Cotizacion_pedido.Visible = false;
            Dtp_fecha_cotizacion_pedido.Visible = false;
            Btn_Pagar.Enabled = false;

        }

        private void fun_CargarClientes()
        {
            try
            {
                Cbo_Id_Cliente.DataSource = controlador.ObtenerClientes();
                Cbo_Id_Cliente.DisplayMember = "NombreCompleto";
                Cbo_Id_Cliente.ValueMember = "Pk_Id_Cliente";
                Cbo_Id_Cliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }
        private void fun_CargarSucursales()
        {
            try
            {
                Cbo_Id_Sucursal.DataSource = controlador.ObtenerSucursales();
                Cbo_Id_Sucursal.DisplayMember = "NombreSucursal";
                Cbo_Id_Sucursal.ValueMember = "Pk_Id_Sucursal";
                Cbo_Id_Sucursal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message);
            }
        }

        private void fun_CargarInventario()
        {
            try
            {
                Cbo_Id_Inventario.DataSource = controlador.ObtenerInventario();
                Cbo_Id_Inventario.DisplayMember = "Producto";
                Cbo_Id_Inventario.ValueMember = "pk_inventario_id";
                Cbo_Id_Inventario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message);
            }
        }

        private void fun_CargarBodegas()
        {
            try
            {
                Cbo_Id_Bodega.DataSource = controlador.ObtenerBodegas();
                Cbo_Id_Bodega.DisplayMember = "NombreBodega";
                Cbo_Id_Bodega.ValueMember = "Pk_Id_Bodega";
                Cbo_Id_Bodega.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bodegas: " + ex.Message);
            }
        }

        private void fun_CargarUnidadMedida(int iIdProducto)
        {
            try
            {
                DataTable dt = controlador.ObtenerUnidadPorProducto(iIdProducto);

                Cbo_Unidad_Medida.DataSource = dt;
                Cbo_Unidad_Medida.DisplayMember = "UnidadMedida";
                Cbo_Unidad_Medida.ValueMember = "ID_Unidad";

                if (dt.Rows.Count > 0)
                    Cbo_Unidad_Medida.SelectedIndex = 0;
                else
                    Cbo_Unidad_Medida.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidad de medida: " + ex.Message);
            }
        }



        private void fun_InicializarDetalle()
        {
            dtDetalle.Columns.Clear();

            dtDetalle.Columns.Add("IdProducto", typeof(int));
            dtDetalle.Columns.Add("Producto", typeof(string));
            dtDetalle.Columns.Add("Descripcion", typeof(string));

            dtDetalle.Columns.Add("IdBodega", typeof(int));
            dtDetalle.Columns.Add("Bodega", typeof(string));

            dtDetalle.Columns.Add("IdUnidad", typeof(int));
            dtDetalle.Columns.Add("UnidadMedida", typeof(string));

            dtDetalle.Columns.Add("Precio", typeof(float));
            dtDetalle.Columns.Add("Cantidad", typeof(float));
            dtDetalle.Columns.Add("Descuento", typeof(float));
            //NUEVAS COLUMNAS
            dtDetalle.Columns.Add("TipoCliente", typeof(string));
            dtDetalle.Columns.Add("Subtotal", typeof(float));

            Dgv_Detalle_Venta.DataSource = dtDetalle;
        }


        private void fun_CargarIdVenta()
        {
            int id = controlador.ObtenerSiguienteIdVenta();

            Cbo_Id_Venta.Items.Clear();
            Cbo_Id_Venta.Items.Add(id);
            Cbo_Id_Venta.SelectedIndex = 0;
            Cbo_Id_Venta.Enabled = false; //Bloqueado
        }

        //NUEVO ESTADO VENTA
        private void fun_CargarEstadoVenta()
        {
            try
            {
                Cbo_Estado.Items.Clear();
                Cbo_Estado.Items.Add("Activo");
                Cbo_Estado.Items.Add("Inactivo");
                Cbo_Estado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estado: " + ex.Message);
            }
        }
        //NUEVO Tipo de operacion
        private void fun_CargarTipoOperacion()
        {
            try
            {
                Cbo_Tipo_Operacion.DataSource = controlador.ObtenerTipoOperacion();
                Cbo_Tipo_Operacion.DisplayMember = "TipoOperacion";
                Cbo_Tipo_Operacion.ValueMember = "TipoOperacion";
                Cbo_Tipo_Operacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipo operación: " + ex.Message);
            }
        }

        private void fun_EstadoInicial()
        {
            //BOTONES HABILITADOS
            Btn_Ingresar_Ventas.Enabled = true;
            Btn_Modificar_Ventas.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_buscar_Ventas.Enabled = true;
            Btn_Reporte_Ventas.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir_Dventas.Enabled = true;

            //BOTONES DESHABILITADOS
            Btn_Guardar_Ventas.Enabled = false;
            Btn_Cancelar_Ventas.Enabled = false;
            Btn_Pagar.Enabled = false;
            Btn_Agregar_Detalle_Ventas.Enabled = false;
            Btn_Remover_Detalle_Ventas.Enabled = false;
            Btn_Limpiar_Detalle_Ventas.Enabled = false;

            //CONTROLES BLOQUEADOS
            Cbo_Id_Venta.Enabled = false;
            Cbo_Id_Cliente.Enabled = false;
            Cbo_Id_Sucursal.Enabled = false;
            Cbo_Estado.Enabled = false;
            Cbo_Tipo_Operacion.Enabled = false;
            Cbo_Id_Inventario.Enabled = false;
            Cbo_Id_Bodega.Enabled = false;
            Nud_Cant_Prod.Enabled = false;
            Cbo_Unidad_Medida.Enabled = false;
            Dtp_Fecha_Venta.Enabled = false;

            Dgv_Detalle_Venta.Enabled = false;

            //IMPORTANTE: LIMPIAR DATOS
            dtDetalle.Clear(); // limpia grid
            Txt_Saldo_Total.Text = "0.00";
            totalGeneral = 0;

            Cbo_Id_Cliente.SelectedIndex = -1;
            Cbo_Id_Sucursal.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Cbo_Tipo_Operacion.SelectedIndex = -1;
            Cbo_Id_Inventario.SelectedIndex = -1;
            Cbo_Id_Bodega.SelectedIndex = -1;
            Nud_Cant_Prod.Value = 1;

            // LIMPIAR UNIDAD DE MEDIDA
            Cbo_Unidad_Medida.DataSource = null;
            Cbo_Unidad_Medida.Items.Clear();
            Cbo_Unidad_Medida.SelectedIndex = -1;
            Cbo_Unidad_Medida.Enabled = false;

            //RECARGAR ID
            fun_CargarIdVenta();
        }


        private void Btn_Ingresar_Ventas_Click(object sender, EventArgs e)
        {
            // HABILITAR CONTROLES
            Cbo_Id_Cliente.Enabled = true;
            Cbo_Id_Sucursal.Enabled = true;
            Cbo_Estado.Enabled = true;
            Dtp_Fecha_Venta.Enabled = true;
            Cbo_Tipo_Operacion.Enabled = true;
            Cbo_Id_Inventario.Enabled = true;
            Cbo_Id_Bodega.Enabled = true;
            Nud_Cant_Prod.Enabled = true;
            Cbo_Unidad_Medida.Enabled = true;
            Dgv_Detalle_Venta.Enabled = true;

            //ID SIEMPRE BLOQUEADO
            Cbo_Id_Venta.Enabled = false;

            //LIMPIAR ENCABEZADO
            Cbo_Id_Cliente.SelectedIndex = -1;
            Cbo_Id_Sucursal.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Cbo_Tipo_Operacion.SelectedIndex = -1;
            Cbo_Id_Inventario.SelectedIndex = -1;
            Cbo_Id_Bodega.SelectedIndex = -1;

            // LIMPIAR DETALLE
            dtDetalle.Clear();
            totalGeneral = 0;
            Txt_Saldo_Total.Text = "0.00";
            Nud_Cant_Prod.Value = 1;

            //GENERAR NUEVO ID
            fun_CargarIdVenta();

            //BOTONES
            Btn_Guardar_Ventas.Enabled = true;
            Btn_Cancelar_Ventas.Enabled = true;

            Btn_Ingresar_Ventas.Enabled = false;
            Btn_Modificar_Ventas.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_buscar_Ventas.Enabled = false;
        }
        private void Dgv_Detalle_Venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Modificar_Ventas_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Ventas_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR ENCABEZADO
                if (Cbo_Id_Cliente.SelectedIndex == -1 ||
                    Cbo_Id_Sucursal.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(Cbo_Estado.Text) ||
                    string.IsNullOrWhiteSpace(Cbo_Tipo_Operacion.Text))
                {
                    MessageBox.Show("Debe completar el encabezado de la venta.");
                    return;
                }

                // VALIDAR DETALLE
                if (dtDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar productos a la venta.");
                    return;
                }

                float fSaldo_total = 0;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    fSaldo_total += Convert.ToSingle(row["Subtotal"]);
                }

                int iFk_Id_Sucursal = Convert.ToInt32(Cbo_Id_Sucursal.SelectedValue);
                int iFk_Id_Cliente = Convert.ToInt32(Cbo_Id_Cliente.SelectedValue);
                DateTime dCmp_Fecha_Venta = Dtp_Fecha_Venta.Value;
                string sCmp_Estado_Venta = Cbo_Estado.SelectedValue?.ToString();
                string sCmp_Tipo_Operacion = Cbo_Tipo_Operacion.SelectedValue?.ToString();
                bool bEsVenta = sCmp_Tipo_Operacion == "Venta";

                // FECHA ESPECIAL (entrega o cotización)
                DateTime dFecha_Especial = Dtp_fecha_cotizacion_pedido.Value;

                // FECHA VENCIMIENTO PARA CUENTA (30 días después)
                DateTime dCmp_Fecha_Vencimiento = dCmp_Fecha_Venta.AddDays(30);
                   _idVenta = Convert.ToInt32(Cbo_Id_Venta.SelectedItem ?? 0);
                _montoTotal = Convert.ToDecimal(fSaldo_total);
                // GUARDAR
                bool resultado = controlador.GuardarVenta(
                    dCmp_Fecha_Venta,
                    iFk_Id_Cliente,
                    iFk_Id_Sucursal,
                    sCmp_Estado_Venta,
                    sCmp_Tipo_Operacion,
                    fSaldo_total,
                    dtDetalle,
                    dFecha_Especial,         // ← Para tbl_ventas (entrega/cotización)
                    dCmp_Fecha_Vencimiento,  // ← Para cuenta por cobrar
                    bEsVenta
                );
              
             
                if (resultado)
                {
                    // BITACORA
                    Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

                    string accionBitacora = "";

                    if (sCmp_Tipo_Operacion == "Venta")
                    {
                        accionBitacora = "Se registró una venta";
                    }
                    else if (sCmp_Tipo_Operacion == "Pedido")
                    {
                        accionBitacora = "Se registró un pedido";
                    }
                    else if (sCmp_Tipo_Operacion == "Cotizacion")
                    {
                        accionBitacora = "Se generó una cotización";
                    }

                    bitacora.RegistrarAccion(
                        Cls_Usuario_Conectado.iIdUsuario,
                        710,
                        accionBitacora,
                        true
                    );
                    MessageBox.Show("Registro guardado correctamente.");
                    fun_CargarInventario(); 
                    // LIMPIAR
                    dtDetalle.Clear();
                    Txt_Saldo_Total.Text = "0.00";
                    Cbo_Id_Cliente.SelectedIndex = -1;
                    Cbo_Id_Sucursal.SelectedIndex = -1;
                    Cbo_Estado.SelectedIndex = -1;
                    Cbo_Tipo_Operacion.SelectedIndex = -1;
                    Cbo_Id_Inventario.SelectedIndex = -1;
                    Cbo_Id_Bodega.SelectedIndex = -1;
                    Nud_Cant_Prod.Value = 1;

                    // LIMPIAR UNIDAD DE MEDIDA
                    Cbo_Unidad_Medida.DataSource = null;
                    Cbo_Unidad_Medida.Items.Clear();
                    Cbo_Unidad_Medida.SelectedIndex = -1;
                    Cbo_Unidad_Medida.Enabled = false;

                    fun_CargarIdVenta();
                    VentaGuardada?.Invoke();

                    if (bEsVenta)
                    {
                        MessageBox.Show("Se ha registrado una cuenta por cobrar.");
                        Btn_Pagar.Enabled = true;
                    }
                    else if (sCmp_Tipo_Operacion == "Pedido")
                    {
                        MessageBox.Show("Pedido registrado correctamente.");
                    }
                    else if (sCmp_Tipo_Operacion == "Cotizacion")
                    {
                        MessageBox.Show("Cotización generada correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Btn_Cancelar_Ventas_Click(object sender, EventArgs e)
        {
            fun_EstadoInicial();

            dtDetalle.Clear();

            totalGeneral = 0;
            Txt_Saldo_Total.Text = "0.00";

            Cbo_Id_Cliente.SelectedIndex = -1;
            Cbo_Id_Sucursal.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Cbo_Tipo_Operacion.SelectedIndex = -1;
            Cbo_Id_Inventario.SelectedIndex = -1;
            Cbo_Id_Bodega.SelectedIndex = -1;

            Nud_Cant_Prod.Value = 1;

            // LIMPIAR UNIDAD DE MEDIDA
            Cbo_Unidad_Medida.DataSource = null;
            Cbo_Unidad_Medida.Items.Clear();
            Cbo_Unidad_Medida.SelectedIndex = -1;
            Cbo_Unidad_Medida.Enabled = false;

            fun_CargarIdVenta();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Ventas_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_Id_Inventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Inventario.SelectedIndex == -1 ||
                    Cbo_Id_Inventario.SelectedValue == null ||
                    Cbo_Id_Inventario.SelectedValue is DataRowView)
                {
                    // Limpiar dependientes
                    Cbo_Id_Bodega.DataSource = null;
                    Cbo_Unidad_Medida.DataSource = null;
                    return;
                }

                if (!(Cbo_Id_Inventario.SelectedItem is DataRowView row))
                    return;

                int iIdProducto = Convert.ToInt32(row["pk_inventario_id"]);

                //LIMPIAR ANTES DE RECARGAR
                Cbo_Id_Bodega.DataSource = null;
                Cbo_Unidad_Medida.DataSource = null;

                //BODEGA
                DataTable dtBodegas = controlador.ObtenerBodegasPorProducto(iIdProducto);

                if (dtBodegas.Rows.Count > 0)
                {
                    Cbo_Id_Bodega.DataSource = dtBodegas;
                    Cbo_Id_Bodega.DisplayMember = "NombreBodega";
                    Cbo_Id_Bodega.ValueMember = "Pk_Id_Bodega";
                    Cbo_Id_Bodega.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Este producto no tiene stock en ninguna bodega.");
                }

                //UNIDAD
                DataTable dtUnidad = controlador.ObtenerUnidadPorProducto(iIdProducto);

                if (dtUnidad.Rows.Count > 0)
                {
                    Cbo_Unidad_Medida.DataSource = dtUnidad;
                    Cbo_Unidad_Medida.DisplayMember = "UnidadMedida";
                    Cbo_Unidad_Medida.ValueMember = "ID_Unidad";
                    Cbo_Unidad_Medida.SelectedIndex = 0;
                }
                else
                {
                    if (Cbo_Id_Inventario.Focused)
                    {
                        MessageBox.Show("El producto no tiene unidad de medida.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Btn_Agregar_Detalle_Ventas_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR ENCABEZADO
                if (string.IsNullOrWhiteSpace(Cbo_Id_Venta.Text) ||
                    Cbo_Id_Cliente.SelectedIndex == -1 ||
                    Cbo_Id_Sucursal.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(Cbo_Estado.Text) ||
                    string.IsNullOrWhiteSpace(Cbo_Tipo_Operacion.Text))
                {
                    MessageBox.Show("Debe completar el encabezado de la venta.");
                    return;
                }

                if (!(Cbo_Id_Inventario.SelectedItem is DataRowView row))
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                if (!(Cbo_Id_Bodega.SelectedItem is DataRowView rowBodega))
                {
                    MessageBox.Show("Seleccione una bodega.");
                    return;
                }

                if (!(Cbo_Unidad_Medida.SelectedItem is DataRowView rowUnidad))
                {
                    MessageBox.Show("Seleccione unidad de medida.");
                    return;
                }

                if (Nud_Cant_Prod.Value <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }


                //OBTENER CLIENTE
                int iFk_Id_Cliente = Convert.ToInt32(Cbo_Id_Cliente.SelectedValue);

                // PRODUCTO
                int iIdProducto = Convert.ToInt32(row["pk_inventario_id"]);
                string sProducto = row["nombre_prod"].ToString();
                string sDescripcion = row["descripcion"].ToString();
                float fPrecio = Convert.ToSingle(row["precio_unitario"]);
                float fCantidad = Convert.ToInt32(Nud_Cant_Prod.Value);

                // BODEGA
                int iIdBodega = Convert.ToInt32(rowBodega["Pk_Id_Bodega"]);
                string sBodega = rowBodega["Cmp_Nombre_Bodega"].ToString();

                //UNIDAD DE MEDIDA
                int iIdUnidad = Convert.ToInt32(rowUnidad["ID_Unidad"]);
                string sUnidad = rowUnidad["Nombre_Unidad"].ToString();

                // DESCUENTO
                var info = controlador.ObtenerDescuentoCliente(iFk_Id_Cliente, fCantidad);

                // SUBTOTAL
                float subtotal = controlador.CalcularSubtotal(fPrecio, fCantidad, info.fDescuento);

                // GRID
                dtDetalle.Rows.Add(
                    iIdProducto,
                    sProducto,
                    sDescripcion,
                    iIdBodega,
                    sBodega,
                    iIdUnidad,
                    sUnidad,
                    fPrecio,
                    fCantidad,
                    info.fDescuento,
                    info.sTipoCliente,
                    subtotal
                );

                // TOTAL
                totalGeneral = controlador.CalcularTotal(dtDetalle);
                Txt_Saldo_Total.Text = "Q " + totalGeneral.ToString("0.00");

                // ORDENAR
                dtDetalle.DefaultView.Sort = "IdProducto ASC";
                Dgv_Detalle_Venta.DataSource = dtDetalle.DefaultView;

                // LIMPIAR
                Cbo_Id_Inventario.SelectedIndex = -1;
                Cbo_Id_Bodega.SelectedIndex = -1;
                Nud_Cant_Prod.Value = 1;

                _montoTotal = Convert.ToDecimal(totalGeneral);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya datos en la venta
                if (Cbo_Id_Venta.SelectedIndex == -1)
                {
                    MessageBox.Show("Primero guarde la venta.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_montoTotal <= 0)
                {
                    MessageBox.Show("El monto debe ser mayor a cero.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el ID de la venta

                int idVenta = _idVenta;

                if (idVenta == 0)
                {
                    MessageBox.Show("No se pudo obtener el ID de la venta.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                // El controlador ya maneja los errores y mensajes
                int idCXC = controlador.ObtenerIdCXCPorVenta(idVenta);

                if (idCXC == 0)
                {
                    return; // El controlador ya mostró el mensaje
                }

                // SOLO 2 PARÁMETROS (como tu constructor)
                using (var frmPagos = new Frm_Pagos(idCXC, (decimal)_montoTotal))
                {
                    frmPagos.StartPosition = FormStartPosition.CenterParent;
                    frmPagos.ShowDialog();
                }

                MessageBox.Show("Pago procesado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir formulario de pagos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_Id_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Cliente.SelectedIndex == -1)
                    return;

                // EVITAR DataRowView
                if (Cbo_Id_Cliente.SelectedValue == null ||
                    Cbo_Id_Cliente.SelectedValue is DataRowView)
                    return;

                int iFk_Id_Cliente = Convert.ToInt32(Cbo_Id_Cliente.SelectedValue);

                var resultado = controlador.ValidarClienteVendedor(iFk_Id_Cliente);

                if (resultado.tieneVendedor)
                {
                    MessageBox.Show("Cliente atendido por el vendedor: " + resultado.Cmp_NombreVendedor);

                    Cbo_Id_Sucursal.Enabled = true;
                    Cbo_Estado.Enabled = true;
                    Cbo_Tipo_Operacion.Enabled = true;
                    Cbo_Id_Inventario.Enabled = true;
                    Cbo_Id_Bodega.Enabled = true;
                    Nud_Cant_Prod.Enabled = true;
                    Cbo_Unidad_Medida.Enabled = true;
                    Btn_Agregar_Detalle_Ventas.Enabled = true;
                    Btn_Remover_Detalle_Ventas.Enabled = true;
                    Btn_Limpiar_Detalle_Ventas.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Este cliente no tiene un vendedor asignado.");

                    Cbo_Id_Sucursal.Enabled = false;
                    Cbo_Estado.Enabled = false;
                    Cbo_Tipo_Operacion.Enabled = false;
                    Cbo_Id_Inventario.Enabled = false;
                    Cbo_Id_Bodega.Enabled = false;
                    Nud_Cant_Prod.Enabled = false;
                    Cbo_Unidad_Medida.Enabled = false;
                    Btn_Agregar_Detalle_Ventas.Enabled = false;
                    Btn_Remover_Detalle_Ventas.Enabled = false;
                    Btn_Limpiar_Detalle_Ventas.Enabled = false;
                    Dtp_Fecha_Venta.Enabled = false;
                    Dgv_Detalle_Venta.Enabled = false;
                    Cbo_Id_Cliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Dventas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Remover_Detalle_Ventas_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Detalle_Venta.CurrentRow == null || Dgv_Detalle_Venta.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Seleccione una fila para eliminar.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este producto?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    int index = Dgv_Detalle_Venta.CurrentRow.Index;

                    //Eliminar del DataTable (NO del grid directo)
                    dtDetalle.Rows.RemoveAt(index);

                    //Recalcular total
                    totalGeneral = controlador.CalcularTotal(dtDetalle);
                    Txt_Saldo_Total.Text = "Q " + totalGeneral.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Btn_Limpiar_Detalle_Ventas_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar DataTable (esto limpia el DataGrid automáticamente)
                dtDetalle.Clear();

                // Resetear total
                totalGeneral = 0;
                Txt_Saldo_Total.Text = "0.00";

                // Limpiar combos
                Cbo_Id_Cliente.SelectedIndex = -1;
                Cbo_Id_Sucursal.SelectedIndex = -1;
                Cbo_Estado.SelectedIndex = -1;
                Cbo_Tipo_Operacion.SelectedIndex = -1;
                Cbo_Id_Inventario.SelectedIndex = -1;
                Cbo_Id_Bodega.SelectedIndex = -1;

                // LIMPIAR UNIDAD DE MEDIDA
                Cbo_Unidad_Medida.DataSource = null;
                Cbo_Unidad_Medida.Items.Clear();
                Cbo_Unidad_Medida.SelectedIndex = -1;
                Cbo_Unidad_Medida.Enabled = false;

                // Reset cantidad
                Nud_Cant_Prod.Value = 1;

                Cbo_Unidad_Medida.Enabled = false;
                // Nuevo ID de venta
                fun_CargarIdVenta();

                MessageBox.Show("Formulario limpiado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message);
            }
        }

        private void Cbo_Tipo_Operacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbo_Tipo_Operacion.SelectedIndex == -1)
            {
                Lbl_Fecha_Cotizacion_pedido.Visible = false;
                Dtp_fecha_cotizacion_pedido.Visible = false;
                return;
            }

            string Stipo = Cbo_Tipo_Operacion.SelectedValue.ToString();
            switch (Stipo)
            {
                case "Cotizacion":

                    Lbl_Fecha_Cotizacion_pedido.Visible = true;
                    Dtp_fecha_cotizacion_pedido.Visible = true;
                    Btn_Pagar.Enabled = false;
                    break;

                case "Pedido":
                    Lbl_Fecha_Cotizacion_pedido.Text = "Fecha de entrega : ";
                    Lbl_Fecha_Cotizacion_pedido.Visible = true;
                    Dtp_fecha_cotizacion_pedido.Visible = true;
                    Btn_Pagar.Enabled = false;
                    break;
                case "Venta":
                    Lbl_Fecha_Cotizacion_pedido.Visible = false;
                    Dtp_fecha_cotizacion_pedido.Visible = false;
                    Btn_Pagar.Enabled = true;
                    break;
            }
        }
    }
    //Brandon Hernandez  -- Seleccion de cotizacion y pedidos 
}


