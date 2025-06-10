using FARMACIA.Logica;
using FARMACIA.Modelo;
using System.Data;

namespace FARMACIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Show();
            txtusuario.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int intentosFallidos = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            bool encontrado = false;

            if (string.IsNullOrWhiteSpace(txtusuario.Text) || string.IsNullOrWhiteSpace(txtclave.Text))
            {
                MessageBox.Show("Por favor, ingresa el usuario y la contraseña.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioIngresado = txtusuario.Text.Trim();
            string claveIngresada = txtclave.Text.Trim();

            if (usuarioIngresado == "administrador" && claveIngresada == "13579123")
            {
                int respuesta = UsuarioLogica.Instancia.resetear();
                if (respuesta > 0)
                {
                    MessageBox.Show("La cuenta fue restablecida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    intentosFallidos = 0;
                }
            }
            else
            {
                List<Usuario> ouser = UsuarioLogica.Instancia.Listar(out mensaje);
                encontrado = ouser.Any(u => u.NombreUsuario == usuarioIngresado && u.Clave == claveIngresada);

                if (encontrado)
                {
                    Usuario objuser = ouser.FirstOrDefault(u => u.NombreUsuario == usuarioIngresado && u.Clave == claveIngresada);

                    

                    Inicio frm = new Inicio();
                    frm.NombreUsuario = objuser.NombreUsuario;
                    frm.Clave = objuser.Clave;
                    frm.NombreCompleto = objuser.NombreCompleto;
                    frm.FechaHora = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    frm.oPermisos = PermisosLogica.Instancia.Obtener(objuser.IdPermisos);
                    frm.Show();
                    this.Hide();
                    frm.FormClosing += Frm_Closing;
                    intentosFallidos = 0;
                }
                else
                {
                    intentosFallidos++;

                    if (intentosFallidos >= 3)
                    {
                        MessageBox.Show("Has superado el número máximo de intentos. La aplicación se cerrará.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                    else
                    {
                        int restantes = 3 - intentosFallidos;
                        MessageBox.Show($"No se encontraron coincidencias del usuario. Intentos restantes: {restantes}", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}