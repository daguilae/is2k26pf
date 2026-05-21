using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Drawing;
using Capa_Modelo_Navegador;
using Capa_Modelo_Seguridad;
using Capa_Controlador_Seguridad;

namespace Capa_Controlador_Navegador
{
    public class Cls_ControladorNavegador
    {
        Cls_SentenciasMYSQL sentencias = new Cls_SentenciasMYSQL();
        private Cls_DAOGenerico dao = new Cls_DAOGenerico();
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();

        //===================== Nuevo Método Validar Columnas - 23/09/2025 =============================
        //===================== Kevin Natareno ============================================
        private bool ValidarColumnas(string tabla, string[] columnasEnviadas, out List<string> columnasBD)
        {
            columnasBD = dao.ObtenerColumnas(tabla);

            // Validar cantidad
            if (columnasEnviadas.Length != columnasBD.Count)
            {
                MessageBox.Show($" La cantidad de columnas no coincide con la base de datos.\n" +
                                $"Esperadas: {columnasBD.Count}, Enviadas: {columnasEnviadas.Length}");
                return false;
            }

            // Validar nombres
            var columnasFaltantes = new List<string>();
            foreach (var c in columnasEnviadas)
            {
                if (!columnasBD.Contains(c, StringComparer.OrdinalIgnoreCase))
                    columnasFaltantes.Add(c);
            }

            if (columnasFaltantes.Count > 0)
            {
                string msg = " Las siguientes columnas no existen en la tabla '" + tabla + "':\n" +
                             string.Join(", ", columnasFaltantes);
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }
        //=======================================================================================================


        // Asigna alias validando tabla y columnas
        // ======================= Pedro Ibañez =======================
        // Creacion de Metodo: Asignar Alias Original, generación de Textboxes antes de las modificaciones
        //Modificación de metodo: Validación de tipo de campo para cada dato
        //Modificacion de metodo: se agrego parametro para etiquetas personalizadas por el usuario. Hecho por: Kenph Luna 10/10/2025
        // ======================= SOPORTE FK agregado =======================
        // Nuevo parámetro opcional: sConfiguracionFK → lista de Cls_ConfiguracionFK
        // Cuando un campo del SAlias coincide con el CampoFK de alguna configuración,
        // se carga el ComboBox desde la tabla referenciada (mostrando texto legible)
        // en lugar de los valores crudos de la tabla principal.
        // ===================================================================
        public bool AsignarAlias(string[] sAlias, Control contenedor, int iStartX, int iStartY,
                                 string[] sEtiquetasPersonalizadas = null,
                                 List<Cls_ConfiguracionFK> sConfiguracionFK = null)
        {
            // --- validaciones
            if (!dao.ExisteTabla(sAlias[0]))
            {
                MessageBox.Show($"La tabla '{sAlias[0]}' no existe.");
                return false;
            }
            if (!ValidarColumnas(sAlias[0], sAlias.Skip(1).ToArray(), out List<string> columnasBD))
                return false;

            string sNombreTabla = sAlias[0];
            Dictionary<string, string> dTiposColumnas;
            try { dTiposColumnas = dao.ObtenerTiposDeColumnas(sNombreTabla); }
            catch { return false; }

            // Diccionario rápido de FK por nombre de campo
            var dictFK = new Dictionary<string, Cls_ConfiguracionFK>(StringComparer.OrdinalIgnoreCase);
            if (sConfiguracionFK != null)
                foreach (var fk in sConfiguracionFK)
                    if (!string.IsNullOrWhiteSpace(fk.CampoFK))
                        dictFK[fk.CampoFK] = fk;

            // --- espaciado
            int x              = iStartX;
            int y              = iStartY;
            int sepGrupos      = 30;   // espacio entre pares label+control
            int sepLabelCtrl   = 5;    // espacio entre label y su control
            int alturaFila     = 40;   // altura de cada fila
            int anchoCombo     = 200;
            int margenDerecho  = 20;

            // Fuente compartida para labels de la tabla principal
            Font fuenteLabelPrincipal = new Font("Rockwell", 10, FontStyle.Bold);
            // Fuente para labels de campos editables FK (un poco distinta para distinguirlos)
            Font fuenteLabelFK = new Font("Rockwell", 9, FontStyle.Italic | FontStyle.Bold);

            contenedor.SuspendLayout();

            for (int i = 1; i < sAlias.Length; i++)
            {
                string campo = sAlias[i];

                // --- texto del label de la tabla principal
                string textoLabel = (sEtiquetasPersonalizadas != null
                                     && (i - 1) < sEtiquetasPersonalizadas.Length
                                     && !string.IsNullOrWhiteSpace(sEtiquetasPersonalizadas[i - 1]))
                    ? sEtiquetasPersonalizadas[i - 1]
                    : campo.Replace("Cmp_", "").Replace("Pk_", "").Replace("Fk_", "");

                if (!string.IsNullOrEmpty(textoLabel))
                    textoLabel = char.ToUpper(textoLabel[0]) + textoLabel.Substring(1);
                textoLabel += ":";

                // --- tipo de control
                string tipo = dTiposColumnas.ContainsKey(campo) ? dTiposColumnas[campo] : "varchar";
                Control control;

                if (tipo.Contains("date"))
                {
                    control = new DateTimePicker { Name = "Dtp_" + campo, Format = DateTimePickerFormat.Short, Width = anchoCombo };
                }
                else if (tipo.Contains("bit") || tipo.Contains("tinyint"))
                {
                    control = new CheckBox { Name = "Chk_" + campo, Text = "Si/No", AutoSize = true };
                }
                else
                {
                    var cbo = new ComboBox { Name = "Cbo_" + campo, Width = anchoCombo, DropDownStyle = ComboBoxStyle.DropDown };

                    if (dictFK.ContainsKey(campo))
                    {
                        Cls_ConfiguracionFK cfgFK = dictFK[campo];
                        try
                        {
                            var itemsFK = sentencias.ObtenerItemsFK(
                                cfgFK.TablaReferencia, cfgFK.CampoPK,
                                cfgFK.CampoMostrar, cfgFK.FormatoDisplay);

                            cbo.DisplayMember = "Texto";
                            cbo.ValueMember   = "Valor";
                            cbo.DataSource    = itemsFK.Select(t => new Cls_ItemFK { Valor = t.Item1, Texto = t.Item2 }).ToList();
                            cbo.SelectedIndex = -1;
                            cbo.Text          = string.Empty;
                            cbo.Tag           = "FK:" + cfgFK.TablaReferencia + ":" + cfgFK.CampoPK
                                              + ":" + (cfgFK.CampoMostrar ?? "")
                                              + ":" + (cfgFK.FormatoDisplay ?? "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar FK '{campo}': {ex.Message}");
                            try { cbo.Items.AddRange(sentencias.ObtenerValoresColumna(sNombreTabla, campo).ToArray()); } catch { }
                        }
                    }
                    else
                    {
                        try { cbo.Items.AddRange(sentencias.ObtenerValoresColumna(sNombreTabla, campo).ToArray()); } catch { }
                    }

                    if (i == 1) cbo.Enabled = false; // bloquear PK
                    control = cbo;
                }
                control.Font = new Font("Rockwell", 10, FontStyle.Regular);

                // --- medir y posicionar label + control de la tabla principal
                Size tamano = TextRenderer.MeasureText(textoLabel, fuenteLabelPrincipal);
                int anchoLabel = tamano.Width;
                int anchoCtrl  = (control is CheckBox) ? 80 : control.Width;

                if (x + anchoLabel + sepLabelCtrl + anchoCtrl > contenedor.Width - margenDerecho)
                { x = iStartX; y += alturaFila; }

                contenedor.Controls.Add(new Label
                {
                    Text = textoLabel, Font = fuenteLabelPrincipal,
                    AutoSize = true, Location = new Point(x, y + 4)
                });
                control.Location = new Point(x + anchoLabel + sepLabelCtrl, y);
                contenedor.Controls.Add(control);

                x = control.Location.X + control.Width + sepGrupos;

                // ================================================================
                // NUEVO: si este campo FK tiene CamposEditables, crear los controles
                // de edición de la tabla referenciada justo después del combo FK
                // ================================================================
                if (dictFK.ContainsKey(campo))
                {
                    Cls_ConfiguracionFK cfgFK = dictFK[campo];

                    if (cfgFK.CamposEditables != null && cfgFK.CamposEditables.Count > 0)
                    {
                        // Obtener tipos de columnas de la tabla referenciada
                        Dictionary<string, string> tiposFK = new Dictionary<string, string>();
                        try { tiposFK = dao.ObtenerTiposDeColumnas(cfgFK.TablaReferencia); } catch { }

                        // Separador visual: nueva fila con línea y título de la sección
                        y += alturaFila;
                        x  = iStartX;

                        // Label separador que indica de qué tabla vienen los campos
                        string tituloSeccion = $"── Datos de {cfgFK.TablaReferencia} ──────────────────";
                        Label lblSeparador = new Label
                        {
                            Text      = tituloSeccion,
                            Font      = new Font("Rockwell", 8, FontStyle.Italic),
                            ForeColor = Color.Gray,
                            AutoSize  = true,
                            Location  = new Point(iStartX, y)
                        };
                        contenedor.Controls.Add(lblSeparador);
                        y += 22; // espacio para el separador

                        // Crear un control por cada campo editable de la tabla FK
                        foreach (Cls_CampoEditable campoEd in cfgFK.CamposEditables)
                        {
                            // Nombre único del control: FKFE_{CampoFKPrincipal}_{NombreCampoFK}
                            // FKFE = FK Field Editable
                            string nombreCtrl = "FKFE_" + campo + "_" + campoEd.NombreCampo;

                            // Etiqueta del control (la que definió el developer, o el nombre limpio)
                            string etiqFK = !string.IsNullOrWhiteSpace(campoEd.Etiqueta)
                                ? campoEd.Etiqueta
                                : campoEd.NombreCampo.Replace("Cmp_", "").Replace("Fk_", "");
                            if (!string.IsNullOrEmpty(etiqFK))
                                etiqFK = char.ToUpper(etiqFK[0]) + etiqFK.Substring(1);
                            etiqFK += ":";

                            // Tipo de dato del campo en la tabla FK
                            string tipoFK = tiposFK.ContainsKey(campoEd.NombreCampo)
                                ? tiposFK[campoEd.NombreCampo] : "varchar";

                            // Crear el control según el tipo
                            Control ctrlFK;
                            if (tipoFK.Contains("date") || tipoFK.Contains("time"))
                            {
                                ctrlFK = new DateTimePicker
                                {
                                    Name   = "Dtp_" + nombreCtrl,
                                    Format = DateTimePickerFormat.Short,
                                    Width  = anchoCombo,
                                    // Tag identifica: tipo de control, a qué FK pertenece, qué campo es
                                    Tag    = "FKFE:" + campo + ":" + cfgFK.TablaReferencia + ":"
                                           + cfgFK.CampoPK + ":" + campoEd.NombreCampo + ":" + tipoFK
                                };
                            }
                            else if (tipoFK.Contains("bit") || tipoFK.Contains("tinyint"))
                            {
                                ctrlFK = new CheckBox
                                {
                                    Name     = "Chk_" + nombreCtrl,
                                    Text     = "Si/No",
                                    AutoSize = true,
                                    Tag      = "FKFE:" + campo + ":" + cfgFK.TablaReferencia + ":"
                                             + cfgFK.CampoPK + ":" + campoEd.NombreCampo + ":" + tipoFK
                                };
                            }
                            else
                            {
                                // Campo de texto → ComboBox editable (igual que el sistema original)
                                var cboFK = new ComboBox
                                {
                                    Name          = "Cbo_" + nombreCtrl,
                                    Width         = anchoCombo,
                                    DropDownStyle = ComboBoxStyle.DropDown,
                                    Tag           = "FKFE:" + campo + ":" + cfgFK.TablaReferencia + ":"
                                                  + cfgFK.CampoPK + ":" + campoEd.NombreCampo + ":" + tipoFK
                                };
                                // Carga los valores existentes de ese campo en la tabla FK
                                try
                                {
                                    var vals = sentencias.ObtenerValoresColumna(cfgFK.TablaReferencia, campoEd.NombreCampo);
                                    cboFK.Items.AddRange(vals.ToArray());
                                }
                                catch { }
                                ctrlFK = cboFK;
                            }

                            ctrlFK.Font    = new Font("Rockwell", 10, FontStyle.Regular);
                            ctrlFK.Enabled = false; // inicia deshabilitado, se activa con Ingresar/Modificar

                            // Si el developer marcó SoloLectura, el control NUNCA se habilita
                            if (campoEd.SoloLectura)
                                ctrlFK.Tag = ctrlFK.Tag?.ToString() + ":READONLY";

                            // --- medir y posicionar
                            Size tamFK  = TextRenderer.MeasureText(etiqFK, fuenteLabelFK);
                            int anLblFK = tamFK.Width;
                            int anCtFK  = (ctrlFK is CheckBox) ? 80 : ctrlFK.Width;

                            if (x + anLblFK + sepLabelCtrl + anCtFK > contenedor.Width - margenDerecho)
                            { x = iStartX; y += alturaFila; }

                            contenedor.Controls.Add(new Label
                            {
                                Text      = etiqFK,
                                Font      = fuenteLabelFK,
                                ForeColor = Color.DarkSlateBlue, // color distinto para identificar que son FK
                                AutoSize  = true,
                                Location  = new Point(x, y + 4)
                            });
                            ctrlFK.Location = new Point(x + anLblFK + sepLabelCtrl, y);
                            contenedor.Controls.Add(ctrlFK);

                            x = ctrlFK.Location.X + ctrlFK.Width + sepGrupos;
                        }

                        // Línea de cierre de sección FK
                        y += alturaFila;
                        x  = iStartX;
                    }
                }
                // ================================================================
            }

            if (contenedor is Form frm)
            {
                frm.AutoScrollMinSize = new Size(0, y + 100);
                frm.AutoScroll = true;
            }

            contenedor.ResumeLayout(false);
            return true;
        }


        public void BloquearPK(Control contenedor, string[] SAlias)
        {
            // Validar parámetros mínimos: [tabla, pk, campos...]
            if (SAlias == null || SAlias.Length < 2)
                return;

            // El nombre del campo PK está en SAlias[1]
            string pkCampo = SAlias[1];

            // Buscar el ComboBox correspondiente
            var cboPK = contenedor.Controls.OfType<ComboBox>()
                             .FirstOrDefault(c => c.Name == "Cbo_" + pkCampo);

            // Si existe, bloquearlo
            if (cboPK != null)
            {
                cboPK.Enabled = false;
            }
        }

        private DataGridView dgv;

        public void AsignarDataGridView(DataGridView grid)
        {
            dgv = grid;
        }
        //================ Kevin Natareno ===================================
        //=============== Metodos de mover al inicio y mover al final========================

        public void MoverAlInicio()
        {
            if (dgv != null && dgv.Rows.Count > 0)
            {
                dgv.ClearSelection();
                dgv.Rows[0].Selected = true;
                dgv.CurrentCell = dgv.Rows[0].Cells[0];
            }
        }

        public void MoverAlFin() //Correcciones de funcionamiento - 23/09/2025
        {
            if (dgv == null || dgv.Rows.Count == 0) return;
            dgv.ClearSelection();
            int ultimaFila = dgv.Rows.Count - 1;
            if (dgv.AllowUserToAddRows)
                ultimaFila -= 1;
            if (ultimaFila < 0) return;  
            dgv.CurrentCell = dgv.Rows[ultimaFila].Cells[0];
            dgv.Rows[ultimaFila].Selected = true;
            dgv.FirstDisplayedScrollingRowIndex = ultimaFila;
        }
        //===============================================================================

        public void Insertar_Datos(Control contenedor, string[] SAlias, int ipkAplicacion)
        {
            object[] SValores = new object[SAlias.Length - 1];
            Cls_DAOGenerico dao = new Cls_DAOGenerico();

            try
            {
                for (int i = 1; i < SAlias.Length; i++)
                {
                    string alias = SAlias[i];
                    object valor = "";

                    var txt      = contenedor.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "Txt_" + alias);
                    var cbo      = contenedor.Controls.OfType<ComboBox>().FirstOrDefault(c => c.Name == "Cbo_" + alias);
                    var dtp      = contenedor.Controls.OfType<DateTimePicker>().FirstOrDefault(d => d.Name == "Cmp_" + alias || d.Name == "Dtp_" + alias);
                    var chkCampo = contenedor.Controls.OfType<CheckBox>().FirstOrDefault(ch => ch.Name == "Chk_" + alias);

                    if (txt != null)       valor = txt.Text;
                    else if (cbo != null)  valor = ObtenerValorRealCombo(cbo);
                    else if (dtp != null)  valor = dtp.Value.ToString("yyyy-MM-dd");
                    else if (chkCampo != null) valor = chkCampo.Checked;

                    if (valor is string s && string.IsNullOrWhiteSpace(s))
                    {
                        MessageBox.Show($"El campo '{alias}' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SValores[i - 1] = valor;
                }

                dao.InsertarDatos(SAlias, SValores);

                // ===== NUEVO: guardar campos editables de tablas FK =====
                GuardarCamposEditablesFK(contenedor);
                // ========================================================

                MessageBox.Show("Datos insertados correctamente.");
                LimpiarCombos(contenedor, SAlias);

                gCtrlBitacora.RegistrarAccion(
                    Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    ipkAplicacion,
                    $"Insertó un nuevo registro en la tabla '{SAlias[0]}' con llave: {SValores[0]}",
                    true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }




        public DataTable LlenarTabla(string tabla, string[] SAlias) 
        {
            return sentencias.LlenarTabla(tabla, SAlias);
        }

        //---------------------------------------------------------------------------------------------

        // ====================== Eliminar / Delete = Fernando Miranda = 20/09/2025 =======================
        public void Eliminar_Datos(Control contenedor, string[] SAlias, int ipkAplicacion)
        {
            Cls_DAOGenerico dao = new Cls_DAOGenerico();

            try
            {
                ComboBox CboPK = contenedor.Controls
                    .OfType<ComboBox>()
                    .FirstOrDefault(t => t.Name == "Cbo_" + SAlias[1]); // Se colocó la posicion 1 del array, ya elimina registros

                if (CboPK == null || string.IsNullOrWhiteSpace(CboPK.Text))
                {
                    MessageBox.Show("No se encontró el campo clave primaria o está vacío.");
                    return;
                }

                object pkValor = CboPK.Text;

                dao.EliminarDatos(SAlias, pkValor); // llamada directa al DAO
                MessageBox.Show("Registro eliminado correctamente.");
                //Bitacora
                gCtrlBitacora.RegistrarAccion(
                  Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                  ipkAplicacion,
                  $"Eliminó un registro en la tabla '{SAlias[0]}' Con la llave '{CboPK.Text}' ",
                  true
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos: " + ex.Message);
            }
        }

        // ======================= Modificar / Update = Stevens Cambranes = 20/09/2025 =======================
        // ======================= Actualizar en BD leyendo los ComboBox = 20/09/2025 =======================
        public void Actualizar_Datos(Control contenedor, string[] SAlias, int ipkAplicacion)
        {
            if (SAlias == null || SAlias.Length < 3)
            {
                MessageBox.Show("Alias inválido: se espera [tabla, pk, campos...]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pkNombre = SAlias[1];
            ComboBox cboPK = contenedor.Controls.OfType<ComboBox>().FirstOrDefault(t => t.Name == "Cbo_" + pkNombre);

            if (cboPK == null || string.IsNullOrWhiteSpace(cboPK.Text))
            {
                MessageBox.Show("Seleccione un valor válido de la clave primaria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object pkValor = ObtenerValorRealCombo(cboPK);
            string[] campos = SAlias.Skip(2).ToArray();
            object[] SValores = new object[campos.Length];

            try
            {
                for (int i = 0; i < campos.Length; i++)
                {
                    string campo = campos[i];
                    object valor = "";

                    var cboCampo = contenedor.Controls.OfType<ComboBox>().FirstOrDefault(c => c.Name == "Cbo_" + campo);
                    var txtCampo = contenedor.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "Txt_" + campo);
                    var dtpCampo = contenedor.Controls.OfType<DateTimePicker>().FirstOrDefault(d => d.Name == "Cmp_" + campo || d.Name == "Dtp_" + campo);
                    var chkCampo = contenedor.Controls.OfType<CheckBox>().FirstOrDefault(ch => ch.Name == "Chk_" + campo);

                    if (txtCampo != null)       valor = txtCampo.Text;
                    else if (cboCampo != null)  valor = ObtenerValorRealCombo(cboCampo);
                    else if (dtpCampo != null)  valor = dtpCampo.Value.ToString("yyyy-MM-dd");
                    else if (chkCampo != null)  valor = chkCampo.Checked;

                    if (valor is string s && string.IsNullOrWhiteSpace(s))
                    {
                        MessageBox.Show($"El campo '{campo}' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SValores[i] = valor;
                }

                Cls_DAOGenerico dao = new Cls_DAOGenerico();
                dao.ActualizarDatos(SAlias, SValores, pkValor);

                // ===== NUEVO: guardar campos editables de tablas FK =====
                GuardarCamposEditablesFK(contenedor);
                // ========================================================

                MessageBox.Show("Registro actualizado correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gCtrlBitacora.RegistrarAccion(
                    Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    ipkAplicacion,
                    $"Actualizó un registro en la tabla '{SAlias[0]}' Con la llave '{pkValor}' ",
                    true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ======================= Rellenar los ComboBox desde la fila seleccionada del DataGridView = Stevens Cambranes = 20/09/2025 =======================
        // ======================= Modificacion de Metodo para rellenar ChecKBoxes Y DTP también = Pedro Ibañez = 10/10/2025 =======================
        // ======================= Soporte FK agregado: busca el ítem correcto en combos de FK =====================
        public void RellenarCombosDesdeFila(Control contenedor, string[] SAlias, DataGridViewRow fila)
        {
            if (fila == null || SAlias == null || SAlias.Length < 2) return;

            var drv   = fila.DataBoundItem as DataRowView;
            DataTable table = drv?.Row?.Table;

            // ── Paso 1: rellenar controles de la tabla principal ──────────────
            for (int i = 1; i < SAlias.Length; i++)
            {
                string campo = SAlias[i];
                object valor = null;

                if (drv != null && table != null && table.Columns.Contains(campo))
                    valor = drv[campo];
                else
                {
                    var grid = fila.DataGridView;
                    var col  = grid.Columns.Cast<DataGridViewColumn>()
                                   .FirstOrDefault(c =>
                                        string.Equals(c.Name, campo, StringComparison.OrdinalIgnoreCase) ||
                                        string.Equals(c.DataPropertyName, campo, StringComparison.OrdinalIgnoreCase));
                    if (col != null) valor = fila.Cells[col.Index].Value;
                }

                var cbo = contenedor.Controls.OfType<ComboBox>().FirstOrDefault(c => c.Name == "Cbo_" + campo);
                var chk = contenedor.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Name == "Chk_" + campo);
                var dtp = contenedor.Controls.OfType<DateTimePicker>().FirstOrDefault(c => c.Name == "Dtp_" + campo);

                if (cbo != null)
                {
                    if (cbo.Tag is string tag && tag.StartsWith("FK:"))
                    {
                        string[] partes   = tag.Split(':');
                        string tablaRef   = partes.Length > 1 ? partes[1] : "";
                        string campoPKRef = partes.Length > 2 ? partes[2] : "";
                        string campoMostr = partes.Length > 3 ? partes[3] : "";
                        string formato    = partes.Length > 4 ? partes[4] : "";

                        if (valor != null && valor != DBNull.Value)
                        {
                            bool encontrado = false;
                            if (cbo.DataSource is List<Cls_ItemFK> listaItems)
                            {
                                var item = listaItems.FirstOrDefault(it => it.Valor?.ToString() == valor.ToString());
                                if (item != null) { cbo.SelectedItem = item; encontrado = true; }
                            }
                            if (!encontrado)
                                cbo.Text = sentencias.ObtenerDisplayFK(tablaRef, campoPKRef, campoMostr, formato, valor);

                            // ═══════════════════════════════════════════════════════════
                            // NUEVO: si este combo FK tiene campos editables,
                            // cargar los valores de la tabla referenciada automáticamente
                            // ═══════════════════════════════════════════════════════════
                            CargarCamposEditablesFKDesdeBD(contenedor, campo, valor);
                            // ═══════════════════════════════════════════════════════════
                        }
                        else
                        {
                            cbo.SelectedIndex = -1;
                            cbo.Text          = string.Empty;
                            LimpiarControlesFKFE(contenedor, campo);
                        }
                    }
                    else
                    {
                        cbo.Text = valor?.ToString() ?? string.Empty;
                    }
                }
                else if (chk != null)
                {
                    bool estado = false;
                    if (valor != null)
                    {
                        try   { estado = Convert.ToBoolean(Convert.ToInt32(valor)); }
                        catch { if (bool.TryParse(valor.ToString(), out bool p)) estado = p; }
                    }
                    chk.Checked = estado;
                }
                else if (dtp != null)
                {
                    if (valor != null && DateTime.TryParse(valor.ToString(), out DateTime fecha))
                        dtp.Value = fecha;
                    else
                        dtp.Value = DateTime.Now;
                }
            }
        }

        // ── Carga los valores de la tabla FK en sus controles FKFE ───────────
        // Se llama automáticamente al seleccionar una fila del DGV.
        // Busca todos los controles FKFE que pertenecen a este campoFK y los
        // rellena con los datos actuales del registro en la tabla referenciada.
        private void CargarCamposEditablesFKDesdeBD(Control contenedor, string campoFK, object valorPK)
        {
            // Buscar todos los controles FKFE que pertenecen a este campoFK
            // Tienen Tag con formato: "FKFE:{campoFK}:{tablaRef}:{campoPK}:{nombreCampo}:{tipo}[:READONLY]"
            var controlesFKFE = ObtenerControlesFKFE(contenedor, campoFK);

            if (controlesFKFE.Count == 0) return;

            // Extraer info de la tabla referenciada desde el Tag del primer control
            string tag0     = controlesFKFE[0].ctrl.Tag?.ToString() ?? "";
            string[] partes = tag0.Split(':');
            if (partes.Length < 5) return;

            string tablaRef  = partes[2];
            string campoPKFK = partes[3];

            // Nombres de los campos a traer de la BD
            string[] camposNombres = controlesFKFE.Select(c => c.nombreCampo).ToArray();

            // Consulta la BD para obtener los valores actuales
            Dictionary<string, object> valoresFK;
            try
            {
                valoresFK = dao.ObtenerCamposRegistroFK(tablaRef, campoPKFK, valorPK, camposNombres);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar campos FK editables: {ex.Message}");
                return;
            }

            // Asignar el valor a cada control
            foreach (var entrada in controlesFKFE)
            {
                if (!valoresFK.ContainsKey(entrada.nombreCampo)) continue;
                object valor = valoresFK[entrada.nombreCampo];
                AsignarValorAControl(entrada.ctrl, valor);
            }
        }

        // ── Limpia los controles FKFE de un campo FK específico ──────────────
        private void LimpiarControlesFKFE(Control contenedor, string campoFK)
        {
            foreach (var entrada in ObtenerControlesFKFE(contenedor, campoFK))
                LimpiarControl(entrada.ctrl);
        }

        // ── Asigna un valor a un control según su tipo ───────────────────────
        private void AsignarValorAControl(Control ctrl, object valor)
        {
            if (ctrl is ComboBox cbo)
            {
                cbo.Text = valor?.ToString() ?? string.Empty;
            }
            else if (ctrl is DateTimePicker dtp)
            {
                if (valor != null && valor != DBNull.Value
                    && DateTime.TryParse(valor.ToString(), out DateTime fecha))
                    dtp.Value = fecha;
                else
                    dtp.Value = DateTime.Now;
            }
            else if (ctrl is CheckBox chk)
            {
                bool estado = false;
                if (valor != null && valor != DBNull.Value)
                {
                    try   { estado = Convert.ToBoolean(Convert.ToInt32(valor)); }
                    catch { bool.TryParse(valor?.ToString(), out estado); }
                }
                chk.Checked = estado;
            }
        }

        // ── Limpia un control individual ─────────────────────────────────────
        private void LimpiarControl(Control ctrl)
        {
            if      (ctrl is ComboBox cbo)        { cbo.SelectedIndex = -1; cbo.Text = string.Empty; }
            else if (ctrl is DateTimePicker dtp)  { dtp.Value = DateTime.Now; }
            else if (ctrl is CheckBox chk)        { chk.Checked = false; }
        }

        // ── Estructura auxiliar para agrupar control + nombre de campo ────────
        private struct EntradaFKFE { public Control ctrl; public string nombreCampo; }

        // ── Devuelve todos los controles FKFE que pertenecen a un campoFK ─────
        // Busca por Tag que empiece con "FKFE:{campoFK}:"
        private List<EntradaFKFE> ObtenerControlesFKFE(Control contenedor, string campoFK)
        {
            string prefijo = "FKFE:" + campoFK + ":";
            var resultado  = new List<EntradaFKFE>();

            foreach (Control c in contenedor.Controls)
            {
                string tag = c.Tag?.ToString() ?? "";
                if (!tag.StartsWith(prefijo)) continue;

                // Tag: "FKFE:{campoFK}:{tablaRef}:{campoPK}:{nombreCampo}:{tipo}[:READONLY]"
                string[] partes = tag.Split(':');
                if (partes.Length < 5) continue;

                resultado.Add(new EntradaFKFE { ctrl = c, nombreCampo = partes[4] });
            }
            return resultado;
        }

        // ════════════════════════════════════════════════════════════════════
        // NUEVO: GuardarCamposEditablesFK
        // Busca en el contenedor TODOS los controles FKFE, agrupa los que
        // pertenecen a la misma tabla FK y ejecuta un UPDATE por cada grupo.
        // Se llama automáticamente desde Insertar_Datos y Actualizar_Datos.
        // ════════════════════════════════════════════════════════════════════
        private void GuardarCamposEditablesFK(Control contenedor)
        {
            // Recolectar y agrupar todos los controles FKFE del contenedor
            // Tag formato: "FKFE:{campoFKPrincipal}:{tablaRef}:{campoPK}:{nombreCampo}:{tipo}[:READONLY]"
            var grupos = new Dictionary<string, List<(string nombreCampo, object valor)>>(StringComparer.OrdinalIgnoreCase);
            var metaDatos = new Dictionary<string, (string tablaRef, string campoPK)>(StringComparer.OrdinalIgnoreCase);

            foreach (Control ctrl in contenedor.Controls)
            {
                string tag = ctrl.Tag?.ToString() ?? "";
                if (!tag.StartsWith("FKFE:")) continue;
                if (tag.EndsWith(":READONLY"))  continue; // SoloLectura → no guardar

                string[] partes         = tag.Split(':');
                if (partes.Length < 5)  continue;

                string campoFKPrincipal = partes[1]; // "Fk_Id_Orden_Recibida"
                string tablaRef         = partes[2]; // "Tbl_Orden_Recibida"
                string campoPK          = partes[3]; // "Pk_Id_Orden_Recibida"
                string nombreCampo      = partes[4]; // "Cantidad_Solicitada"

                object valor = ObtenerValorDeControl(ctrl);

                string clave = campoFKPrincipal;
                if (!grupos.ContainsKey(clave))
                {
                    grupos[clave]   = new List<(string, object)>();
                    metaDatos[clave] = (tablaRef, campoPK);
                }
                grupos[clave].Add((nombreCampo, valor));
            }

            // Por cada grupo FK, obtener la PK seleccionada y hacer UPDATE
            foreach (var kvp in grupos)
            {
                string campoFKPrincipal = kvp.Key;
                string tablaRef         = metaDatos[campoFKPrincipal].tablaRef;
                string campoPKFK        = metaDatos[campoFKPrincipal].campoPK;

                // El combo FK principal tiene el ID del registro referenciado
                var comboFKPrincipal = contenedor.Controls.OfType<ComboBox>()
                    .FirstOrDefault(c => c.Name == "Cbo_" + campoFKPrincipal);

                if (comboFKPrincipal == null)
                {
                    MessageBox.Show($"No se encontró el combo FK '{campoFKPrincipal}'.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                object valorPKFK = ObtenerValorRealCombo(comboFKPrincipal);
                if (valorPKFK == null || string.IsNullOrWhiteSpace(valorPKFK.ToString()))
                {
                    MessageBox.Show($"Seleccione un valor en '{campoFKPrincipal}' antes de guardar los datos relacionados.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                string[] campos  = kvp.Value.Select(x => x.nombreCampo).ToArray();
                object[] valores = kvp.Value.Select(x => x.valor).ToArray();

                try
                {
                    dao.ActualizarRegistroFK(tablaRef, campoPKFK, valorPKFK, campos, valores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar datos en '{tablaRef}': {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── Extrae el valor actual de un control según su tipo ────────────────
        private object ObtenerValorDeControl(Control ctrl)
        {
            if (ctrl is ComboBox cbo)        return string.IsNullOrWhiteSpace(cbo.Text) ? (object)DBNull.Value : cbo.Text;
            if (ctrl is DateTimePicker dtp)   return dtp.Value.ToString("yyyy-MM-dd");
            if (ctrl is CheckBox chk)         return chk.Checked;
            return DBNull.Value;
        }

        private object ObtenerValorRealCombo(ComboBox cbo)
        {
            if (cbo == null) return string.Empty;

            // ¿Es un combo FK?
            if (cbo.Tag is string tag && tag.StartsWith("FK:"))
            {
                // Intentar obtener el ítem seleccionado
                if (cbo.SelectedItem is Cls_ItemFK itemFK)
                    return itemFK.Valor ?? string.Empty;

                // Si el usuario escribió texto libre, buscar por texto en la lista
                if (cbo.DataSource is List<Cls_ItemFK> lista)
                {
                    var match = lista.FirstOrDefault(it =>
                        string.Equals(it.Texto, cbo.Text, StringComparison.OrdinalIgnoreCase));
                    if (match != null)
                        return match.Valor ?? string.Empty;
                }

                // Último recurso: devolver lo que diga el Text (podría ser la PK escrita a mano)
                return cbo.Text;
            }

            // Combo normal → devuelve el texto
            return cbo.Text;
        }


        //======================= Pedro Ibañez ======================
        //Modificacion de metodo: Crea DataGridView y recibe parametros para no chocar con ComboBoxes
        public DataGridView CrearDataGridView()
        {
           // int PosYdgv = startY + 20; ver posiciones despues


            DataGridView dgv = new DataGridView();
            dgv.Name = "Dgv_Datos";
            dgv.ScrollBars = ScrollBars.None;
            dgv.BackgroundColor = Color.White;

            // Fuente de encabezados
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 10, FontStyle.Bold);

            // Fuente de celdas
            dgv.DefaultCellStyle.Font = new Font("Rockwell", 10, FontStyle.Regular);

            dgv.Location = new System.Drawing.Point(10, 250);
            dgv.Size = new System.Drawing.Size(1100, 200);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;

            // Asignar al atributo privado
            this.dgv = dgv;

            return dgv; 
        }


        // ======================= Refrescar las opciones de cada ComboBox con valores actuales de la BD = Stevens Cambranes = 20/09/2025 =======================
        public void RefrescarCombos(Control contenedor, string tabla, string[] columnas)
        {
            foreach (var campo in columnas)
            {
                var cbo = contenedor.Controls.OfType<ComboBox>()
                             .FirstOrDefault(c => c.Name == "Cbo_" + campo);
                if (cbo == null) continue;

                // ===== SOPORTE FK: si es combo FK, recarga desde la tabla referenciada =====
                if (cbo.Tag is string tag && tag.StartsWith("FK:"))
                {
                    string[] partes   = tag.Split(':');
                    string tablaRef   = partes.Length > 1 ? partes[1] : "";
                    string campoPKRef = partes.Length > 2 ? partes[2] : "";
                    string campoMostr = partes.Length > 3 ? partes[3] : "";
                    string formato    = partes.Length > 4 ? partes[4] : "";

                    // Guardar item actual para reseleccionar después
                    object valorActual = (cbo.SelectedItem is Cls_ItemFK itemActual) ? itemActual.Valor : null;

                    try
                    {
                        var itemsFK = sentencias.ObtenerItemsFK(tablaRef, campoPKRef, campoMostr, formato);
                        var listaItems = itemsFK.Select(t => new Cls_ItemFK { Valor = t.Item1, Texto = t.Item2 }).ToList();

                        cbo.DataSource    = null;
                        cbo.DataSource    = listaItems;
                        cbo.DisplayMember = "Texto";
                        cbo.ValueMember   = "Valor";
                        cbo.SelectedIndex = -1;

                        // Reseleccionar el ítem anterior si sigue existiendo
                        if (valorActual != null)
                        {
                            var resel = listaItems.FirstOrDefault(it => it.Valor?.ToString() == valorActual.ToString());
                            if (resel != null) cbo.SelectedItem = resel;
                        }
                    }
                    catch { /* mantiene lo que tiene si falla */ }
                    continue;
                }
                // ============================================================================

                // Combo normal → recarga desde la misma tabla
                string valorTexto = cbo.Text;

                List<string> items;
                try { items = sentencias.ObtenerValoresColumna(tabla, campo); }
                catch { items = new List<string>(); }

                cbo.BeginUpdate();
                try
                {
                    cbo.Items.Clear();
                    foreach (var it in items) cbo.Items.Add(it);

                    if (!string.IsNullOrEmpty(valorTexto) && cbo.Items.Contains(valorTexto))
                        cbo.SelectedItem = valorTexto;
                    else
                        cbo.Text = valorTexto ?? string.Empty;
                }
                finally { cbo.EndUpdate(); }
            }
        }

        // ======================= Limpiar todos los ComboBox generados = Stevens Cambranes = 20/09/2025 =======================
        // ======================= Modificacion de Metodo para limpiar ChecKBoxes también = Pedro Ibañez = 10/10/2025 =======================
        public void LimpiarCombos(Control contenedor, string[] SAlias)
        {
            if (SAlias == null || SAlias.Length < 2) return;

            // Limpiar controles de la tabla principal
            for (int i = 1; i < SAlias.Length; i++)
            {
                string campo = SAlias[i];

                var cbo = contenedor.Controls.OfType<ComboBox>()
                             .FirstOrDefault(c => c.Name == "Cbo_" + campo);
                if (cbo != null) { cbo.SelectedIndex = -1; cbo.Text = string.Empty; }

                var chk = contenedor.Controls.OfType<CheckBox>()
                             .FirstOrDefault(c => c.Name == "Chk_" + campo);
                if (chk != null) chk.Checked = false;

                var dtp = contenedor.Controls.OfType<DateTimePicker>()
                             .FirstOrDefault(c => c.Name == "Dtp_" + campo);
                if (dtp != null) dtp.Value = DateTime.Now;
            }

            // ═══ NUEVO: limpiar también todos los controles FKFE ═══
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl.Tag?.ToString()?.StartsWith("FKFE:") == true)
                    LimpiarControl(ctrl);
            }
        }

        // Activa todos los controles de entrada del navegador.
        // Los controles FKFE marcados como READONLY nunca se habilitan.
        public void ActivarTodosComboBoxes(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (!(ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)) continue;

                // Si es un control FKFE de solo lectura, nunca se activa
                string tag = ctrl.Tag?.ToString() ?? "";
                if (tag.StartsWith("FKFE:") && tag.EndsWith(":READONLY")) continue;

                ctrl.Enabled = true;
            }
        }

        // Desactiva todos los controles de entrada del navegador.
        public void DesactivarTodosComboBoxes(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)
                    ctrl.Enabled = false;
            }
        }
        

    }
}
