using System.Data.Odbc;

public class CNX
{
    private static string cadena = "DSN=bd_SIG;";

    public static OdbcConnection ObtenerConexion()
    {
        return new OdbcConnection(cadena);
    }
}
