using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FARMACIA.Formularios.Modales
{
    public partial class mdCompraExistosa : Form
    {
        public string _numerodocumento { get; set; }
        public mdCompraExistosa()
        {
            InitializeComponent();
        }

        private void mdCompraExistosa_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = _numerodocumento;
            txtnumerodocumento.Focus();
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
