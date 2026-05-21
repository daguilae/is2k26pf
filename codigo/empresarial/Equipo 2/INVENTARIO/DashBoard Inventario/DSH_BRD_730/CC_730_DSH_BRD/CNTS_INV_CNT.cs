using System;
using System.Data;

public class CNTS_INV_CNT
{
    // Instancia del Modelo
    private CNTS_INV_MOD _modelo = new CNTS_INV_MOD();

    // ── BODEGAS para ComboBox ────────────────────────────
    public DataTable ObtenerBodegas()
    {
        try
        {
            return _modelo.ObtenerBodegas();
        }
        catch (Exception ex)
        {
            throw new Exception("Controlador - Bodegas: " + ex.Message);
        }
    }

    // ── PRODUCTOS para ComboBox ──────────────────────────
    public DataTable ObtenerProductos()
    {
        try
        {
            return _modelo.ObtenerProductos();
        }
        catch (Exception ex)
        {
            throw new Exception("Controlador - Productos: " + ex.Message);
        }
    }

    // ── CONSULTA INVENTARIO ──────────────────────────────
    public DataTable ObtenerInventario(int idBodega, string tipoProducto,
                                   string orden, string codigo, string nombre)
    {
        try
        {
            return _modelo.ObtenerInventario(idBodega, tipoProducto, orden, codigo, nombre);
        }
        catch (Exception ex)
        {
            throw new Exception("Controlador - Inventario: " + ex.Message);
        }
    }
}