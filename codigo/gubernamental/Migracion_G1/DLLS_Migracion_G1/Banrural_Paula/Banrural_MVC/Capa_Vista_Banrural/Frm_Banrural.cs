using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Banrural; // Referencia Capa Controlador

namespace Capa_Vista_Banrural //Paula Leonardo 0901-22-9580
{
    public partial class Frm_Banrural : Form
    {
        private readonly Cls_Controlador ctrl = new Cls_Controlador();

        // Para guardar el ciudadano encontrado
        private int _idCiudadano = 0;

        public Frm_Banrural()
        {
            InitializeComponent();

            // Eventos del DPI
            Txt_Dpi.KeyPress += Txt_Dpi_KeyPress;
            Txt_Dpi.TextChanged += Txt_Dpi_TextChanged;
            Txt_Dpi.Leave += Txt_Dpi_Leave;

            // Limitar longitud máxima
            Txt_Dpi.MaxLength = 13;
        }

        // LOAD
        private void Frm_Banrural_Load(object sender, EventArgs e)
        {
            // Bloquear campos que se llenan automáticamente
            Txt_Nombres.ReadOnly = true;
            Txt_Apellidos.ReadOnly = true;
            Txt_Edad.ReadOnly = true;
            Txt_NoBoleta.ReadOnly = true;
            Txt_TotalPagar.ReadOnly = true;

            // Mayúsculas automático
            Txt_Nombres.CharacterCasing = CharacterCasing.Upper;
            Txt_Apellidos.CharacterCasing = CharacterCasing.Upper;

            // Cargar tipos de pasaporte
            DataTable tipos = ctrl.ObtenerTiposPasaporte();

            Cmb_TipoPasaporte.DisplayMember = "Cmp_Tipo_Pasaporte";
            Cmb_TipoPasaporte.ValueMember = "Cmp_Tipo_Pasaporte"; // FIX
            Cmb_TipoPasaporte.DataSource = tipos;

            Cmb_TipoPasaporte.SelectedIndex = -1;

            Cmb_Duracion.DataSource = null;
            Txt_TotalPagar.Clear();
        }

        // BOTONES (NAVEGACIÓN)
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Frm_BuscarBoleta frm = new Frm_BuscarBoleta();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // DPI
        private void Txt_Dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y tecla borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Txt_Dpi_TextChanged(object sender, EventArgs e)
        {
            // Si por alguna razón pega más de 13 caracteres
            if (Txt_Dpi.Text.Length > 13)
            {
                Txt_Dpi.Text = Txt_Dpi.Text.Substring(0, 13);
                Txt_Dpi.SelectionStart = Txt_Dpi.Text.Length;
            }
        }

        private void Txt_Dpi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Dpi.Text))
                return;

            if (Txt_Dpi.Text.Length != 13)
            {
                MessageBox.Show(
                    "El DPI debe contener exactamente 13 dígitos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Txt_Dpi.Focus();
            }
        }

        // BUSCAR CIUDADANO
        private void Btn_BuscarDpi_Click(object sender, EventArgs e)
        {
            if (Txt_Dpi.Text.Length != 13)
            {
                MessageBox.Show("Ingrese un DPI válido (13 dígitos).");
                return;
            }

            long dpi = long.Parse(Txt_Dpi.Text);
            DataTable dt = ctrl.BuscarCiudadanoPorDpi(dpi);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ciudadano con ese DPI.");
                return;
            }

            DataRow r = dt.Rows[0];

            _idCiudadano = int.Parse(r["Pk_Id_Ciudadano"].ToString());
            Txt_Nombres.Text = r["Cmp_Nombres_Ciudadano"].ToString();
            Txt_Apellidos.Text = r["Cmp_Apellidos_Ciudadano"].ToString();

            DateTime fechaNac = Convert.ToDateTime(r["Cmp_Fecha_Nacimiento_Ciudadano"]);
            Txt_Edad.Text = CalcularEdad(fechaNac).ToString();
        }

        private int CalcularEdad(DateTime fechaNac)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNac.Year;
            if (fechaNac.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        // BOLETA
        private void Btn_GenerarBoleta_Click(object sender, EventArgs e)
        {
            // Genera de 6 dígitos (puedes cambiar rango)
            Random rnd = new Random();
            int noBoleta;

            do
            {
                noBoleta = rnd.Next(100000, 999999);
            } while (ctrl.ExisteNumeroBoleta(noBoleta));

            Txt_NoBoleta.Text = noBoleta.ToString();
        }

        // TIPO / DURACIÓN / PRECIO - PASAPORTE
        private void Cmb_TipoPasaporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_TipoPasaporte.SelectedValue == null)
                return;

            string tipo = Cmb_TipoPasaporte.SelectedValue.ToString();
            DataTable dur = ctrl.ObtenerDuracionesPorTipo(tipo);

            Cmb_Duracion.DisplayMember = "Cmp_Duracion_Pasaporte";
            Cmb_Duracion.ValueMember = "Cmp_Duracion_Pasaporte";
            Cmb_Duracion.DataSource = dur;

            Cmb_Duracion.SelectedIndex = -1;
            Txt_TotalPagar.Clear();
        }

        private void Cmb_Duracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_TipoPasaporte.SelectedValue == null)
                return;

            if (Cmb_Duracion.SelectedValue == null)
                return;

            string tipo = Cmb_TipoPasaporte.SelectedValue.ToString();

            if (!int.TryParse(Cmb_Duracion.SelectedValue.ToString(), out int duracion))
                return;

            decimal precio = ctrl.ObtenerPrecio(tipo, duracion);
            Txt_TotalPagar.Text = precio.ToString("0.00");
        }

        // GUARDAR
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (_idCiudadano == 0)
            {
                MessageBox.Show("Primero busque un DPI válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_NoBoleta.Text))
            {
                MessageBox.Show("Primero genere el número de boleta.");
                return;
            }

            if (Cmb_TipoPasaporte.SelectedValue == null ||
                string.IsNullOrWhiteSpace(Cmb_TipoPasaporte.SelectedValue.ToString()))
            {
                MessageBox.Show("Seleccione un tipo de pasaporte.");
                return;
            }

            if (Cmb_Duracion.SelectedValue == null ||
                string.IsNullOrWhiteSpace(Cmb_Duracion.SelectedValue.ToString()))
            {
                MessageBox.Show("Seleccione la duración del pasaporte.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_TotalPagar.Text))
            {
                MessageBox.Show("No se pudo calcular el total a pagar. Seleccione tipo y duración.");
                return;
            }

            int noBoleta = int.Parse(Txt_NoBoleta.Text);
            string tipo = Cmb_TipoPasaporte.SelectedValue.ToString();

            if (!int.TryParse(Cmb_Duracion.SelectedValue.ToString(), out int duracion))
            {
                MessageBox.Show("Duración inválida.");
                return;
            }

            // Obtener el ID REAL de Tbl_Tipo_Pasaporte según tipo + duración
            int idTipoReal = ctrl.ObtenerIdTipoPasaporte(tipo, duracion);

            if (idTipoReal == 0)
            {
                MessageBox.Show("No se encontró la tarifa para ese tipo y duración.");
                return;
            }

            int ok = ctrl.GuardarBoleta(noBoleta, _idCiudadano, idTipoReal);

            if (ok == 1)
            {
                DialogResult dr = MessageBox.Show(
                    "Boleta Pagada.\n¿Desea imprimir la boleta?",
                    "Pago",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (dr == DialogResult.Yes)
                {
                    // ImprimirBoleta(); // Hacer despues
                }
            }
            else
            {
                MessageBox.Show("No se pudo guardar la boleta.");
            }
        }

        // LIMPIAR TODO
        private void Btn_LimpiarTodo_Click(object sender, EventArgs e)
        {
            // Limpiar TextBox
            Txt_Dpi.Clear();
            Txt_Nombres.Clear();
            Txt_Apellidos.Clear();
            Txt_Edad.Clear();
            Txt_NoBoleta.Clear();
            Txt_TotalPagar.Clear();

            // Resetear variable
            _idCiudadano = 0;

            // Resetear Combo Tipo
            Cmb_TipoPasaporte.SelectedIndex = -1;

            // Limpiar Combo Duración
            Cmb_Duracion.DataSource = null;
            Cmb_Duracion.Items.Clear();

            // Enfocar nuevamente DPI
            Txt_Dpi.Focus();
        }

        // ===============================
        // EXTRAS (ENLAZADOS AL DESIGNER)
        // ===============================
        private void Txt_Nombres_TextChanged(object sender, EventArgs e) { }
        private void Txt_Apellidos_TextChanged(object sender, EventArgs e) { }
        private void Txt_Edad_TextChanged(object sender, EventArgs e) { }
        private void Txt_NoBoleta_TextChanged(object sender, EventArgs e) { }
        private void Txt_TotalPagar_TextChanged(object sender, EventArgs e) { }
        private void Btn_Imprimir_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}