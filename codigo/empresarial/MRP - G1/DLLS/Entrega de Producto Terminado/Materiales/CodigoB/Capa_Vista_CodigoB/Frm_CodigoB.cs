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
using Zen.Barcode;
using System.Drawing.Imaging;
namespace Capa_Vista_CodigoB
{
    public partial class Frm_CodigoB : Form
    {
        OdbcConnection conexion = new OdbcConnection("Dsn=bd_SIG;Database=bd_mrp;");

        string codigoGenerado = "";
        Image imagenFinalCodigo = null;

        public Frm_CodigoB()
        {
            InitializeComponent();

            Btn_GenerarC.Click -= Btn_GenerarC_Click;
            Btn_GenerarC.Click += Btn_GenerarC_Click;

            Btn_GuardarC.Click -= Btn_GuardarC_Click;
            Btn_GuardarC.Click += Btn_GuardarC_Click;

            Cmb_Producto.DropDownStyle = ComboBoxStyle.DropDown;
            Cmb_Producto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cmb_Producto.AutoCompleteSource = AutoCompleteSource.ListItems;

            Pic_Codigo.SizeMode = PictureBoxSizeMode.Zoom;

            cargarProductos();
            cargarTipos();
        }

        private void cargarProductos()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                conexion.Open();

                string sql = @"SELECT Pk_Id_Materiales, Nombre_Material 
                               FROM tbl_materiales 
                               WHERE Activo = 1";

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

        private void cargarTipos()
        {
            Cmb_Tipo.Items.Clear();
            Cmb_Tipo.Items.Add("EAN13");
            Cmb_Tipo.Items.Add("EAN8");
            Cmb_Tipo.Items.Add("CODE128");
            Cmb_Tipo.Items.Add("CODE39");
            Cmb_Tipo.SelectedIndex = 0;
        }

        private int obtenerOInsertarMaterial(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Ingrese o seleccione un producto.");

            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            conexion.Open();

            string buscar = @"SELECT Pk_Id_Materiales 
                              FROM tbl_materiales 
                              WHERE Nombre_Material = ?";

            OdbcCommand cmdBuscar = new OdbcCommand(buscar, conexion);
            cmdBuscar.Parameters.Add("@nombre", OdbcType.VarChar).Value = nombre;

            object res = cmdBuscar.ExecuteScalar();

            if (res != null && res != DBNull.Value)
            {
                conexion.Close();
                return Convert.ToInt32(res);
            }

            string codigoTemporal = "TEMP" + DateTime.Now.ToString("yyyyMMddHHmmss");

            string insertar = @"INSERT INTO tbl_materiales
                                (Codigo_Material, Nombre_Material, Descripcion_Material,
                                 Fk_Id_Categoria, Fk_Id_Unidad_Medida,
                                 Stock_Minimo, Lote_Minimo_Compra,
                                 Lead_Time_Produccion_Dias, Activo)
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

            OdbcCommand cmdInsert = new OdbcCommand(insertar, conexion);

            cmdInsert.Parameters.Add("@codigo", OdbcType.VarChar).Value = codigoTemporal;
            cmdInsert.Parameters.Add("@nombre", OdbcType.VarChar).Value = nombre;
            cmdInsert.Parameters.Add("@descripcion", OdbcType.VarChar).Value = "Producto agregado desde código de barras";
            cmdInsert.Parameters.Add("@categoria", OdbcType.Int).Value = 1;
            cmdInsert.Parameters.Add("@unidad", OdbcType.Int).Value = 1;
            cmdInsert.Parameters.Add("@stockMinimo", OdbcType.Decimal).Value = 0;
            cmdInsert.Parameters.Add("@loteMinimo", OdbcType.Decimal).Value = 1;
            cmdInsert.Parameters.Add("@leadTime", OdbcType.Int).Value = 1;
            cmdInsert.Parameters.Add("@activo", OdbcType.Int).Value = 1;

            cmdInsert.ExecuteNonQuery();

            OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conexion);
            int nuevoId = Convert.ToInt32(cmdId.ExecuteScalar());

            conexion.Close();

            return nuevoId;
        }

        private int obtenerUnidadMaterial(int idMaterial)
        {
            int unidad = 1;

            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                conexion.Open();

                string sql = @"SELECT Fk_Id_Unidad_Medida 
                               FROM tbl_materiales 
                               WHERE Pk_Id_Materiales = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion);
                cmd.Parameters.Add("@id", OdbcType.Int).Value = idMaterial;

                object res = cmd.ExecuteScalar();

                if (res != null && res != DBNull.Value)
                    unidad = Convert.ToInt32(res);

                conexion.Close();
            }
            catch
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return unidad;
        }

        private string generarCodigoSignificativo(int idMaterial, int idAlmacen, int idUnidad, string tipo)
        {
            if (tipo == "EAN13")
            {
                return idAlmacen.ToString("D2") +
                       idMaterial.ToString("D7") +
                       idUnidad.ToString("D3");
            }

            if (tipo == "EAN8")
            {
                return idAlmacen.ToString("D1") +
                       idMaterial.ToString("D4") +
                       idUnidad.ToString("D2");
            }

            return "ALM" + idAlmacen.ToString("D2") +
                   "MAT" + idMaterial.ToString("D5") +
                   "UND" + idUnidad.ToString("D2");
        }

        private void Btn_GenerarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Cmb_Producto.Text))
                {
                    MessageBox.Show("Ingrese o seleccione un producto.");
                    return;
                }

                if (Cmb_Tipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de código.");
                    return;
                }

                int idMaterial = obtenerOInsertarMaterial(Cmb_Producto.Text.Trim());
                int idAlmacen = 1;
                int idUnidad = obtenerUnidadMaterial(idMaterial);

                string tipo = Cmb_Tipo.Text;

                codigoGenerado = generarCodigoSignificativo(idMaterial, idAlmacen, idUnidad, tipo);

                Image barras = null;

                if (tipo == "EAN13")
                    barras = BarcodeDrawFactory.CodeEan13WithChecksum.Draw(codigoGenerado, 60);
                else if (tipo == "EAN8")
                    barras = BarcodeDrawFactory.CodeEan8WithChecksum.Draw(codigoGenerado, 60);
                else if (tipo == "CODE128")
                    barras = BarcodeDrawFactory.Code128WithChecksum.Draw(codigoGenerado, 50);
                else if (tipo == "CODE39")
                    barras = BarcodeDrawFactory.Code39WithChecksum.Draw(codigoGenerado, 50);
                else
                {
                    MessageBox.Show("Tipo no válido.");
                    return;
                }

                imagenFinalCodigo = crearImagenConTexto(barras, codigoGenerado);
                Pic_Codigo.Image = imagenFinalCodigo;

                MessageBox.Show("Código generado correctamente:\n" + codigoGenerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar: " + ex.Message);
            }
        }

        private Image crearImagenConTexto(Image barras, string texto)
        {
            Bitmap bmp = new Bitmap(barras.Width + 40, barras.Height + 55);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                int x = (bmp.Width - barras.Width) / 2;
                g.DrawImage(barras, x, 5);

                using (Font fuente = new Font("Arial", 14, FontStyle.Bold))
                using (StringFormat formato = new StringFormat())
                {
                    formato.Alignment = StringAlignment.Center;

                    g.DrawString(
                        texto,
                        fuente,
                        Brushes.Black,
                        new RectangleF(0, barras.Height + 8, bmp.Width, 45),
                        formato
                    );
                }
            }

            return bmp;
        }

        private byte[] imagenABytes(Image img)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void Btn_GuardarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (imagenFinalCodigo == null || string.IsNullOrWhiteSpace(codigoGenerado))
                {
                    MessageBox.Show("Primero genere el código.");
                    return;
                }

                int idMaterial = obtenerOInsertarMaterial(Cmb_Producto.Text.Trim());

                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                conexion.Open();

                string sql = @"UPDATE tbl_materiales
               SET Codigo_Barras = ?,
                   Tipo_Codigo_Barras = ?,
                   Imagen_Material = ?
               WHERE Pk_Id_Materiales = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion);

                cmd.Parameters.Add("@codigo", OdbcType.VarChar).Value = codigoGenerado;
                cmd.Parameters.Add("@tipo", OdbcType.VarChar).Value = Cmb_Tipo.Text;
                cmd.Parameters.Add("@imagen", OdbcType.Binary).Value = imagenABytes(imagenFinalCodigo);
                cmd.Parameters.Add("@idMaterial", OdbcType.Int).Value = idMaterial;

                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Código guardado correctamente en el material.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);

                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void Btn_VerC_Click(object sender, EventArgs e)
        {
            Frm_Ver_CB frmv = new Frm_Ver_CB();
            frmv.ShowDialog();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
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
                "Codigo_Barras",
                "Ayuda_BOM.chm"
            );

            if (File.Exists(rutaAyuda))
            {
                Help.ShowHelp(this, rutaAyuda, "Cliente.html");
            }
            else
            {
                MessageBox.Show(
                    "No se encontró el archivo de ayuda:\n" + rutaAyuda,
                    "Ayuda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
