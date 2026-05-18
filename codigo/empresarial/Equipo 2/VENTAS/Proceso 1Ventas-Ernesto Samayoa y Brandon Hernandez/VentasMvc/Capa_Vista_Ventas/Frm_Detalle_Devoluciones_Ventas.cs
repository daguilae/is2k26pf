using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Detalle_Devoluciones_Ventas : Form
    {
        // para recargar automaticamente el grid de Ventas generales
        public event Action DevolucionGuardada;
        private int _idVenta = 0;
        private int _idCliente = 0;
        private decimal _montoTotal = 0;


        DataTable dtDetalle = new DataTable();
        float totalGeneral = 0;


        Cls_Devolucion_Ventas_Controlador controlador = new Cls_Devolucion_Ventas_Controlador();
        public Frm_Detalle_Devoluciones_Ventas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Frm_Detalle_Devoluciones_Ventas_Load(object sender, EventArgs e)
        {
            fun_EstadoInicial();
            fun_CargarIdDevolucion();
            fun_CargarVentas();
            fun_CargarEstado();

            fun_InicializarDetalle();
            //temporalmente
            //Cbo_Id_Cliente.Enabled = false;
            //Cbo_Id_Sucursal.Enabled = false;
        }

        private void fun_CargarIdDevolucion()
        {
            int id = controlador.ObtenerSiguienteIdDevolucionVenta();
            Cbo_Id_Venta_Dev.Items.Clear();
            Cbo_Id_Venta_Dev.Items.Add(id);
            Cbo_Id_Venta_Dev.SelectedIndex = 0;
            // BLOQUEADO
            Cbo_Id_Venta_Dev.Enabled = false;
        }

        private void fun_CargarVentas()
        {
            try
            {
                Cbo_Id_Venta.DataSource = controlador.ObtenerVentas();

                Cbo_Id_Venta.DisplayMember = "VentaFecha";

                Cbo_Id_Venta.ValueMember = "Pk_Id_Ventas";

                Cbo_Id_Venta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

        private void fun_CargarEstado()
        {
            try
            {
                Cbo_Estado.DataSource = controlador.ObtenerEstado();

                Cbo_Estado.DisplayMember = "Estado";

                Cbo_Estado.ValueMember = "Estado";

                Cbo_Estado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estado: " + ex.Message);
            }
        }

        private void fun_CargarUnidadMedida(int iIdProducto)
        {
            try
            {
                DataTable dt =
                    controlador.ObtenerUnidadPorProducto(iIdProducto);

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
                MessageBox.Show(
                    "Error al cargar unidad de medida: " + ex.Message);
            }
        }

        private void fun_InicializarDetalle()
        {
            dtDetalle.Columns.Clear();

            // PRODUCTO
            dtDetalle.Columns.Add("IdProducto", typeof(int));
            dtDetalle.Columns.Add("Producto", typeof(string));
            dtDetalle.Columns.Add("Descripcion", typeof(string));
            // BODEGA
            dtDetalle.Columns.Add("IdBodega", typeof(int));
            dtDetalle.Columns.Add("Bodega", typeof(string));
            // UNIDAD
            dtDetalle.Columns.Add("IdUnidad", typeof(int));
            dtDetalle.Columns.Add("UnidadMedida", typeof(string));
            // DATOS DEVOLUCIÓN
            dtDetalle.Columns.Add("Precio", typeof(float));
            dtDetalle.Columns.Add("Cantidad", typeof(float));
            dtDetalle.Columns.Add("Subtotal", typeof(float));

            // ASIGNAR GRID
            Dgv_Detalle_Devolucion.DataSource = dtDetalle;
        }

        private void fun_EstadoInicial()
        {
            //BOTONES HABILITADOS
            Btn_Ingresar_DevVentas.Enabled = true;
            Btn_Modificar_Devolucion.Enabled = true;
            Btn_Eliminar_Devolucion.Enabled = true;
            Btn_buscar_Devolucion.Enabled = true;
            Btn_Reporte_Dev.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir_Dev.Enabled = true;

            //BOTONES DESHABILITADOS
            Btn_Guardar_Devoluciones.Enabled = false;
            Btn_Cancelar_Devolucion.Enabled = false;
            Btn_Agregar_Detalle_Dev.Enabled = false;
            Btn_Remover_Detalle_Dev.Enabled = false;
            Btn_Limpiar_Detalle.Enabled = false;

            //CONTROLES BLOQUEADOS
            Cbo_Id_Venta_Dev.Enabled = false;
            Cbo_Id_Venta.Enabled = false;
            Dtp_Fecha_Devolucion.Enabled = false;
            Cbo_Id_Cliente.Enabled = false;
            Txt_Motivo.Enabled = false;
            Cbo_Id_Sucursal.Enabled = false;
            Cbo_Estado.Enabled = false;

            //Detalle 
            Cbo_Id_Inventario.Enabled = false;
            Cbo_Id_Bodega.Enabled = false;
            Nud_Cant_Prod.Enabled = false;
            Cbo_Unidad_Medida.Enabled = false;

            Dgv_Detalle_Devolucion.Enabled = false;

            //IMPORTANTE: LIMPIAR DATOS
            dtDetalle.Clear(); // limpia grid
            Txt_Saldo_Total.Text = "0.00";
            totalGeneral = 0;

            Cbo_Id_Venta.SelectedIndex = -1;
            Cbo_Id_Cliente.SelectedIndex = -1;
            Cbo_Id_Sucursal.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Txt_Motivo.Clear();
            Cbo_Id_Inventario.SelectedIndex = -1;
            Cbo_Id_Bodega.SelectedIndex = -1;
            Nud_Cant_Prod.Value = 1;

            // LIMPIAR UNIDAD DE MEDIDA
            Cbo_Unidad_Medida.DataSource = null;
            Cbo_Unidad_Medida.Items.Clear();
            Cbo_Unidad_Medida.SelectedIndex = -1;
            Cbo_Unidad_Medida.Enabled = false;

            //RECARGAR ID
            fun_CargarIdDevolucion();
        }

        private void Btn_Ingresar_DevVentas_Click(object sender, EventArgs e)
        {
            // HABILITAR CONTROLES
            Cbo_Id_Venta.Enabled = true;
            Cbo_Id_Cliente.Enabled = true;
            Cbo_Id_Sucursal.Enabled = true;
            Cbo_Estado.Enabled = true;
            Dtp_Fecha_Devolucion.Enabled = true;
            Txt_Motivo.Enabled = true;

            Cbo_Id_Inventario.Enabled = true;
            Cbo_Id_Bodega.Enabled = true;
            Nud_Cant_Prod.Enabled = true;
            Cbo_Unidad_Medida.Enabled = true;
            Dgv_Detalle_Devolucion.Enabled = true;

            //ID SIEMPRE BLOQUEADO
            Cbo_Id_Venta_Dev.Enabled = false;

            //LIMPIAR ENCABEZADO
            Cbo_Id_Cliente.SelectedIndex = -1;
            Cbo_Id_Sucursal.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;

            Cbo_Id_Inventario.SelectedIndex = -1;
            Cbo_Id_Bodega.SelectedIndex = -1;

            // LIMPIAR DETALLE
            dtDetalle.Clear();
            totalGeneral = 0;
            Txt_Saldo_Total.Text = "0.00";
            Nud_Cant_Prod.Value = 1;

            //GENERAR NUEVO ID
            fun_CargarIdDevolucion();

            //BOTONES
            Btn_Guardar_Devoluciones.Enabled = true;
            Btn_Cancelar_Devolucion.Enabled = true;

            Btn_Ingresar_DevVentas.Enabled = false;
            Btn_Modificar_Devolucion.Enabled = false;
            Btn_Eliminar_Devolucion.Enabled = false;
            Btn_buscar_Devolucion.Enabled = false;

            Btn_Agregar_Detalle_Dev.Enabled = true;
            Btn_Remover_Detalle_Dev.Enabled = true;
            Btn_Limpiar_Detalle.Enabled = true;

        }
        private void Cbo_Id_Venta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Venta.SelectedIndex == -1)
                    return;

                if (Cbo_Id_Venta.SelectedValue == null ||
                    Cbo_Id_Venta.SelectedValue is DataRowView)
                    return;

                int iIdVenta = Convert.ToInt32(Cbo_Id_Venta.SelectedValue);

                // CARGAR CLIENTE
                DataTable dtCliente = controlador.ObtenerClientePorVenta(iIdVenta);

                if (dtCliente.Rows.Count > 0)
                {
                    Cbo_Id_Cliente.DataSource = dtCliente;

                    Cbo_Id_Cliente.DisplayMember = "NombreCompleto";

                    Cbo_Id_Cliente.ValueMember = "Pk_Id_Cliente";

                    Cbo_Id_Cliente.SelectedIndex = 0;
                }
                else
                {
                    Cbo_Id_Cliente.DataSource = null;

                    MessageBox.Show("No se encontró cliente para esta venta.");
                }

                // CARGAR SUCURSAL
                DataTable dtSucursal = controlador.ObtenerSucursalPorVenta(iIdVenta);

                if (dtSucursal.Rows.Count > 0)
                {
                    Cbo_Id_Sucursal.DataSource = dtSucursal;

                    Cbo_Id_Sucursal.DisplayMember = "NombreSucursal";

                    Cbo_Id_Sucursal.ValueMember = "Pk_Id_Sucursal";

                    Cbo_Id_Sucursal.SelectedIndex = 0;
                }
                else
                {
                    Cbo_Id_Sucursal.DataSource = null;

                    MessageBox.Show("No se encontró sucursal para esta venta.");
                }

                // CARGAR PRODUCTOS DE ESA VENTA
                DataTable dtProductos = controlador.ObtenerProductosPorVenta(iIdVenta);

                if (dtProductos.Rows.Count > 0)
                {
                    Cbo_Id_Inventario.DataSource = dtProductos;

                    Cbo_Id_Inventario.DisplayMember = "Producto";

                    Cbo_Id_Inventario.ValueMember = "pk_inventario_id";

                    Cbo_Id_Inventario.SelectedIndex = -1;
                }
                else
                {
                    Cbo_Id_Inventario.DataSource = null;

                    MessageBox.Show("Esta venta no tiene productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cbo_Id_Inventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Inventario.SelectedIndex == -1)
                    return;

                if (Cbo_Id_Inventario.SelectedValue == null ||
                    Cbo_Id_Inventario.SelectedValue is DataRowView)
                    return;

                if (!(Cbo_Id_Inventario.SelectedItem is DataRowView row))
                    return;

                int ipk_inventario_id =
                    Convert.ToInt32(row["pk_inventario_id"]);

                // BODEGA
                DataTable dtBodega =
                    controlador.ObtenerBodegaPorProducto(ipk_inventario_id);

                if (dtBodega.Rows.Count > 0)
                {
                    Cbo_Id_Bodega.DataSource = dtBodega;

                    Cbo_Id_Bodega.DisplayMember = "NombreBodega";

                    Cbo_Id_Bodega.ValueMember = "Pk_Id_Bodega";

                    Cbo_Id_Bodega.SelectedIndex = 0;
                }

                // UNIDAD
                fun_CargarUnidadMedida(ipk_inventario_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Agregar_Detalle_Dev_Click(object sender, EventArgs e)
        {
            try
            {
                // ======================================================
                // VALIDAR ENCABEZADO (OBLIGATORIO PRIMERO)
                // ======================================================
                if (Cbo_Id_Venta.SelectedIndex == -1 ||
                    Cbo_Id_Cliente.SelectedIndex == -1 ||
                    Cbo_Id_Sucursal.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(Txt_Motivo.Text))
                {
                    MessageBox.Show("Primero debe completar el encabezado");
                    return;
                }
                // VALIDAR PRODUCTO
                if (!(Cbo_Id_Inventario.SelectedItem is DataRowView row))
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                // VALIDAR BODEGA
                if (!(Cbo_Id_Bodega.SelectedItem is DataRowView rowBodega))
                {
                    MessageBox.Show("Seleccione una bodega.");
                    return;
                }

                // VALIDAR UNIDAD
                if (!(Cbo_Unidad_Medida.SelectedItem is DataRowView rowUnidad))
                {
                    MessageBox.Show("Seleccione una unidad.");
                    return;
                }

                // VALIDAR CANTIDAD
                if (Nud_Cant_Prod.Value <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }

                // ======================================================
                // PRODUCTO
                // ======================================================
                int iIdProducto =
                    Convert.ToInt32(row["pk_inventario_id"]);

                string sProducto =
                    row["nombre_prod"].ToString();

                string sDescripcion =
                    row["descripcion"].ToString();

                float fPrecio =
                    Convert.ToSingle(row["precio_unitario"]);

                // BODEGA
                int iIdBodega =
                    Convert.ToInt32(rowBodega["Pk_Id_Bodega"]);

                string sBodega =
                    rowBodega["Cmp_Nombre_Bodega"].ToString();

                // UNIDAD
                int iIdUnidad =
                    Convert.ToInt32(rowUnidad["ID_Unidad"]);

                string sUnidad =
                    rowUnidad["Nombre_Unidad"].ToString();

                // CANTIDAD
                float fCantidad =
                    Convert.ToSingle(Nud_Cant_Prod.Value);

                // SUBTOTAL
                float subtotal =
                    controlador.CalcularSubtotal(
                        fPrecio,
                        fCantidad,
                        0
                    );

                // AGREGAR AL GRID
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
                    subtotal
                );

                // ======================================================
                // RECALCULAR TOTAL
                totalGeneral =
                    controlador.CalcularTotal(dtDetalle);

                Txt_Saldo_Total.Text =
                    "Q " + totalGeneral.ToString("0.00");

                // ======================================================
                // ORDENAR GRID
                dtDetalle.DefaultView.Sort =
                    "IdProducto ASC";

                Dgv_Detalle_Devolucion.DataSource =
                    dtDetalle.DefaultView;

                // ======================================================
                // LIMPIAR CONTROLES
                // ======================================================
                Cbo_Id_Inventario.SelectedIndex = -1;
                Cbo_Id_Bodega.SelectedIndex = -1;

                Cbo_Unidad_Medida.DataSource = null;
                Cbo_Unidad_Medida.Items.Clear();

                Nud_Cant_Prod.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Guardar_Devoluciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Venta.SelectedIndex == -1 ||
                    Cbo_Id_Cliente.SelectedIndex == -1 ||
                    Cbo_Id_Sucursal.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(Txt_Motivo.Text))
                {
                    MessageBox.Show(
                        "Debe completar el encabezado de la devolución."
                    );
                    return;
                }

                if (dtDetalle.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Debe agregar productos a devolver."
                    );
                    return;
                }

                // ======================================================

                float fSaldoTotal =
                    controlador.CalcularTotal(dtDetalle);

                Txt_Saldo_Total.Text =
                    "Q " + fSaldoTotal.ToString("0.00");

                // ======================================================
                // DATOS
                // ======================================================
                int iFk_Id_Venta =
                    Convert.ToInt32(Cbo_Id_Venta.SelectedValue);

                DateTime dCmp_Fecha_Devolucion =
                    Dtp_Fecha_Devolucion.Value;

                string sCmp_Motivo =
                    Txt_Motivo.Text.Trim();

                bool resultado =
                    controlador.GuardarDevolucionCompleta(iFk_Id_Venta, dCmp_Fecha_Devolucion, sCmp_Motivo, fSaldoTotal, dtDetalle);
                if (resultado)
                {
                    MessageBox.Show(
                        "Devolución registrada correctamente."
                    );

                    DevolucionGuardada?.Invoke();

                    // LIMPIAR GRID
                    dtDetalle.Clear();

                    // LIMPIAR TOTAL
                    totalGeneral = 0;
                    Txt_Saldo_Total.Text = "0.00";

                    // LIMPIAR COMBOS
                    Cbo_Id_Venta.SelectedIndex = -1;

                    Cbo_Id_Cliente.SelectedIndex = -1;

                    Cbo_Id_Sucursal.SelectedIndex = -1;

                    Cbo_Id_Inventario.SelectedIndex = -1;

                    Cbo_Id_Bodega.SelectedIndex = -1;

                    // LIMPIAR UNIDAD
                    Cbo_Unidad_Medida.DataSource = null;

                    Cbo_Unidad_Medida.Items.Clear();

                    Cbo_Unidad_Medida.SelectedIndex = -1;

                    // LIMPIAR MOTIVO
                    Txt_Motivo.Clear();

                    // RESET CANTIDAD
                    Nud_Cant_Prod.Value = 1;


                    // NUEVO ID
                    fun_CargarIdDevolucion();

                    MessageBox.Show(
                        "Stock regresado correctamente al inventario."
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Error al guardar devolución."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Devolucion_Click(object sender, EventArgs e)
        {
            fun_EstadoInicial();

            // LIMPIAR GRID
            dtDetalle.Clear();

            // LIMPIAR TOTAL
            totalGeneral = 0;

            Txt_Saldo_Total.Text = "0.00";

            // LIMPIAR ENCABEZADO
            Cbo_Id_Venta.SelectedIndex = -1;

            Cbo_Id_Cliente.SelectedIndex = -1;

            Cbo_Id_Sucursal.SelectedIndex = -1;

            Cbo_Estado.SelectedIndex = -1;

            Txt_Motivo.Clear();

            // LIMPIAR DETALLE
            Cbo_Id_Inventario.SelectedIndex = -1;

            Cbo_Id_Bodega.SelectedIndex = -1;

            Nud_Cant_Prod.Value = 1;

            // ======================================================
            // LIMPIAR UNIDAD
            Cbo_Unidad_Medida.DataSource = null;

            Cbo_Unidad_Medida.Items.Clear();

            Cbo_Unidad_Medida.SelectedIndex = -1;

            Cbo_Unidad_Medida.Enabled = false;

            // ======================================================
            // NUEVO ID
            fun_CargarIdDevolucion();
        }

        // ======================================================
        // ELIMINAR DETALLE
        private void Btn_Remover_Detalle_Dev_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Detalle_Devolucion.CurrentRow == null ||
                    Dgv_Detalle_Devolucion.CurrentRow.IsNewRow)
                {
                    MessageBox.Show(
                        "Seleccione una fila para eliminar."
                    );
                    return;
                }

                DialogResult resultado =
                    MessageBox.Show(
                        "¿Está seguro de eliminar este producto?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (resultado == DialogResult.Yes)
                {
                    int index =
                        Dgv_Detalle_Devolucion.CurrentRow.Index;

                    // ELIMINAR
                    dtDetalle.Rows.RemoveAt(index);

                    // RECALCULAR TOTAL
                    totalGeneral =
                        controlador.CalcularTotal(dtDetalle);

                    Txt_Saldo_Total.Text =
                        "Q " + totalGeneral.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar: " + ex.Message
                );
            }
        }

        private void Btn_Limpiar_Detalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar DataTable
                dtDetalle.Clear();

                // Resetear total
                totalGeneral = 0;
                Txt_Saldo_Total.Text = "0.00";

                // Limpiar combos
                Cbo_Id_Venta.SelectedIndex = -1;
                Cbo_Id_Cliente.SelectedIndex = -1;
                Cbo_Id_Sucursal.SelectedIndex = -1;
                Cbo_Estado.SelectedIndex = -1;
                Txt_Motivo.Clear();
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
                fun_CargarIdDevolucion();

                MessageBox.Show("Formulario limpiado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message);
            }
        }

        private void Btn_Salir_Dev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
