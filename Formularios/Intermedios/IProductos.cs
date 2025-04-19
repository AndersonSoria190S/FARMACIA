using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            
        }
    }
}
