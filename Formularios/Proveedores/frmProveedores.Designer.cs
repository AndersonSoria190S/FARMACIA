namespace FARMACIA.Formularios.Proveedores
{
    partial class frmProveedores
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
            panel1 = new Panel();
            btnsalir = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            label2 = new Label();
            btnnuevoproveedor = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            NroFila = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            btneditar = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 49);
            panel1.TabIndex = 17;
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
            Usuarios.Location = new Point(3, 12);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(129, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Proveedores\r\n";
            Usuarios.Click += Usuarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(11, 106);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 195;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // btnnuevoproveedor
            // 
            btnnuevoproveedor.BackColor = SystemColors.Control;
            btnnuevoproveedor.Cursor = Cursors.Hand;
            btnnuevoproveedor.FlatStyle = FlatStyle.Popup;
            btnnuevoproveedor.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnnuevoproveedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnnuevoproveedor.IconColor = Color.Black;
            btnnuevoproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevoproveedor.IconSize = 17;
            btnnuevoproveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevoproveedor.Location = new Point(12, 59);
            btnnuevoproveedor.Name = "btnnuevoproveedor";
            btnnuevoproveedor.Size = new Size(118, 21);
            btnnuevoproveedor.TabIndex = 194;
            btnnuevoproveedor.Text = "Nuevo Proveedor";
            btnnuevoproveedor.TextAlign = ContentAlignment.MiddleRight;
            btnnuevoproveedor.UseVisualStyleBackColor = false;
            btnnuevoproveedor.Click += btnnuevoproveedor_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(11, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 12);
            groupBox1.TabIndex = 197;
            groupBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.Location = new Point(588, 104);
            iconButton1.Margin = new Padding(1);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 3, 0, 0);
            iconButton1.Size = new Size(37, 23);
            iconButton1.TabIndex = 202;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 107);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 201;
            label1.Text = "Buscar Por: ";
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(289, 104);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(121, 23);
            cbobuscar.TabIndex = 200;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(416, 104);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 23);
            txtbuscar.TabIndex = 199;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = SystemColors.Window;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(549, 104);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 198;
            btnbuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { NroFila, NombreCompleto, NumeroDocumento, btneditar, btneliminar });
            dgvdata.Location = new Point(11, 142);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(614, 243);
            dgvdata.TabIndex = 203;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // NroFila
            // 
            NroFila.HeaderText = "";
            NroFila.Name = "NroFila";
            NroFila.Resizable = DataGridViewTriState.False;
            NroFila.SortMode = DataGridViewColumnSortMode.NotSortable;
            NroFila.Visible = false;
            NroFila.Width = 70;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Numero Documento";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Resizable = DataGridViewTriState.False;
            NombreCompleto.SortMode = DataGridViewColumnSortMode.NotSortable;
            NombreCompleto.Width = 200;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Nombre Completo";
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Resizable = DataGridViewTriState.False;
            NumeroDocumento.SortMode = DataGridViewColumnSortMode.NotSortable;
            NumeroDocumento.Width = 200;
            // 
            // btneditar
            // 
            btneditar.HeaderText = "";
            btneditar.Name = "btneditar";
            btneditar.Resizable = DataGridViewTriState.False;
            btneditar.SortMode = DataGridViewColumnSortMode.NotSortable;
            btneditar.Width = 35;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.Width = 35;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
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
            Controls.Add(btnnuevoproveedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Proveedores :.";
            Load += frmProveedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Usuarios;
        private FontAwesome.Sharp.IconButton btnsalir;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnnuevoproveedor;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn NroFila;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn btneditar;
        private DataGridViewButtonColumn btneliminar;
    }
}