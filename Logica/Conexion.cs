using System.Configuration;

namespace FARMACIA.Logica
{
    internal class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
