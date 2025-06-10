using FARMACIA.Formularios.Compras;

namespace FARMACIA.Formularios.Intermedios
{
    public partial class ICompras : Form
    {
        public Form FormularioVista { get; set; }
        public string _NombreUsuario { get; set; }
        public ICompras()
        {
            InitializeComponent();
        }

        private void btnnuevacompra_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmNuevaCompra(_NombreUsuario);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ICompras_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlistacompra_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmListaCompras();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnbuscarcompra_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmBuscarCompra();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
