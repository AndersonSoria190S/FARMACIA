using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using FARMACIA.Formularios.Intermedios;
using FARMACIA.Herramientas;
using FARMACIA.Modelo;
using FARMACIA.Logica;
namespace FARMACIA.Formularios.Productos
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {

                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvdata.Columns)
                {
                    if (column.HeaderText != "" && column.Visible == true)
                        dt.Columns.Add(column.HeaderText, typeof(string));
                }


                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    dt.Rows.Add(new object[] {
                    row.Cells[1].Value?.ToString() ?? "",
                    row.Cells[2].Value?.ToString() ?? "",
                    row.Cells[3].Value?.ToString() ?? "",
                    row.Cells[4].Value?.ToString() ?? "",
                    row.Cells[5].Value?.ToString() ?? "",
                    row.Cells[6].Value?.ToString() ?? "",
                    row.Cells[7].Value?.ToString() ?? ""
                });

                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte_Productos_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            List<Producto> lista = ProductoLogica.Instancia.Listar(out mensaje);

            foreach (Producto pr in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    pr.IdProducto,
                    pr.Codigo,
                    pr.Descripcion,
                    pr.Categoria,
                    pr.Medida,
                    pr.PrecioCompra,
                    pr.PrecioVenta,
                    pr.Stock,
                    "",
                    "",
                });
            }

            foreach (DataGridViewColumn cl in dgvdata.Columns)
            {
                if (cl.Visible == true && cl.HeaderText != "")
                {
                    cbobuscar.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;
        }

        private void btnnuevoproducto_Click(object sender, EventArgs e)
        {
            using (var mdForm = new frmMantProducto())
            {
                mdForm._modo_editar = false;
                var result = mdForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvdata.Rows.Add(new object[] { mdForm._Producto.IdProducto,
                        mdForm._Producto.Codigo,
                        mdForm._Producto.Descripcion,
                        mdForm._Producto.Categoria,
                        mdForm._Producto.Medida,
                        "0",
                        "0",
                        "0",
                        "", "" });
                    btnnuevoproducto.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var mdForm = new frmMantProducto())
            {
                mdForm._modo_editar = false;
                var result = mdForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvdata.Rows.Add(new object[] { mdForm._Producto.IdProducto,
                        mdForm._Producto.Codigo,
                        mdForm._Producto.Descripcion,
                        mdForm._Producto.Categoria,
                        mdForm._Producto.Medida,
                        "0",
                        "0",
                        "0",
                        "", "" });
                    btnnuevoproducto.Focus();
                }
            }
        }
    }
}
