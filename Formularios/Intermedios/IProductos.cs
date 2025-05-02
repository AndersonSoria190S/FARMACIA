using FARMACIA.Formularios.Productos;

namespace FARMACIA.Formularios.Intermedios
{
    public partial class IProductos : Form
    {
        public Form FormularioVista { get; set; }
        public string _NombreUsuario { get; set; }
        public IProductos()
        {
            InitializeComponent();
        }

        private void btnnuevacompra_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmProductos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            FormularioVista = new frmCargaMasiva();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btngenerarbarras_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmGenerarBarras();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
