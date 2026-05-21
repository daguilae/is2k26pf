using System;
using System.Collections.Generic;

namespace Capa_Controlador_NavegadorTrs
{
    /// <summary>
    /// Define la configuración de una llave foránea (FK) para el componente Navegador.
    ///
    /// NUEVA FUNCIONALIDAD: CamposEditables
    /// Permite editar campos de la tabla referenciada directamente desde el navegador.
    ///
    /// EJEMPLO CON CAMPOS EDITABLES:
    ///
    ///   navegador1.SConfiguracionFK = new List<Cls_ConfiguracionFK>
    ///   {
    ///       new Cls_ConfiguracionFK
    ///       {
    ///           CampoFK         = "Fk_Id_Orden_Recibida",
    ///           TablaReferencia = "Tbl_Orden_Recibida",
    ///           CampoPK         = "Pk_Id_Orden_Recibida",
    ///           CampoMostrar    = "Id_Externo_Logistica",
    ///
    ///           // Campos de Tbl_Orden_Recibida que el usuario puede ver y editar:
    ///           CamposEditables = new List<Cls_CampoEditable>
    ///           {
    ///               new Cls_CampoEditable { NombreCampo = "Id_Externo_Logistica",   Etiqueta = "ID Logística",         SoloLectura = false },
    ///               new Cls_CampoEditable { NombreCampo = "Cantidad_Solicitada",    Etiqueta = "Cantidad Solicitada",  SoloLectura = false },
    ///               new Cls_CampoEditable { NombreCampo = "Fecha_Requerida",        Etiqueta = "Fecha Requerida",      SoloLectura = false },
    ///               new Cls_CampoEditable { NombreCampo = "Observacion",            Etiqueta = "Observación",          SoloLectura = false },
    ///           }
    ///       }
    ///   };
    /// </summary>
    public class Cls_ConfiguracionFK
    {
        /// <summary>Nombre del campo FK en la tabla principal (ej: "Fk_Id_Orden_Recibida")</summary>
        public string CampoFK { get; set; }

        /// <summary>Tabla de donde vienen los datos del ComboBox (ej: "Tbl_Orden_Recibida")</summary>
        public string TablaReferencia { get; set; }

        /// <summary>PK de la tabla referenciada — valor que se guarda en BD (ej: "Pk_Id_Orden_Recibida")</summary>
        public string CampoPK { get; set; }

        /// <summary>Columna descriptiva que ve el usuario en el ComboBox (ej: "Id_Externo_Logistica")</summary>
        public string CampoMostrar { get; set; }

        /// <summary>
        /// Formato opcional. Usa {PK} y {DISPLAY}.
        /// Ejemplo: "{PK} - {DISPLAY}" → "3 - ORD-2024-001"
        /// </summary>
        public string FormatoDisplay { get; set; }

        /// <summary>
        /// NUEVA PROPIEDAD: campos de la tabla referenciada que se mostrarán y podrán editarse
        /// desde el navegador. Si es null o vacío, solo funciona el combo de selección (comportamiento original).
        /// Al guardar/modificar, se actualiza también la tabla referenciada con estos campos.
        /// </summary>
        public List<Cls_CampoEditable> CamposEditables { get; set; }
    }

    /// <summary>
    /// Define un campo de la tabla FK que será visible y editable en el Navegador.
    /// </summary>
    public class Cls_CampoEditable
    {
        /// <summary>Nombre exacto del campo en la tabla referenciada (ej: "Cantidad_Solicitada")</summary>
        public string NombreCampo { get; set; }

        /// <summary>Texto descriptivo que verá el usuario como etiqueta (ej: "Cantidad Solicitada")</summary>
        public string Etiqueta { get; set; }

        /// <summary>
        /// Si es true, el campo se muestra pero NO se puede editar (solo informativo).
        /// Por defecto false (editable).
        /// Útil para campos como timestamps o IDs externos que no se deben cambiar.
        /// </summary>
        public bool SoloLectura { get; set; } = false;
    }

    /// <summary>
    /// Ítem interno del ComboBox FK.
    /// Separa el valor real (PK que va a BD) del texto visible al usuario.
    /// </summary>
    public class Cls_ItemFK
    {
        public object Valor { get; set; }   // PK real que va a la BD
        public string Texto { get; set; }   // Texto que ve el usuario

        public override string ToString() => Texto;
    }
}
