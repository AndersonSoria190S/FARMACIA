using FARMACIA.Herramientas;
using FARMACIA.Logica;
using FARMACIA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FARMACIA.Formularios.Mantenimiento
{
    public partial class frmMantUsuario : Form
    {
        public bool _modo_editar { get; set; }
        public Usuario _Usuario { get; set; }
        public frmMantUsuario()
        {
            InitializeComponent();
        }

        private void frmMantUsuario_Load(object sender, EventArgs e)
        {
            cborol.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Administrador" });
            cborol.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Farmaceutico" });
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;


            if (_modo_editar)
            {
                txtusuario.Text = _Usuario.NombreUsuario;
                txtnombre.Text = _Usuario.NombreCompleto;
                int encontrado = 0;
                foreach (OpcionCombo oc in cborol.Items)
                {
                    if (Convert.ToInt32(oc.Valor.ToString()) == _Usuario.IdPermisos)
                    {
                        break;
                    }
                    encontrado++;
                }
                cborol.SelectedIndex = encontrado;
                txtclave.Text = _Usuario.Clave;
                txtconfirmarclave.Text = _Usuario.Clave;
            }
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            lblresultado.Visible = true;
            string mensaje = string.Empty;

            if (txtusuario.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar el usuario";
                lblresultado.ForeColor = Color.Red;
                return;
            }
            if (txtnombre.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar el nombre";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (txtclave.Text.Trim() == "" || txtconfirmarclave.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar las claves";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (txtclave.Text.Trim() != txtconfirmarclave.Text.Trim())
            {
                lblresultado.Text = "Las contraseñas no coinciden";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (_Usuario != null)
            {
                _Usuario.NombreUsuario = txtusuario.Text;
                _Usuario.NombreCompleto = txtnombre.Text;
                _Usuario.IdPermisos = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor.ToString());
                _Usuario.Descripcion = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
                _Usuario.Clave = txtclave.Text;
            }
            else
                _Usuario = new Usuario()
                {
                    IdUsuario = 0,
                    NombreUsuario = txtusuario.Text,
                    NombreCompleto = txtnombre.Text,
                    IdPermisos = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor.ToString()),
                    Descripcion = ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
                    Clave = txtclave.Text
                };

            int existe = UsuarioLogica.Instancia.Existe(_Usuario.NombreUsuario, _Usuario.IdUsuario, out mensaje);
            if (existe > 0)
            {
                lblresultado.Text = mensaje;
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (!_modo_editar)
            {
                int idgenerado = UsuarioLogica.Instancia.Guardar(_Usuario, out mensaje);
                if (idgenerado > 0)
                {
                    _Usuario.IdUsuario = idgenerado;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblresultado.Text = mensaje;
                    lblresultado.ForeColor = Color.Red;
                }
            }
            else
            {
                int afectados = UsuarioLogica.Instancia.Editar(_Usuario, out mensaje);
                if (afectados > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblresultado.Text = mensaje;
                    lblresultado.ForeColor = Color.Red;
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rol_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
