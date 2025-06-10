using FARMACIA.Logica;
using FARMACIA.Modelo;

namespace FARMACIA.Formularios.Clientes
{
    public partial class frmMantCliente : Form
    {
        public bool _modo_editar { get; set; }
        public Cliente _Cliente { get; set; }
        public frmMantCliente()
        {
            InitializeComponent();
        }

        private void frmMantCliente_Load(object sender, EventArgs e)
        {
            if (_modo_editar)
            {
                txtnombre.Text = _Cliente.NombreCompleto;
                txtnumero.Text = _Cliente.NumeroDocumento;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            lblresultado1.Visible = true;
            string mensaje = string.Empty;

            if (txtnumero.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar el numero de documento";
                lblresultado1.ForeColor = Color.Red;
                return;
            }
            if (txtnombre.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar el nombre completo";
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            if (_Cliente != null)
            {
                _Cliente.NumeroDocumento = txtnumero.Text;
                _Cliente.NombreCompleto = txtnombre.Text;
            }
            else
                _Cliente = new Cliente() { IdCliente = 0, NumeroDocumento = txtnumero.Text, NombreCompleto = txtnombre.Text };

            int existe = ClienteLogica.Instancia.Existe(_Cliente.NumeroDocumento, _Cliente.IdCliente, out mensaje);
            if (existe > 0)
            {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            if (!_modo_editar)
            {
                int idgenerado = ClienteLogica.Instancia.Guardar(_Cliente, out mensaje);
                if (idgenerado > 0)
                {
                    _Cliente.IdCliente = idgenerado;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblresultado1.Text = mensaje;
                    lblresultado1.ForeColor = Color.Red;
                }
            }
            else
            {
                int afectados = ClienteLogica.Instancia.Editar(_Cliente, out mensaje);
                if (afectados > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblresultado1.Text = mensaje;
                    lblresultado1.ForeColor = Color.Red;
                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
