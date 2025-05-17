using FARMACIA.Formularios.Clientes;
using FARMACIA.Formularios.Intermedios;
using FARMACIA.Formularios.Proveedores;
using FARMACIA.Intermedios;

namespace FARMACIA
{

    public partial class Inicio : Form
    {
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string FechaHora { get; set; }
        public string Clave { get; set; }

        public FARMACIA.Modelo.Permisos oPermisos { get; set; }
        public Inicio()
        {
            InitializeComponent();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            lblstatus1.Text = string.Format("{0}", NombreUsuario);
            lblstatus2.Text = string.Format("{0}", FechaHora);

            if (oPermisos.Ventas == 0)
            {
                menuVentas.Enabled = false;
                menuVentas.Cursor = Cursors.No;
            }
            if (oPermisos.Compras == 0)
            {
                menuReportes.Enabled = false;
                menuReportes.Cursor = Cursors.No;
            }
            if (oPermisos.Productos == 0)
            {
                menuProductos.Enabled = false;
                menuProductos.Cursor = Cursors.No;
            }
            if (oPermisos.Clientes == 0)
            {
                menuClientes.Enabled = false;
                menuClientes.Cursor = Cursors.No;
            }
            if (oPermisos.Proveedores == 0)
            {
                menuCompras.Enabled = false;
                menuCompras.Cursor = Cursors.No;
            }

            if (oPermisos.Mantenimiento == 0)
            {
                menuMantenimiento.Enabled = false;
                menuMantenimiento.Cursor = Cursors.No;
            }
        }

        private void Frm_Closing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            using (var Iform = new IMantenimiento())
            {

                Iform._NombreUsuario = NombreUsuario;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            using (var Iform = new IProductos())
            {

                Iform._NombreUsuario = NombreUsuario;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores FormularioVista = new frmProveedores();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
        }

        private void menuCompras_Click(object sender, EventArgs e)
        {
            using (var Iform = new ICompras())
            {

                Iform._NombreUsuario = NombreUsuario;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            frmClientes FormularioVista = new frmClientes();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
        }
    }
}
