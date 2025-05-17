namespace FARMACIA.Formularios.Clientes
{
    partial class frmClientes
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
            dgvdata = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnnuevocliente = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnsalir = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            Id = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            btneditar = new DataGridViewButtonColumn();
            btneliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, NumeroDocumento, NombreCompleto, btneditar, btneliminar });
            dgvdata.Location = new Point(10, 146);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(614, 243);
            dgvdata.TabIndex = 213;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.Location = new Point(587, 108);
            iconButton1.Margin = new Padding(1);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 3, 0, 0);
            iconButton1.Size = new Size(37, 23);
            iconButton1.TabIndex = 212;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 111);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 211;
            label1.Text = "Buscar Por: ";
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(288, 108);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(121, 23);
            cbobuscar.TabIndex = 210;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(415, 108);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 23);
            txtbuscar.TabIndex = 209;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = SystemColors.Window;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(548, 108);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 208;
            btnbuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(10, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 12);
            groupBox1.TabIndex = 207;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(10, 110);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 206;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // btnnuevocliente
            // 
            btnnuevocliente.BackColor = SystemColors.Control;
            btnnuevocliente.Cursor = Cursors.Hand;
            btnnuevocliente.FlatStyle = FlatStyle.Popup;
            btnnuevocliente.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnnuevocliente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnnuevocliente.IconColor = Color.Black;
            btnnuevocliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevocliente.IconSize = 17;
            btnnuevocliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevocliente.Location = new Point(11, 63);
            btnnuevocliente.Name = "btnnuevocliente";
            btnnuevocliente.Size = new Size(102, 21);
            btnnuevocliente.TabIndex = 205;
            btnnuevocliente.Text = "Nuevo Cliente";
            btnnuevocliente.TextAlign = ContentAlignment.MiddleRight;
            btnnuevocliente.UseVisualStyleBackColor = false;
            btnnuevocliente.Click += btnnuevocliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 53);
            panel1.TabIndex = 204;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(0, 143, 213);
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.ForeColor = SystemColors.ControlLightLight;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnsalir.IconSize = 24;
            btnsalir.Location = new Point(552, 10);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(73, 31);
            btnsalir.TabIndex = 212;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(12, 17);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(85, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Clientes";
            // 
            // Id
            // 
            Id.HeaderText = "";
            Id.Name = "Id";
            Id.Resizable = DataGridViewTriState.False;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Visible = false;
            Id.Width = 70;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Resizable = DataGridViewTriState.False;
            NumeroDocumento.SortMode = DataGridViewColumnSortMode.NotSortable;
            NumeroDocumento.Width = 200;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Resizable = DataGridViewTriState.False;
            NombreCompleto.SortMode = DataGridViewColumnSortMode.NotSortable;
            NombreCompleto.Width = 200;
            // 
            // btneditar
            // 
            btneditar.HeaderText = "";
            btneditar.Name = "btneditar";
            btneditar.Resizable = DataGridViewTriState.False;
            btneditar.Width = 35;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.Width = 35;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(639, 397);
            ControlBox = false;
            Controls.Add(dgvdata);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btnnuevocliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private GroupBox groupBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnnuevocliente;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private Label Usuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewButtonColumn btneditar;
        private DataGridViewButtonColumn btneliminar;
    }
}