using FARMACIA.Formularios.Mantenimiento;

namespace FARMACIA.Intermedios
{
    public partial class IMantenimiento : Form
    {
        public Form FormularioVista { get; set; }
        public string _NombreUsuario { get; set; }
        public IMantenimiento()
        {
            InitializeComponent();
        }

        private void IMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmUsuarios();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnbuscarcompra_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmPermisos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
