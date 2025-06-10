using FARMACIA.Logica;

namespace FARMACIA.Formularios.Mantenimiento
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            int operaciones = PermisosLogica.Instancia.Guardar(new Modelo.Permisos()
            {
                IdPermisos = 1,
                Ventas = 1,
                Compras = 1,
                Productos = 1,
                Clientes = 1,
                Proveedores = 1,
                Mantenimiento = 1
            }, out mensaje);

            if (operaciones < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Se guardaron los permisos del administrador (todos activos)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int _e_ventas = 0;
            int _e_compras = 0;
            int _e_productos = 0;
            int _e_clientes = 0;
            int _e_proveedores = 0;
            int _e_mantenimiento = 0;

            if (e_ventas.Checked)
                _e_ventas = 1;

            if (e_compras.Checked)
                _e_compras = 1;

            if (e_productos.Checked)
                _e_productos = 1;

            if (e_clientes.Checked)
                _e_clientes = 1;

            if (e_proveedores.Checked)
                _e_proveedores = 1;

            if (e_mantenimiento.Checked)
                _e_mantenimiento = 1;


            string mensaje = string.Empty;

            int operaciones = PermisosLogica.Instancia.Guardar(new Modelo.Permisos()
            {
                IdPermisos = 2,
                Ventas = _e_ventas,
                Compras = _e_compras,
                Productos = _e_productos,
                Clientes = _e_clientes,
                Proveedores = _e_proveedores,
                Mantenimiento = _e_mantenimiento
            }, out mensaje);

            if (operaciones < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            Modelo.Permisos padmin = PermisosLogica.Instancia.Obtener(1);
            Modelo.Permisos pemple = PermisosLogica.Instancia.Obtener(2);

            a_ventas.Checked = true;
            a_compras.Checked = true;
            a_productos.Checked = true;
            a_clientes.Checked = true;
            a_proveedores.Checked = true;
            a_mantenimiento.Checked = true;

            a_ventas.Enabled = false;
            a_compras.Enabled = false;
            a_productos.Enabled = false;
            a_clientes.Enabled = false;
            a_proveedores.Enabled = false;
            a_mantenimiento.Enabled = false;

            e_ventas.Checked = pemple.Ventas == 1 ? true : false;
            e_compras.Checked = pemple.Compras == 1 ? true : false;
            e_productos.Checked = pemple.Productos == 1 ? true : false;
            e_clientes.Checked = pemple.Clientes == 1 ? true : false;
            e_proveedores.Checked = pemple.Proveedores == 1 ? true : false;
            e_mantenimiento.Checked = pemple.Mantenimiento == 1 ? true : false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
