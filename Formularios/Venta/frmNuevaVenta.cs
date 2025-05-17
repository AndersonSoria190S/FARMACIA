using FARMACIA.Formularios.Modales;
using FARMACIA.Logica;
using FARMACIA.Modelo;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;



namespace FARMACIA.Formularios.Venta
{
    public partial class frmNuevaVenta : Form
    {
        public string _NombreUsuario { get; set; }
        private static Producto _producto = null;
        public frmNuevaVenta(string NombreUsuario)
        {
            _NombreUsuario = NombreUsuario;
            InitializeComponent();
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            txtdoccliente.Focus();
            txtfecharegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txttotalpagar.Text = "0.00";
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var Iform = new mdClientes())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Cliente objeto = Iform._Cliente;
                    txtdoccliente.Text = objeto.NumeroDocumento;
                    txtnombrecliente.Text = objeto.NombreCompleto;
                    txtcodproducto.Select();
                }
                else
                {
                    txtdoccliente.Select();
                }
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var Iform = new mdProductos())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _producto = Iform._Producto;
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtcodproducto.Text = _producto.Codigo;
                    txtproducto.Text = _producto.Descripcion;
                    txtprecioventa.Text = _producto.PrecioVenta;
                    txtstock.Text = _producto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }
            }
        }

        private void txtcodproducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            string mensaje = string.Empty;
            if (e.KeyData == Keys.Enter)
            {
                Producto pr = ProductoLogica.Instancia.Listar(out mensaje).Where(p => p.Codigo.ToUpper() == txtcodproducto.Text.Trim().ToUpper()).FirstOrDefault();
                if (pr != null)
                {
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtcodproducto.Text = pr.Codigo;
                    txtproducto.Text = pr.Descripcion;
                    txtprecioventa.Text = pr.PrecioVenta;
                    txtstock.Text = pr.Stock.ToString();
                    _producto = pr;
                    txtcantidad.Value = 1;
                    txtcantidad.Focus();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    _producto = null;
                    txtproducto.Text = "";
                    txtprecioventa.Text = "";
                    txtstock.Text = "";
                    txtcantidad.Value = 1;
                }

            }
        }
        private bool producto_agregado()
        {

            bool respuesta = false;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvdata.Rows)
                {
                    if (fila.Cells["Id"].Value.ToString() == _producto.IdProducto.ToString())
                    {
                        respuesta = true;
                        break;
                    }
                }
            }

            return respuesta;
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            if (_producto == null)
            {
                MessageBox.Show("Debe ingresar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (producto_agregado())
            {
                MessageBox.Show("El producto ya está agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtcantidad.Value > _producto.Stock)
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal precioventa = 0;
            decimal subtotal = 0;
            if (!decimal.TryParse(_producto.PrecioVenta, out precioventa))
            {
                MessageBox.Show("Error al convertir internamente el tipo de moneda - Precio Venta\nEjemplo Formato ##.##", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string mensaje = string.Empty;
            int operaciones = VentaLogica.Instancia.reducirStock(_producto.IdProducto, Convert.ToInt32(txtcantidad.Value.ToString()), out mensaje);

            if (operaciones > 0)
            {
                subtotal = Convert.ToDecimal(txtcantidad.Value.ToString()) * precioventa;

                dgvdata.Rows.Add(new object[] {
                    _producto.IdProducto.ToString(),
                    _producto.Codigo,
                    _producto.Descripcion,
                    _producto.Categoria,
                    _producto.Medida,
                    txtcantidad.Value.ToString(),
                    precioventa.ToString("0.00"),
                    subtotal.ToString("0.00")
                });

                calcularTotal();

                _producto = null;
                txtcodproducto.Text = "";
                txtcodproducto.BackColor = Color.White;
                txtproducto.Text = "";
                txtstock.Text = "";
                txtprecioventa.Text = "";
                txtcantidad.Value = 1;
                txtcodproducto.Select();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete17.Width;
                var h = Properties.Resources.delete17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // e.Graphics.DrawImage(Properties.Resources.delete17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
                {
                    string mensaje = string.Empty;
                    int idproducto = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                    int cantidad = Convert.ToInt32(dgvdata.Rows[index].Cells["Cantidad"].Value.ToString());
                    int operaciones = VentaLogica.Instancia.aumentarStock(idproducto, cantidad, out mensaje);

                    if (operaciones > 0)
                    {
                        dgvdata.Rows.RemoveAt(index);
                        txtcodproducto.Select();
                        calcularTotal();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (txtdoccliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtnombrecliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            string mensaje = string.Empty;
            int cantidad_productos = 0;
            int idcorrelativo = VentaLogica.Instancia.ObtenerCorrelativo(out mensaje);
            List<DetalleVenta> olista = new List<DetalleVenta>();

            if (idcorrelativo < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                olista.Add(new DetalleVenta()
                {
                    IdProducto = Convert.ToInt32(row.Cells["Id"].Value.ToString()),
                    CodigoProducto = row.Cells["Codigo"].Value.ToString(),
                    DescripcionProducto = row.Cells["Producto"].Value.ToString(),
                    CategoriaProducto = row.Cells["Categoria"].Value.ToString(),
                    MedidaProducto = row.Cells["Medida"].Value.ToString(),
                    PrecioVenta = row.Cells["Precio"].Value.ToString(),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()),
                    SubTotal = row.Cells["SubTotal"].Value.ToString()
                });

                cantidad_productos += Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
            }

            calcularcambio();
            FARMACIA.Modelo.Venta oSalida = new FARMACIA.Modelo.Venta()
            {
                NumeroDocumento = String.Format("{0:00000}", idcorrelativo),
                FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                UsuarioRegistro = _NombreUsuario,
                DocumentoCliente = txtdoccliente.Text,
                NombreCliente = txtnombrecliente.Text,
                CantidadProductos = cantidad_productos,
                MontoTotal = txttotalpagar.Text,
                PagoCon = Convert.ToDecimal(txtpagocon.Text.Trim()).ToString("0.00"),
                Cambio = Convert.ToDecimal(txtcambio.Text.Trim()).ToString("0.00"),
                olistaDetalle = olista
            };


            int operaciones = VentaLogica.Instancia.Registrar(oSalida, out mensaje);

            if (operaciones < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Limpiar controles
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";
            dgvdata.Rows.Clear();
            txttotalpagar.Text = "0.00";
            txtpagocon.Text = "";
            txtcambio.Text = "";
            txtdoccliente.Focus();

            // Mostrar ventana de éxito
            var md = new mdVentaExitosa();
            md._numerodocumento = oSalida.NumeroDocumento;
            md.ShowDialog();

            // Generar recibo PDF
            try
            {
                string html = Properties.Resources.PlantillaVenta.ToString();
                Datos odatos = DatoLogica.Instancia.Obtener();

                html = html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
                html = html.Replace("@docnegocio", odatos.NIT);
                html = html.Replace("@direcnegocio", odatos.Direccion);
                html = html.Replace("@numerodocumento", oSalida.NumeroDocumento);
                html = html.Replace("@doccliente", oSalida.DocumentoCliente);
                html = html.Replace("@nombrecliente", oSalida.NombreCliente);
                html = html.Replace("@fecharegistro", DateTime.Now.ToString("dd/MM/yyyy"));
                html = html.Replace("@usuarioregistro", oSalida.UsuarioRegistro);

                string filas = "";
                foreach (var item in oSalida.olistaDetalle)
                {
                    filas += "<tr>";
                    filas += $"<td>{item.DescripcionProducto}</td>";
                    filas += $"<td>{item.Cantidad}</td>";
                    filas += $"<td>{item.PrecioVenta}</td>";
                    filas += $"<td>{item.SubTotal}</td>";
                    filas += "</tr>";
                }

                html = html.Replace("@filas", filas);
                html = html.Replace("@montototal", oSalida.MontoTotal);
                html = html.Replace("@pagocon", oSalida.PagoCon);
                html = html.Replace("@cambio", oSalida.Cambio);

                bool obtenido = true;
                byte[] logo = DatoLogica.Instancia.ObtenerLogo(out obtenido);

                using (SaveFileDialog savefile = new SaveFileDialog())
                {
                    savefile.FileName = $"Venta_{oSalida.NumeroDocumento}.pdf";
                    savefile.Filter = "Pdf Files|*.pdf";

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            if (obtenido && logo != null)
                            {
                                var img = iTextSharp.text.Image.GetInstance(logo);
                                img.ScaleToFit(60, 60);
                                img.Alignment = iTextSharp.text.Image.UNDERLYING;
                                img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                                pdfDoc.Add(img);
                            }

                            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                            using (var sr = new StringReader(html))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            MessageBox.Show("Recibo en PDF generado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void calcularcambio()
        {
            if (txttotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "0";
            }


            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }
    }
}
