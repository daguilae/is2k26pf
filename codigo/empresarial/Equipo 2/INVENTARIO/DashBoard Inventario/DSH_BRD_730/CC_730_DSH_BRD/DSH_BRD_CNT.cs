using System;
using System.Data;

public class DSH_BRD_CNT
{
    // Instancia del Modelo
    private DSH_BRD_MOD _modelo = new DSH_BRD_MOD();

    // ── ULTIMOS MOVIMIENTOS ──────────────────────────────
    public DataTable ObtenerUltimosMovimientos(DateTime fechaInicio, DateTime fechaFin)
    {
        try
        {
            return _modelo.ObtenerUltimosMovimientos(fechaInicio, fechaFin);
        }
        catch (Exception ex)
        {
            throw new Exception("Controlador - Movimientos: " + ex.Message);
        }
    }

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
}