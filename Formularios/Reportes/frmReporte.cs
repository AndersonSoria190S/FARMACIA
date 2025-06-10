using FARMACIA.Logica;
using System.Windows.Forms.DataVisualization.Charting;

namespace FARMACIA.Formularios.Reportes
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            // Nodo Ventas
            TreeNode nodoVentas = treeView1.Nodes.Add("Ventas");
            nodoVentas.Nodes.Add("Por categoría");
            nodoVentas.Nodes.Add("Por día");
            nodoVentas.Nodes.Add("Productos más vendidos");

            // Nodo Inventario
            TreeNode nodoInventario = treeView1.Nodes.Add("Inventario");
            nodoInventario.Nodes.Add("Stock bajo");
            nodoInventario.Nodes.Add("Próximos a vencer");

            // Nodo Usuarios
            TreeNode nodoUsuarios = treeView1.Nodes.Add("Usuarios");
            nodoUsuarios.Nodes.Add("Usuarios con más ventas");
            nodoUsuarios.Nodes.Add("Monto ventas por usuario");

            treeView1.ExpandAll();
            treeView1.SelectedNode = nodoVentas.Nodes[0]; // Selección inicial

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Pie");
            comboBox1.Items.Add("Bar");
            comboBox1.Items.Add("Column");
            comboBox1.SelectedIndex = 0;

            // Carga gráfico inicial con top 3
            MostrarGrafico(treeView1.SelectedNode.Text, comboBox1.SelectedItem.ToString(), Convert.ToInt32(txtTop.Text));
        }

        public void MostrarGrafico(string reporte, string tipo, int top)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            Series serie = new Series("Datos");
            serie.ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), tipo);
            serie.IsValueShownAsLabel = true;

            var logica = new ReporteLogica();

            // --- Reportes de VENTAS ---
            if (reporte == "Por categoría")
            {
                var porCategoria = logica.ObtenerVentasPorCategoria(top);
                foreach (var item in porCategoria)
                    serie.Points.AddXY(item.Categoria, item.TotalVendidos);
                chart1.Titles.Add("Ventas por Categoría");
            }
            else if (reporte == "Por día")
            {
                var porDia = logica.ObtenerVentasPorDia(top);
                foreach (var item in porDia)
                    serie.Points.AddXY(item.Fecha, item.Total);
                chart1.Titles.Add("Ventas por Día");
            }
            else if (reporte == "Productos más vendidos")
            {
                var productos = logica.ObtenerProductosMasVendidos(top);
                foreach (var item in productos)
                    serie.Points.AddXY(item.Producto, item.Total);
                chart1.Titles.Add("Productos Más Vendidos");
            }
            // --- Reportes de INVENTARIO ---
            else if (reporte == "Stock bajo")
            {
                var stockBajo = logica.ObtenerStockBajo(top);
                foreach (var item in stockBajo)
                    serie.Points.AddXY(item.Producto, item.Stock);
                chart1.Titles.Add("Productos con Stock Bajo");
            }
            else if (reporte == "Próximos a vencer")
            {
                var porVencer = logica.ObtenerProductosPorVencer(top);
                foreach (var item in porVencer)
                    serie.Points.AddXY(item.Producto, item.DiasRestantes);
                serie.XValueType = ChartValueType.String;
                chart1.Titles.Add("Productos Próximos a Vencer");
            }
            // --- Reportes de USUARIOS ---
            else if (reporte == "Usuarios con más ventas")
            {
                var usuariosVentas = logica.ObtenerUsuariosConMasVentas(top);
                foreach (var item in usuariosVentas)
                    serie.Points.AddXY(item.Usuario, item.TotalVentas);
                chart1.Titles.Add("Usuarios con Más Ventas");
            }
            else if (reporte == "Monto ventas por usuario")
            {
                var montoVentasUsuario = logica.ObtenerMontoVentasPorUsuario(top);
                foreach (var item in montoVentasUsuario)
                    serie.Points.AddXY(item.Usuario, item.MontoTotal);
                chart1.Titles.Add("Monto Total de Ventas por Usuario");
            }
            else
            {
                // Opcional: manejar casos no contemplados
                chart1.Titles.Add("Reporte no definido");
            }

            chart1.Series.Add(serie);
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string reporte = treeView1.SelectedNode.Text;
                string tipo = comboBox1.SelectedItem.ToString();
                MostrarGrafico(reporte, tipo, Convert.ToInt32(txtTop.Text));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && comboBox1.SelectedItem != null)
            {
                string reporte = treeView1.SelectedNode.Text;
                string tipo = comboBox1.SelectedItem.ToString();
                MostrarGrafico(reporte, tipo, Convert.ToInt32(txtTop.Text));
            }
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string reporte = e.Node.Text;
                string tipo = comboBox1.SelectedItem.ToString();
                MostrarGrafico(reporte, tipo, Convert.ToInt32(txtTop.Text));
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTop_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;  // Evita que el sonido de beep ocurra
                e.SuppressKeyPress = true;

                if (treeView1.SelectedNode != null && comboBox1.SelectedItem != null)
                {
                    string reporte = treeView1.SelectedNode.Text;
                    string tipo = comboBox1.SelectedItem.ToString();

                    int top;
                    if (int.TryParse(txtTop.Text, out top))
                    {
                        MostrarGrafico(reporte, tipo, top);
                    }
                    else
                    {
                        // Opcional: mostrar mensaje de error por valor no válido
                        MessageBox.Show("Ingrese un número válido para el Top.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
