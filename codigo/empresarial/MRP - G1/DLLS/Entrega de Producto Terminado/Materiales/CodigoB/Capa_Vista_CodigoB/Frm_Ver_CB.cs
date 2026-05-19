using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
namespace Capa_Vista_CodigoB
{
    public partial class Frm_Ver_CB : Form
    {
        OdbcConnection conexion = new OdbcConnection("Dsn=bd_SIG;Database=bd_mrp;");

        public Frm_Ver_CB()
        {
            InitializeComponent();

            this.Load += Frm_Ver_CB_Load;
            Btn_Buscar.Click += Btn_Buscar_Click;

            Pic_Codigo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Frm_Ver_CB_Load(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                conexion.Open();

                string sql = @"SELECT Pk_Id_Materiales, Nombre_Material 
                               FROM tbl_materiales 
                               ORDER BY Nombre_Material";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Cmb_Producto.DataSource = dt;
                Cmb_Producto.DisplayMember = "Nombre_Material";
                Cmb_Producto.ValueMember = "Pk_Id_Materiales";

                Cmb_Producto.SelectedIndex = -1;
                Cmb_Producto.Text = "";

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);

                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Producto.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                int idMaterial = Convert.ToInt32(Cmb_Producto.SelectedValue);

                Image img = ObtenerCodigoBarras(idMaterial);

                if (img != null)
                {
                    Pic_Codigo.Image = new Bitmap(img, new Size(400, 200));
                }
                else
                {
                    MessageBox.Show("Este producto no tiene código de barras guardado.");
                    Pic_Codigo.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private Image ObtenerCodigoBarras(int idMaterial)
        {
            Image imagen = null;

            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                conexion.Open();

                string sql = @"SELECT Imagen_Codigo_Barras
                               FROM tbl_codigo_barras_material
                               WHERE Fk_Id_Materiales = ?
                               ORDER BY Pk_Id_Codigo_Barras DESC
                               LIMIT 1";

                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                cmd.Parameters.Add("@id", OdbcType.Int).Value = idMaterial;

                object resultado = cmd.ExecuteScalar();

                conexion.Close();

                if (resultado != null && resultado != DBNull.Value)
                {
                    byte[] datos = (byte[])resultado;

                    using (MemoryStream ms = new MemoryStream(datos))
                    {
                        imagen = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener imagen: " + ex.Message);

                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return imagen;
        }
    }
}
