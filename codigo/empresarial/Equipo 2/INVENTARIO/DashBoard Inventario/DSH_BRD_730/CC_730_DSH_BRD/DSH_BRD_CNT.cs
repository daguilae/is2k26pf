using System;
using System.Data;

public class DSH_BRD_CNT
{
    private DSH_BRD_MOD _modelo = new DSH_BRD_MOD();

    // ── ULTIMOS MOVIMIENTOS ──────────────────────────────
    public DataTable ObtenerUltimosMovimientos(DateTime desde, DateTime hasta,
                                                string nombre = null, string tipoMov = null)
        => _modelo.ObtenerUltimosMovimientos(desde, hasta, nombre, tipoMov);

    // ── STOCK CRITICO ────────────────────────────────────
    public DataTable ObtenerStockCritico()
    {
        try
        {
            return _modelo.ObtenerStockCritico();
        }
        catch (Exception ex)
        {
            throw new Exception("Controlador - Stock Crítico: " + ex.Message);
        }
    }

    // ── COMBOBOXES ───────────────────────────────────────
    public DataTable ObtenerNombresProductos()
        => _modelo.ObtenerNombresProductos();

    public DataTable ObtenerTiposMovimiento()
        => _modelo.ObtenerTiposMovimiento();
}