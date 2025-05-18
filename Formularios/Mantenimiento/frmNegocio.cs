using FARMACIA.Logica;
using FARMACIA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace FARMACIA.Formularios.Mantenimiento
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = DatoLogica.Instancia.ObtenerLogo(out obtenido);
            if (obtenido)
                picLogo.Image = ByteToImage(byteimage);


            Datos da = DatoLogica.Instancia.Obtener();
            txtrazonsocial.Text = da.RazonSocial;
            txtruc.Text = da.NIT;
            txtdireccion.Text = da.Direccion;
        }
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (txtrazonsocial.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar Razón Social");

                return;
            }
            if (txtruc.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar N.I.T", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtdireccion.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar direccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            int nrooperacion = DatoLogica.Instancia.Guardar(new Datos()
            {
                RazonSocial = txtrazonsocial.Text,
                NIT = txtruc.Text,
                Direccion = txtdireccion.Text
            }, out mensaje);

            if (nrooperacion < 1)
            {
                System.Windows.Forms.MessageBox.Show("No se pudo guardar los cambios, intente más tarde", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                int numerooperacion = DatoLogica.Instancia.ActualizarLogo(byteImagen, out mensaje);

                if (numerooperacion < 1)
                {
                    System.Windows.Forms.MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    picLogo.Image = ByteToImage(byteImagen);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
