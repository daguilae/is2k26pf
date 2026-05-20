using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_recepcion;
using Capa_Controlador_Seguridad;
using System.IO;
namespace Capa_Vista_recepcion
{
    public partial class Frm_Detalle_Recepcion : Form

    {
        //cesar santizo 0901-22-5215

        public Frm_Detalle_Recepcion()
        {
            InitializeComponent();
            cargarCombos();
            inicializarColumnas();
        }
        Controlador con = new Controlador();
        Cls_BitacoraControlador bitacora = new Cls_BitacoraControlador();

        private int idRecepcion = 0;
        private void inicializarColumnas()
        {
            Dgv_Materiales.Columns.Clear();

            Dgv_Materiales.Columns.Add("idMaterial", "ID Material");
            Dgv_Materiales.Columns.Add("nombreMaterial", "Material");
            Dgv_Materiales.Columns.Add("cantidad", "Cantidad");
            Dgv_Materiales.Columns.Add("costo", "Costo Unitario");
            Btn_ingresar.Click += Btn_ingresar_Click;
            Btn_modificar.Click += Btn_modificar_Click;
            Btn_guardar.Click += Btn_guardar_Click;
            Btn_cancelar.Click += Btn_cancelar_Click;
            Btn_eliminar.Click += Btn_eliminar_Click;
            Btn_consultar.Click += Btn_consultar_Click;


        }

        //cesar santizo 0901-22-5215

        public void cargarCombos()
        {
            Cbo_Materiales.DataSource = con.getMateriales();
            Cbo_Materiales.DisplayMember = "Nombre_Material";
            Cbo_Materiales.ValueMember = "Pk_Id_Materiales";
            Cbo_Materiales.SelectedIndex = -1;

            Cbo_Almacen.DataSource = con.cargarUbi();
            Cbo_Almacen.DisplayMember = "Nombre_Almacen";
            Cbo_Almacen.ValueMember = "Pk_Id_Almacen";
            Cbo_Almacen.SelectedIndex = -1;

            Cbo_estado.DataSource = con.cargarestado();
            Cbo_estado.DisplayMember = "Nombre_Estado_Recepcion_Material";
            Cbo_estado.ValueMember = "Pk_Id_Estado_Recepcion_Material";
            Cbo_estado.SelectedIndex = -1;
        }
        //cesar santizo 0901-22-5215

        private void Btn_agregarMat_Click(object sender, EventArgs e)
        {
           
            if (Cbo_Materiales.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material");
                return;
            }

            if (Nud_Cantidad.Value <= 0 || string.IsNullOrWhiteSpace(Txt_Costo.Text))
            {
                MessageBox.Show("Ingrese cantidad y costo");
                return;
            }

           
            int idMaterial = Convert.ToInt32(Cbo_Materiales.SelectedValue);
            string nombreMaterial = Cbo_Materiales.Text;
            decimal cantidad = Nud_Cantidad.Value; 
            decimal costo = Convert.ToDecimal(Txt_Costo.Text);


            foreach (DataGridViewRow fila in Dgv_Materiales.Rows)
            {
                if (fila.Cells["idMaterial"].Value != null &&
                    Convert.ToInt32(fila.Cells["idMaterial"].Value) == idMaterial)
                {
                    MessageBox.Show("Ese material ya fue agregado");
                    return;
                }
            }

            
            Dgv_Materiales.Rows.Add(idMaterial, nombreMaterial, cantidad, costo);

          
            Cbo_Materiales.SelectedIndex = -1;
            Nud_Cantidad.Value = 0;
            Txt_Costo.Clear();
        }
        //cesar santizo 0901-22-5215

        private void Btn_eliminarMat_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.CurrentRow != null)
            {
                Dgv_Materiales.Rows.Remove(Dgv_Materiales.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_reportes frm = new Frm_reportes();
            frm.ShowDialog();
        }

        private bool modoModificar = false;

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarCampos(true);
            modoModificar = false;
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Id.Text))
            {
                MessageBox.Show("Primero consulte o seleccione una recepción para modificar.");
                return;
            }

            habilitarCampos(true);
            modoModificar = true;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Id.Text))
            {
                MessageBox.Show("Ingrese el ID externo de logística.");
                return;
            }

            if (Cbo_Almacen.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un almacén destino.");
                return;
            }

            if (Cbo_estado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            if (Dgv_Materiales.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un material.");
                return;
            }

            string idExterno = Txt_Id.Text.Trim();

            int almacen =
                Convert.ToInt32(Cbo_Almacen.SelectedValue);

            int estado =
                Convert.ToInt32(Cbo_estado.SelectedValue);

            DateTime notificacion =
                Dtp_Notificacion.Value.Date;

            DateTime ingreso =
                Dtp_Ingreso.Value.Date;

            string observacion =
                Rtxt_Observaciones.Text.Trim();

           
            if (modoModificar)
            {
                int idRecepcion =
                    Convert.ToInt32(Txt_Id.Tag);

                con.modificarRecepcionEncabezado(
                    idRecepcion,
                    idExterno,
                    almacen,
                    estado,
                    notificacion,
                    ingreso,
                    observacion
                );

                con.eliminarDetalleRecepcion(idRecepcion);

                foreach (DataGridViewRow fila in Dgv_Materiales.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    int idMaterial =
                        Convert.ToInt32(
                            fila.Cells["idMaterial"].Value
                        );

                    decimal cantidad =
                        Convert.ToDecimal(
                            fila.Cells["cantidad"].Value
                        );

                    decimal costo =
                        Convert.ToDecimal(
                            fila.Cells["costo"].Value
                        );

                    con.guardarRecepcionDetalle(
                        idRecepcion,
                        idMaterial,
                        cantidad,
                        costo
                    );

                    con.actualizarInventario(
                        idMaterial,
                        almacen,
                        cantidad,
                        costo
                    );
                }

                MessageBox.Show(
                    "Recepción modificada correctamente."
                );
            }

           
            else
            {
                
                int idRecepcion =
                    con.guardarRecepcionEncabezado(
                        idExterno,
                        almacen,
                        estado,
                        notificacion,
                        ingreso,
                        observacion
                    );

                
                foreach (DataGridViewRow fila in Dgv_Materiales.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    int idMaterial =
                        Convert.ToInt32(
                            fila.Cells["idMaterial"].Value
                        );

                    decimal cantidad =
                        Convert.ToDecimal(
                            fila.Cells["cantidad"].Value
                        );

                    decimal costo =
                        Convert.ToDecimal(
                            fila.Cells["costo"].Value
                        );

                    con.guardarRecepcionDetalle(
                        idRecepcion,
                        idMaterial,
                        cantidad,
                        costo
                    );

                   
                    con.actualizarInventario(
                        idMaterial,
                        almacen,
                        cantidad,
                        costo
                    );
                }

                MessageBox.Show(
                    "Recepción guardada correctamente."

                );
                bitacora.RegistrarAccion(Cls_Usuario_Conectado.iIdUsuario, 715, "Guardado de recepción material", true);
            }

            limpiarCampos();
            habilitarCampos(false);
        }
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarCampos(false);
            modoModificar = false;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Txt_Id.Tag == null)
            {
                MessageBox.Show("Primero consulte una recepción para eliminar.");
                return;
            }

            int idRecepcion = Convert.ToInt32(Txt_Id.Tag);

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar esta recepción?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                con.eliminarRecepcionCompleta(idRecepcion);
                MessageBox.Show("Recepción eliminada correctamente.");
                limpiarCampos();
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para consultar, se puede cargar desde el listado principal seleccionando una recepción.");
        }



        private void limpiarCampos()
        {
            Txt_Id.Clear();
            Txt_Id.Tag = null;

            Cbo_Almacen.SelectedIndex = -1;
            Cbo_estado.SelectedIndex = -1;

            Dtp_Notificacion.Value = DateTime.Today;
            Dtp_Ingreso.Value = DateTime.Today;

            Rtxt_Observaciones.Clear();

            Cbo_Materiales.SelectedIndex = -1;
            Nud_Cantidad.Value = 0;
            Txt_Costo.Clear();

            Dgv_Materiales.Rows.Clear();

            modoModificar = false;
        }

        private void habilitarCampos(bool estado)
        {
            Txt_Id.Enabled = estado;
            Cbo_Almacen.Enabled = estado;
            Cbo_estado.Enabled = estado;
            Dtp_Notificacion.Enabled = estado;
            Dtp_Ingreso.Enabled = estado;
            Rtxt_Observaciones.Enabled = estado;

            Cbo_Materiales.Enabled = estado;
            Nud_Cantidad.Enabled = estado;
            Txt_Costo.Enabled = estado;

            Btn_agregarMat.Enabled = estado;
            Btn_eliminarMat.Enabled = estado;
            Btn_guardar.Enabled = estado;
            Btn_cancelar.Enabled = estado;
        }

        private void Btn_ayuda_Click_1(object sender, EventArgs e)
        {
            string carpeta = Application.StartupPath;

            while (!Directory.Exists(Path.Combine(carpeta, "ayuda")) &&
                   Directory.GetParent(carpeta) != null)
            {
                carpeta = Directory.GetParent(carpeta).FullName;
            }

            string rutaAyuda = Path.Combine(
                carpeta,
                "ayuda",
                "MRP",
                "Ayudas_BOM",
                "Ayuda_Recepcion_Materiales",
                "Ayuda_BOM.chm"
            );

            if (File.Exists(rutaAyuda))
            {
                Help.ShowHelp(this, rutaAyuda, "Cliente.html");
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de ayuda:\n" + rutaAyuda,
                                "Ayuda",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        public void cargarRecepcion(int id)
        {
            idRecepcion = id;

            Txt_Id.Tag = id;

            DataTable encabezado = con.obtenerRecepcionPorId(id);

            if (encabezado.Rows.Count > 0)
            {
                DataRow fila = encabezado.Rows[0];

                Txt_Id.Text = fila["Id_Externo_Logistica"].ToString();

                Cbo_Almacen.SelectedValue =
                    Convert.ToInt32(fila["Fk_Id_Almacen_Destino"]);

                Cbo_estado.SelectedValue =
                    Convert.ToInt32(fila["Fk_Id_Estado_Recepcion"]);

                Dtp_Notificacion.Value =
                    Convert.ToDateTime(fila["Fecha_Notificacion"]);

                Dtp_Ingreso.Value =
                    Convert.ToDateTime(fila["Fecha_Ingreso_Almacen"]);

                Rtxt_Observaciones.Text =
                    fila["Observacion"].ToString();
            }

            DataTable detalle = con.obtenerDetalleRecepcion(id);

            Dgv_Materiales.Rows.Clear();

            foreach (DataRow fila in detalle.Rows)
            {
                Dgv_Materiales.Rows.Add(
                    fila["Fk_Id_Material"],
                    fila["Nombre_Material"],
                    fila["Cantidad_Recibida"],
                    fila["Costo_Unitario_Recibido"]
                );
            }
        }
    }
}

