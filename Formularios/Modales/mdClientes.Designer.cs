namespace FARMACIA.Formularios.Modales
{
    partial class mdClientes
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
            label1 = new Label();
            btnborrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbuscar = new TextBox();
            cbobuscar = new ComboBox();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 66);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 213;
            label1.Text = "Buscar por: ";
            // 
            // btnborrar
            // 
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 18;
            btnborrar.Location = new Point(440, 63);
            btnborrar.Margin = new Padding(1);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new Padding(0, 3, 0, 0);
            btnborrar.Size = new Size(37, 23);
            btnborrar.TabIndex = 212;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(401, 62);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 211;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(262, 62);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(135, 23);
            txtbuscar.TabIndex = 210;
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(111, 62);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(145, 23);
            cbobuscar.TabIndex = 209;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, NumeroDocumento, NombreCompleto });
            dgvdata.Location = new Point(12, 92);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(465, 319);
            dgvdata.TabIndex = 208;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.Resizable = DataGridViewTriState.False;
            btnseleccionar.Width = 35;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Resizable = DataGridViewTriState.False;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Visible = false;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Resizable = DataGridViewTriState.False;
            NumeroDocumento.SortMode = DataGridViewColumnSortMode.NotSortable;
            NumeroDocumento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Resizable = DataGridViewTriState.False;
            NombreCompleto.SortMode = DataGridViewColumnSortMode.NotSortable;
            NombreCompleto.Width = 230;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 50);
            panel1.TabIndex = 207;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 143, 213);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(408, 8);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(69, 31);
            iconButton1.TabIndex = 213;
            iconButton1.Text = "Salir";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(12, 12);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(85, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Clientes";
            // 
            // mdClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(486, 419);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnborrar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(dgvdata);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "mdClientes";
            Text = ".: Clientes :.";
            Load += mdClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbuscar;
        private ComboBox cbobuscar;
        private DataGridView dgvdata;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Usuarios;
    }
}