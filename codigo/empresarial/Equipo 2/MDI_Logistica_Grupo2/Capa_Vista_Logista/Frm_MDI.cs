using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mantenimiento_tipo_MOV_inv;
using Capa_Vista_LineaProd;
using Capa_Vista_Ventas;
using Mantenimiento_Proveedores;
using Capa_Vista_Marca;
using Capa_Vista_Empresa_Transporte;
using Capa_Vista_Reporteador;
using Capa_Vista_Seguridad;
using Capa_Vista_Bodegaa;
using Capa_Vista_Mov_Inv;
using Mantenimiento_cuentas_por_pagar;
using Capa_Vista_OrdenProduccion;
using Capa_vista_Factura;
using Capa_Vista_OrdenDetalle;
using Capa_Vista_Comprobantes;
using Capa_Vista_Compras;
using Capa_Controlador_Seguridad;
//using Capa_Vista_MOVINV;
using Capa_vista_orden_compra;
//using Capa_Vista_MOVINV;
using CV_730_DSH_BRD;
using System.Drawing.Imaging;
using Capa_Vista_CXP;
using Capa_Vista_Balance;


namespace Capa_Vista_Logista
{
    public partial class Frm_MDI : Form
    {
        private Cls_ControladorAsignacionUsuarioAplicacion controladorPermisos = new Cls_ControladorAsignacionUsuarioAplicacion();
        private Cls_Asignacion_Permiso_PerfilControlador controladorPermisosPerfil = new Cls_Asignacion_Permiso_PerfilControlador();

        public enum MenuOpciones
        {
            Archivo,
            Catalogos,
            Procesos,
            Reportes,
            Ayudas,
            Seguridad
        }

        private Dictionary<MenuOpciones, ToolStripMenuItem> menuItems;

        public Frm_MDI()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            InicializarMenuItems();
            fun_inicializar_botones_por_defecto();

            this.Load += Frm_MDI_Load;
            this.IsMdiContainer = true;

        }

        private void Frm_MDI_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"Estado: Conectado | Usuario: {Capa_Controlador_Seguridad.Cls_Usuario_Conectado.sNombreUsuario}";
            fun_inicializar_botones_por_defecto();
            fun_habilitar_botones_por_permisos_combinados(
                Cls_Usuario_Conectado.iIdUsuario,
                Cls_Usuario_Conectado.iIdPerfil
            );
        }

        private void InicializarMenuItems()
        {
            menuItems = new Dictionary<MenuOpciones, ToolStripMenuItem>
            {
                { MenuOpciones.Archivo, archivoToolStripMenuItem },
                { MenuOpciones.Catalogos, catálogosToolStripMenuItem },
                { MenuOpciones.Procesos, procesosToolStripMenuItem },
                { MenuOpciones.Reportes, herramientasToolStripMenuItem },
                { MenuOpciones.Ayudas, asignacionesToolStripMenuItem },
                { MenuOpciones.Seguridad, seguridadToolStripMenuItem }
            };
        }

        public void fun_inicializar_botones_por_defecto()
        {
            foreach (var opcion in menuItems.Keys)
            {
                switch (opcion)
                {
                    case MenuOpciones.Archivo:
                    case MenuOpciones.Reportes:
                    case MenuOpciones.Ayudas:
                        menuItems[opcion].Enabled = true;
                        break;
                    default:
                        menuItems[opcion].Enabled = false;
                        break;
                }
            }
        }

        public void fun_habilitar_botones_por_permisos_combinados(int iIdUsuario, int iIdPerfil)
        {
            // CATÁLOGOS: 700-709
            Dictionary<int, ToolStripMenuItem> mapaCatalogos = new Dictionary<int, ToolStripMenuItem>
            {
                {700, marcaToolStripMenuItem},
                {701, vendedoresToolStripMenuItem},
                {702, clientesToolStripMenuItem},
                {703, proveedoresToolStripMenuItem},
                {704, lineaDeProductoToolStripMenuItem},
                {705, bodegaToolStripMenuItem},
                {706, empresaTransporteToolStripMenuItem},
                {707, movimientoOperacionToolStripMenuItem},
                {708, cuentasPorPagarToolStripMenuItem},
                {709, cuentaPorCobrarToolStripMenuItem}
            };

            // PROCESOS: 710-734 (agregar cuando estén listos)
            Dictionary<int, ToolStripMenuItem> mapaProcesos = new Dictionary<int, ToolStripMenuItem>
            {
                {728, movimientoDeInventariosToolStripMenuItem},
                {710, ventasToolStripMenuItem},
                {712, ordenDeProduccionToolStripMenuItem},
                {729, facturasToolStripMenuItem},
                //{714, comprasToolStripMenuItem},
                {715, cuentasPorPagarToolStripMenuItem1},
                //{716, detalleOrdenDeProduccionToolStripMenuItem},
                {711, cuentasPorCobrarToolStripMenuItem},
                {717, comprobanteCompraToolStripMenuItem},
                {718, comprobanteVentaToolStripMenuItem},
                {719, comprobanteProduccionToolStripMenuItem},
                {720, entregaDeProducciónToolStripMenuItem},
                {721, toolStripMenuItem3},
                {722, toolStripMenuItem4},
                {723, transportesToolStripMenuItem},
                {726, inventarioToolStripMenuItem},
                {727, sucursalesToolStripMenuItem},
                {713, devoluconToolStripMenuItem},
                //{730, consultaDeInventariosToolStripMenuItem_Click},
                {732,cuentasPorCobrarDetalleToolStripMenuItem}


            };
            Dictionary<int, ToolStripMenuItem> mapaReportes = new Dictionary<int, ToolStripMenuItem>
            {
                {733, balanceDeAntiguedadToolStripMenuItem },
               


            };


            foreach (var sub in mapaCatalogos.Values) sub.Enabled = false;
            foreach (var sub in mapaProcesos.Values) sub.Enabled = false;
            foreach (var sub in mapaReportes.Values) sub.Enabled = false;
            menuItems[MenuOpciones.Seguridad].Enabled = false;

            DataTable dtPermisosPerfil = controladorPermisosPerfil.datObtenerPermisosPorPerfil(iIdPerfil);
            foreach (DataRow row in dtPermisosPerfil.Rows)
            {
                int idModulo = Convert.ToInt32(row["iFk_id_modulo"]);
                int idAplicacion = Convert.ToInt32(row["iFk_id_aplicacion"]);

                if (idModulo == 44 && idAplicacion >= 700 && idAplicacion <= 734)
                {
                    if (mapaCatalogos.ContainsKey(idAplicacion))
                        mapaCatalogos[idAplicacion].Enabled = true;
                    if (mapaProcesos.ContainsKey(idAplicacion))
                        mapaProcesos[idAplicacion].Enabled = true;
                    if (mapaReportes.ContainsKey(idAplicacion))
                        mapaReportes[idAplicacion].Enabled = true;
                }

                if (idModulo == 4 && idAplicacion == 309)
                {
                    menuItems[MenuOpciones.Seguridad].Enabled = true;
                }
            }

            DataTable dtPermisosUsuario = controladorPermisos.ObtenerPermisosPorUsuario(iIdUsuario);
            foreach (DataRow row in dtPermisosUsuario.Rows)
            {
                int idModulo = Convert.ToInt32(row["iFk_id_modulo"]);
                int idAplicacion = Convert.ToInt32(row["iFk_id_aplicacion"]);

                if (idModulo == 44 && idAplicacion >= 700 && idAplicacion <= 734)
                {
                    if (mapaCatalogos.ContainsKey(idAplicacion))
                        mapaCatalogos[idAplicacion].Enabled = true;
                    if (mapaProcesos.ContainsKey(idAplicacion))
                        mapaProcesos[idAplicacion].Enabled = true;
                    if (mapaReportes.ContainsKey(idAplicacion))
                        mapaReportes[idAplicacion].Enabled = true;
                }

                if (idModulo == 4 && idAplicacion == 309)
                {
                    menuItems[MenuOpciones.Seguridad].Enabled = true;
                }
            }

            menuItems[MenuOpciones.Catalogos].Enabled = mapaCatalogos.Values.Any(m => m.Enabled);
            menuItems[MenuOpciones.Procesos].Enabled = mapaProcesos.Values.Any(m => m.Enabled);
            menuItems[MenuOpciones.Reportes].Enabled = mapaProcesos.Values.Any(m => m.Enabled);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_LOGIN login = new Frm_LOGIN();
            login.ShowDialog();
            this.Close();
        }

        private void cuentaPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Op_CXC CXC = new Frm_Mantenimiento_Tipo_Op_CXC();
            CXC.MdiParent = this;
            CXC.Show();
        }

        private void lineaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_LineaProducto LineaProducto = new Frm_Mantenimiento_LineaProducto();
            LineaProducto.MdiParent = this;
            LineaProducto.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Vendedores vendedores = new Frm_Vendedores();
            vendedores.MdiParent = this;
            vendedores.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_proveedores proveedores = new Frm_proveedores();
            proveedores.MdiParent = this;
            proveedores.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clientes Clientes = new Frm_Clientes();
            Clientes.MdiParent = this;
            Clientes.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Marca Marca = new Frm_Marca();
            Marca.MdiParent = this;
            Marca.Show();
        }

        private void empresaTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empresa_Transporte transporte = new Frm_Empresa_Transporte();
            transporte.MdiParent = this;
            transporte.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reportes Reporteador = new Frm_Reportes();
            Reporteador.MdiParent = this;
            Reporteador.Show();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bodega bodega = new Frm_Bodega();
            bodega.MdiParent = this;
            bodega.Show();
        }

        private void movimientoOperacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mantenimiento_tipo_mov_inv Movimiento = new Frm_mantenimiento_tipo_mov_inv();
            Movimiento.MdiParent = this;
            Movimiento.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_cuentas_por_pagar CXP = new Frm_Mantenimiento_cuentas_por_pagar();
            CXP.MdiParent = this;
            CXP.Show();
        }

     

        private void movimientoDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Movimientos_Inventario InvMov = new Frm_Movimientos_Inventario();
            InvMov.MdiParent = this;
            InvMov.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inventario_Mantenimiento Inv = new Frm_Inventario_Mantenimiento();
            Inv.MdiParent = this;
            Inv.Show();
        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdenProduccion_Encabezado Orden = new Frm_OrdenProduccion_Encabezado();
            Orden.MdiParent = this;
            Orden.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ventas_Generales ventas = new Frm_Ventas_Generales();
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sucursales sucursales = new Frm_Sucursales();
            sucursales.MdiParent = this;
            sucursales.Show();
        }

        private void facturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_factura factura = new Frm_factura();
            factura.MdiParent = this;
            factura.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CXC_NAV CXC = new Frm_CXC_NAV();
            CXC.MdiParent = this;
            CXC.Show();
        }

        private void devoluconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Devolucion devolucion = new Frm_Devolucion();
            devolucion.MdiParent = this;
            devolucion.Show();
        }

        private void comprobanteCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Comprobante_Compra com_compra = new Frm_Comprobante_Compra();
            com_compra.MdiParent = this;
            com_compra.Show();
        }

        private void comprobanteVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Comprobante_Venta com_venta = new Frm_Comprobante_Venta();
            com_venta.MdiParent = this;
            com_venta.Show();
        }

        private void comprobanteProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Comprobante_Produccion com_prod = new Frm_Comprobante_Produccion();
            com_prod.MdiParent = this;
            com_prod.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_Entrega_Compra entrega_Compra = new Frm_Entrega_Compra();
            entrega_Compra.MdiParent = this;
            entrega_Compra.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Entrega_Venta entrega_Venta = new Frm_Entrega_Venta();
            entrega_Venta.MdiParent = this;
            entrega_Venta.Show();
        }

        private void entregaDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Entrega_Produccion entrega_Produccion = new Frm_Entrega_Produccion();
            entrega_Produccion.MdiParent = this;
            entrega_Produccion.Show();
        }

        private void transportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Transporte tipo_Transporte = new Frm_Tipo_Transporte();
            tipo_Transporte.MdiParent = this;
            tipo_Transporte.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ordencompra compras = new Frm_ordencompra();
            compras.MdiParent = this;
            compras.Show();   
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bitacora bitacora = new Frm_Bitacora();
            bitacora.MdiParent = this;
            bitacora.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cambiar_contrasena cambiar_Contrasena = new Frm_cambiar_contrasena(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario);
            cambiar_Contrasena.MdiParent = this;
            cambiar_Contrasena.Show();
        }

        private void asignaciónVendedorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Asignacion_Clientes asig_clientes = new Frm_Asignacion_Clientes();
            asig_clientes.MdiParent = this;
            asig_clientes.Show();

        }

        private void consultaDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSH_BRD_FRM consulta = new DSH_BRD_FRM();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void cuentasPorPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_inicio_CXP cuentas_XP = new Frm_inicio_CXP();
            cuentas_XP.MdiParent = this;
            cuentas_XP.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_ordencompra ordencompra = new Frm_ordencompra();
            ordencompra.MdiParent = this;
            ordencompra.Show();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Unidad Unidad = new Frm_Mantenimiento_Unidad();
            Unidad.MdiParent = this;
            Unidad.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_inicio_devoluciones_d devolu = new Frm_inicio_devoluciones_d();
            devolu.MdiParent = this;
            devolu.Show();

        }

        private void tipoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Clientes TipoClientes = new Frm_Tipo_Clientes();
            TipoClientes.MdiParent = this;
            TipoClientes.Show();
        }

        private void politicasDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Politicas_Descuentos politicas_Descuentos = new Frm_Politicas_Descuentos();
            politicas_Descuentos.MdiParent = this;
            politicas_Descuentos.Show();
        }

        private void cuentasPorCobrarDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CXC_Detalle_NAV CXC_detalle = new Frm_CXC_Detalle_NAV();
            CXC_detalle.MdiParent = this;
            CXC_detalle.Show();

        }

        private void balanceDeAntiguedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Balance_Menu balance = new Frm_Balance_Menu();
            balance.MdiParent = this;
            balance.Show();
        }

        private void pagosVentasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Pagos pagos = new Frm_Pagos();
            pagos.MdiParent = this;
            pagos.Show();
        }


        private void devolucionesVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Devoluciones_Generales Dv = new Frm_Devoluciones_Generales();
            Dv.MdiParent = this;
            Dv.Show();
        }

        private void balanceDeAntiguedadToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Frm_Balance_Menu Balance = new Frm_Balance_Menu();
            Balance.MdiParent = this;
            Balance.Show();
        }
    }
}