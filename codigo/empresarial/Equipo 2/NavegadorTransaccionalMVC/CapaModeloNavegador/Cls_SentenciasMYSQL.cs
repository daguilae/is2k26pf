using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_NavegadorTrs
{
    public class Cls_SentenciasMYSQL
    {
        // llenado de tabla Hecho por Fernando Jose Cahuex Gonzalez 0901-22-14979
        Cls_ConexionMYSQL con = new Cls_ConexionMYSQL();
        public DataTable LlenarTabla(string tabla, string[] campos)
        {
            DataTable dt = new DataTable();
            try
            {
                string columnas = string.Join(",", campos); // para poder usar todos los campos de la tabla sin necesidad de escribirlos uno por uno y guarrdarlos en el array campos xd
                string sql = $"SELECT {columnas} FROM {tabla};"; // consulta SQL para seleccionar todos los registros de la tabla especificada

                OdbcConnection conn = con.conexion();
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(dt);
                con.desconexion(conn);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }

        //kenph luna
        // aqui se insertarán las instrucciones SQL genericas
        public string Insertar(string[] SAlias)
        {
            // por compatibilidad PK es autoinc
            return Insertar(SAlias, true); // llama a la nueva sobrecarga con pkAutoIncrement true
        }

        // nueva sobrecarga de Insertar que recibe si la pk es autoincrement o no
        public string Insertar(string[] SAlias, bool pkAutoIncrement)
        {
            string tabla = SAlias[0];
            string[] campos = pkAutoIncrement ? SAlias.Skip(2).ToArray() : SAlias.Skip(1).ToArray(); // si es autoinc ignora pk, si no, la incluye
            string columnas = string.Join(",", campos); 
            string parametros = string.Join(",", campos.Select(c => "?")); 

            return $"INSERT INTO {tabla} ({columnas}) VALUES ({parametros})"; // sentencia sql de insertar
        }

        // aqui se consultarán los registros con select segun la tabla que le enviemos
        public string Consultar(string[] SAlias)
        {
            string tabla = SAlias[0];
            return $"SELECT * FROM {tabla}";
        }
        
        //seccion de actualizar datos 
        public string Actualizar(string[] SAlias)
        {
            string tabla = SAlias[0];
            string pkCampo = SAlias[1];  // posición pk (llave primaria)
            string[] campos = SAlias.Skip(2).ToArray(); //los atributos y campos a actualizar

            string set = string.Join(",", campos.Select(c => $"{c}=?")); // genera el set para el update

            return $"UPDATE {tabla} SET {set} WHERE {pkCampo}=?"; // retorna la sentencia sql de update
        }

        // aqui se elimina el registro usando la pk para localizar el dato
        public string Eliminar(string[] SAlias)
        {
            string tabla = SAlias[0];
            string pkCampo = SAlias[1];

            return $"DELETE FROM {tabla} WHERE {pkCampo}=?"; // retorna la sentencia sql de delete
        }

        public bool EsPKAutoInc(string tabla, string pkCampo)
        {
            // devuelve true si la columna pkCampo en tabla tiene auto_increment
            using (OdbcConnection conn = con.conexion())
            {
                conn.Open();

                // consulta para verificar si la columna es auto_increment
                string sql = @"
                SELECT EXTRA FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_SCHEMA = DATABASE()
                AND TABLE_NAME = ?
                AND COLUMN_NAME = ?; "; 

                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = tabla;
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = pkCampo; 

                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value) return false;

                    string extra = result.ToString().ToLowerInvariant(); 
                    return extra.Contains("auto_increment"); // verifica si contiene auto_increment
                }
            }
        }


        // Obtencion de valores Hecho por Fernando Jose Cahuex GOnzalez 0901-22-14979
        public List<string> ObtenerValoresColumna(string tabla, string columna)
        {
            List<string> valores = new List<string>();
            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    conn.Open();
                    string sql = $"SELECT DISTINCT {columna} FROM {tabla}";
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            valores.Add(reader[0].ToString());
                        }
                    }
                }
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error al obtener valores de columna");
            }
            return valores;
        }

        // ==================== SOPORTE PARA LLAVES FORÁNEAS (FK) ====================
        // Método que carga los ítems de una FK desde su tabla de referencia.
        // Retorna una lista de pares (valorPK, textoMostrar) para llenar el ComboBox.
        // El ComboBox guardará internamente la PK (valor real de BD) pero mostrará
        // el texto descriptivo al usuario.
        //
        // Parámetros:
        //   tablaReferencia  - tabla de donde vienen los datos (ej: "tbl_cliente")
        //   campoPK          - columna PK de esa tabla (ej: "Pk_Cliente_Id")  → valor que va a BD
        //   campoMostrar     - columna descriptiva (ej: "Cmp_Nombre_Cliente") → texto que ve el usuario
        //   formatoDisplay   - opcional, ej: "{PK} - {DISPLAY}". Si es null/vacío usa solo campoMostrar
        // ============================================================================
        public List<Tuple<object, string>> ObtenerItemsFK(
            string tablaReferencia,
            string campoPK,
            string campoMostrar,
            string formatoDisplay = null)
        {
            var items = new List<Tuple<object, string>>();
            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    conn.Open();

                    // Si campoMostrar es igual a campoPK o está vacío, solo traemos la PK
                    bool soloUnaColumna = string.IsNullOrWhiteSpace(campoMostrar)
                                         || string.Equals(campoPK, campoMostrar, StringComparison.OrdinalIgnoreCase);

                    string sql = soloUnaColumna
                        ? $"SELECT {campoPK} FROM {tablaReferencia} ORDER BY {campoPK}"
                        : $"SELECT {campoPK}, {campoMostrar} FROM {tablaReferencia} ORDER BY {campoMostrar}";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object valorPK = reader[0];
                            string texto;

                            if (soloUnaColumna)
                            {
                                texto = valorPK?.ToString() ?? string.Empty;
                            }
                            else
                            {
                                string display = reader[1]?.ToString() ?? string.Empty;

                                if (!string.IsNullOrWhiteSpace(formatoDisplay))
                                {
                                    // Aplica formato personalizado: ej "{PK} - {DISPLAY}"
                                    texto = formatoDisplay
                                        .Replace("{PK}", valorPK?.ToString() ?? string.Empty)
                                        .Replace("{DISPLAY}", display);
                                }
                                else
                                {
                                    texto = display;
                                }
                            }

                            items.Add(Tuple.Create(valorPK, texto));
                        }
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al obtener items FK de tabla '{tablaReferencia}': {ex.Message}");
            }
            return items;
        }

        // Busca el texto a mostrar en el ComboBox FK dado un valor de PK.
        // Se usa al rellenar combos desde una fila del DataGridView.
        public string ObtenerDisplayFK(
            string tablaReferencia,
            string campoPK,
            string campoMostrar,
            string formatoDisplay,
            object valorPK)
        {
            if (valorPK == null || valorPK == DBNull.Value) return string.Empty;

            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    conn.Open();

                    bool soloUnaColumna = string.IsNullOrWhiteSpace(campoMostrar)
                                         || string.Equals(campoPK, campoMostrar, StringComparison.OrdinalIgnoreCase);

                    string sql = soloUnaColumna
                        ? $"SELECT {campoPK} FROM {tablaReferencia} WHERE {campoPK} = ?"
                        : $"SELECT {campoPK}, {campoMostrar} FROM {tablaReferencia} WHERE {campoPK} = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.Add("?", OdbcType.VarChar).Value = valorPK.ToString();
                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object pk = reader[0];
                                if (soloUnaColumna)
                                    return pk?.ToString() ?? string.Empty;

                                string display = reader[1]?.ToString() ?? string.Empty;

                                if (!string.IsNullOrWhiteSpace(formatoDisplay))
                                    return formatoDisplay
                                        .Replace("{PK}", pk?.ToString() ?? string.Empty)
                                        .Replace("{DISPLAY}", display);

                                return display;
                            }
                        }
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error ObtenerDisplayFK: {ex.Message}");
            }

            // Si no encontró el registro, devuelve la PK como texto de respaldo
            return valorPK.ToString();
        }

        // ==================== CAMPOS EDITABLES DE TABLA FK ====================
        // Trae los valores actuales de los campos editables de la tabla referenciada
        // dado el valor de la PK. Se usa al seleccionar una fila en el DGV para
        // rellenar los controles de edición de la tabla FK.
        //
        // Retorna un diccionario: nombreCampo → valor actual en BD
        // ======================================================================
        public Dictionary<string, object> ObtenerCamposRegistroFK(
            string tablaReferencia,
            string campoPK,
            object valorPK,
            string[] camposATraer)
        {
            var resultado = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

            if (valorPK == null || valorPK == DBNull.Value || camposATraer == null || camposATraer.Length == 0)
                return resultado;

            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    conn.Open();

                    // SELECT campo1, campo2, ... FROM tablaRef WHERE pk = ?
                    string listaColumnas = string.Join(", ", camposATraer);
                    string sql = $"SELECT {listaColumnas} FROM {tablaReferencia} WHERE {campoPK} = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.Add("?", OdbcType.VarChar).Value = valorPK.ToString();

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Llena el diccionario con cada columna y su valor
                                for (int i = 0; i < camposATraer.Length; i++)
                                {
                                    resultado[camposATraer[i]] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                                }
                            }
                        }
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error ObtenerCamposRegistroFK en '{tablaReferencia}': {ex.Message}");
            }

            return resultado;
        }

        // Genera la sentencia UPDATE para actualizar campos de la tabla referenciada.
        // Retorna: "UPDATE tablaRef SET campo1=?, campo2=? WHERE pk=?"
        public string GenerarUpdateTablaFK(string tablaReferencia, string campoPK, string[] camposActualizar)
        {
            string set = string.Join(", ", camposActualizar.Select(c => $"{c} = ?"));
            return $"UPDATE {tablaReferencia} SET {set} WHERE {campoPK} = ?";
        }

    }
}
