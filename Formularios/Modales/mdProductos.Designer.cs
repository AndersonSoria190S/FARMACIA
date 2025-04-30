namespace FARMACIA.Formularios.Modales
{
    partial class mdProductos
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            dgvdata = new DataGridView();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            btnborrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 43);
            panel1.TabIndex = 17;
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
            Usuarios.Location = new Point(15, 9);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(104, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Productos";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Codigo, Producto, Categoria, Medida, PrecioCompra, PrecioVenta, Stock });
            dgvdata.Location = new Point(12, 85);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(457, 319);
            dgvdata.TabIndex = 195;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(103, 49);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(145, 23);
            cbobuscar.TabIndex = 196;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(254, 49);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(135, 23);
            txtbuscar.TabIndex = 197;
            // 
            // btnborrar
            // 
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 18;
            btnborrar.Location = new Point(432, 49);
            btnborrar.Margin = new Padding(1);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new Padding(0, 3, 0, 0);
            btnborrar.Size = new Size(37, 23);
            btnborrar.TabIndex = 199;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(393, 49);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 198;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 200;
            label1.Text = "Buscar por: ";
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
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Resizable = DataGridViewTriState.False;
            Codigo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Resizable = DataGridViewTriState.False;
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            Producto.Width = 220;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Resizable = DataGridViewTriState.False;
            Categoria.SortMode = DataGridViewColumnSortMode.NotSortable;
            Categoria.Visible = false;
            Categoria.Width = 140;
            // 
            // Medida
            // 
            Medida.HeaderText = "Medida";
            Medida.Name = "Medida";
            Medida.Resizable = DataGridViewTriState.False;
            Medida.SortMode = DataGridViewColumnSortMode.NotSortable;
            Medida.Visible = false;
            Medida.Width = 130;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Resizable = DataGridViewTriState.False;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            PrecioCompra.Visible = false;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Resizable = DataGridViewTriState.False;
            PrecioVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            PrecioVenta.Visible = false;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Resizable = DataGridViewTriState.False;
            Stock.SortMode = DataGridViewColumnSortMode.NotSortable;
            Stock.Visible = false;
            // 
            // mdProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(486, 416);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnborrar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(cbobuscar);
            Controls.Add(dgvdata);
            Controls.Add(panel1);
            Name = "mdProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Productos :.";
            Load += mdProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Usuarios;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Label label1;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Medida;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
    }
}