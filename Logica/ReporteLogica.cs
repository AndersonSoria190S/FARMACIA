using System.Data.SQLite;

namespace FARMACIA.Logica
{
    public class ReporteLogica
    {
        public List<(string Categoria, int TotalVendidos)> ObtenerVentasPorCategoria(int top = 0)
        {
            List<(string, int)> lista = new List<(string, int)>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = @"
                SELECT CategoriaProducto, SUM(Cantidad) AS TotalVendidos
                FROM DETALLE_VENTA
                GROUP BY CategoriaProducto
                ORDER BY TotalVendidos DESC";

                    if (top > 0)
                    {
                        query += " LIMIT @top";
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        if (top > 0)
                            cmd.Parameters.AddWithValue("@top", top);

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string categoria = dr["CategoriaProducto"].ToString();
                                int total = Convert.ToInt32(dr["TotalVendidos"]);
                                lista.Add((categoria, total));
                            }
                        }
                    }
                }
            }
            catch
            {
                lista = new List<(string, int)>();
            }
            return lista;
        }

        public List<(string Producto, int Total)> ObtenerProductosMasVendidos(int top = 0)
        {
            var lista = new List<(string, int)>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = @"
                SELECT DescripcionProducto, SUM(Cantidad) AS Total
                FROM DETALLE_VENTA
                GROUP BY DescripcionProducto
                ORDER BY Total DESC";

                    if (top > 0)
                    {
                        query += " LIMIT @top";
                    }

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        if (top > 0)
                            cmd.Parameters.AddWithValue("@top", top);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add((dr["DescripcionProducto"].ToString(), Convert.ToInt32(dr["Total"])));
                            }
                        }
                    }
                }
            }
            catch
            {
                lista = new List<(string, int)>();
            }
            return lista;
        }


        public List<(string Fecha, decimal Total)> ObtenerVentasPorDia(int top = 0)
        {
            var lista = new List<(string, decimal)>();
            try
            {
                using (var conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = @"
                SELECT FechaRegistro, SUM(MontoTotal) as Total
                FROM VENTA
                WHERE Activo = 1
                GROUP BY FechaRegistro
                ORDER BY FechaRegistro";

                    if (top > 0)
                        query += " LIMIT @top";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        if (top > 0)
                            cmd.Parameters.AddWithValue("@top", top);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add((dr["FechaRegistro"].ToString(), Convert.ToDecimal(dr["Total"])));
                            }
                        }
                    }
                }
            }
            catch
            {
                lista = new List<(string, decimal)>();
            }
            return lista;
        }

        public List<(string Producto, int Stock)> ObtenerStockBajo(int top = 0)
        {
            var lista = new List<(string, int)>();
            try
            {
                using (var conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = @"
                SELECT Descripcion, Stock
                FROM PRODUCTO_FARMACIA
                WHERE Stock < 1000
                ORDER BY Stock ASC";

                    if (top > 0)
                        query += " LIMIT @top";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        if (top > 0)
                            cmd.Parameters.AddWithValue("@top", top);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add((dr["Descripcion"].ToString(), Convert.ToInt32(dr["Stock"])));
                            }
                        }
                    }
                }
            }
            catch
            {
                lista = new List<(string, int)>();
            }
            return lista;
        }

        public List<(string Producto, int DiasRestantes)> ObtenerProductosPorVencer(int top = 0)
        {
            var lista = new List<(string, int)>();
            try
            {
                using (var conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = @"
                SELECT Descripcion, FechaVencimiento
                FROM PRODUCTO_FARMACIA
                WHERE FechaVencimiento <= DATE('now', '+30 days')
                ORDER BY FechaVencimiento ASC";

                    if (top > 0)
                        query += " LIMIT @top";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        if (top > 0)
                            cmd.Parameters.AddWithValue("@top", top);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string descripcion = dr["Descripcion"].ToString();
                                DateTime fechaVencimiento = DateTime.Parse(dr["FechaVencimiento"].ToString());
                                int diasRestantes = (fechaVencimiento.Date - DateTime.Now.Date).Days; // corregido cálculo días

                                lista.Add((descripcion, diasRestantes));
                            }
                        }
                    }
                }
            }
            catch
            {
                lista = new List<(string, int)>();
            }
            return lista;
        }

        public List<(string Usuario, int TotalVentas)> ObtenerUsuariosConMasVentas(int top = 10)
        {
            var lista = new List<(string, int)>();
            try
            {
                using (var conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = @"
                SELECT UsuarioRegistro, COUNT(*) AS TotalVentas
                FROM VENTA
                WHERE Activo = 1
                GROUP BY UsuarioRegistro
                ORDER BY TotalVentas DESC
                LIMIT @top";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@top", top);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add((dr["UsuarioRegistro"].ToString(), Convert.ToInt32(dr["TotalVentas"])));
                            }
                        }
                    }
                }
            }
            catch
            {
                lista = new List<(string, int)>();
            }
            return lista;
        }

        public List<(string Usuario, decimal MontoTotal)> ObtenerMontoVentasPorUsuario(int top = 10)
        {
            var lista = new List<(string, decimal)>();
            try
            {
                using (var conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = @"
                SELECT UsuarioRegistro, SUM(MontoTotal) AS MontoTotal
                FROM VENTA
                WHERE Activo = 1
                GROUP BY UsuarioRegistro
                ORDER BY MontoTotal DESC
                LIMIT @top";

                    using (var cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@top", top);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add((dr["UsuarioRegistro"].ToString(), Convert.ToDecimal(dr["MontoTotal"])));
                            }
                        }
                    }
                }
            }
            catch
            {
                lista = new List<(string, decimal)>();
            }
            return lista;
        }

    }


}
