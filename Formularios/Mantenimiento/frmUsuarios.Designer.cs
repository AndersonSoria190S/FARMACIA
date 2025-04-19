namespace FARMACIA.Formularios.Mantenimiento
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnsalir = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            groupBox1 = new GroupBox();
            btnnuevousuario = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            btneditar = new DataGridViewButtonColumn();
            btneliminar = new DataGridViewButtonColumn();
            bindingSource1 = new BindingSource(components);
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbuscar = new TextBox();
            cbobuscar = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-5, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 49);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(0, 143, 213);
            btnsalir.ForeColor = SystemColors.ControlLightLight;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 24;
            btnsalir.Location = new Point(556, 11);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(69, 31);
            btnsalir.TabIndex = 210;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(17, 11);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(91, 24);
            Usuarios.TabIndex = 1;
            Usuarios.Text = "Usuarios";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 16);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnnuevousuario
            // 
            btnnuevousuario.Cursor = Cursors.Hand;
            btnnuevousuario.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnnuevousuario.IconColor = Color.Black;
            btnnuevousuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevousuario.IconSize = 17;
            btnnuevousuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevousuario.Location = new Point(18, 58);
            btnnuevousuario.Name = "btnnuevousuario";
            btnnuevousuario.Size = new Size(112, 28);
            btnnuevousuario.TabIndex = 2;
            btnnuevousuario.Text = "Nuevo usuario";
            btnnuevousuario.TextAlign = ContentAlignment.MiddleRight;
            btnnuevousuario.UseVisualStyleBackColor = true;
            btnnuevousuario.Click += btnnuevousuario_Click;
            // 
            // dgvdata
            // 
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Usuario, NombreCompleto, IdRol, Rol, Clave, btneditar, btneliminar });
            dgvdata.Location = new Point(18, 161);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(601, 223);
            dgvdata.TabIndex = 3;
            dgvdata.CellContentClick += dataGridView1_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Width = 150;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.Resizable = DataGridViewTriState.False;
            IdRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.Visible = false;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.Visible = false;
            // 
            // btneditar
            // 
            btneditar.HeaderText = "";
            btneditar.Name = "btneditar";
            btneditar.Resizable = DataGridViewTriState.True;
            btneditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.Resizable = DataGridViewTriState.True;
            btneliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnbuscar
            // 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(532, 124);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 4;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(390, 124);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 23);
            txtbuscar.TabIndex = 5;
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(260, 124);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(121, 23);
            cbobuscar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 127);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Buscar Por: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 8;
            label2.Text = "LISTA DE USUARIOS";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.Location = new Point(582, 124);
            iconButton1.Margin = new Padding(1);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 3, 0, 0);
            iconButton1.Size = new Size(37, 23);
            iconButton1.TabIndex = 9;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(638, 396);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(dgvdata);
            Controls.Add(btnnuevousuario);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Usuarios :.";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Usuarios;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnnuevousuario;
        private DataGridView dgvdata;
        private BindingSource bindingSource1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbuscar;
        private ComboBox cbobuscar;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewButtonColumn btneditar;
        private DataGridViewButtonColumn btneliminar;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}