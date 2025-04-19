namespace FARMACIA.Formularios.Productos
{
    partial class frmProductos
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
            btnnuevoproducto = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnexportar = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            btneditar = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 41);
            panel1.TabIndex = 0;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(0, 143, 213);
            btnsalir.ForeColor = SystemColors.ControlLightLight;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 24;
            btnsalir.Location = new Point(1000, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(69, 31);
            btnsalir.TabIndex = 211;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(15, 9);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(104, 24);
            Usuarios.TabIndex = 3;
            Usuarios.Text = "Productos";
            // 
            // btnnuevoproducto
            // 
            btnnuevoproducto.Cursor = Cursors.Hand;
            btnnuevoproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnnuevoproducto.IconColor = Color.Black;
            btnnuevoproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevoproducto.IconSize = 17;
            btnnuevoproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevoproducto.Location = new Point(12, 58);
            btnnuevoproducto.Name = "btnnuevoproducto";
            btnnuevoproducto.Size = new Size(127, 28);
            btnnuevoproducto.TabIndex = 3;
            btnnuevoproducto.Text = "Nuevo producto";
            btnnuevoproducto.TextAlign = ContentAlignment.MiddleRight;
            btnnuevoproducto.UseVisualStyleBackColor = true;
            btnnuevoproducto.Click += btnnuevoproducto_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1054, 17);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.Location = new Point(1029, 124);
            iconButton1.Margin = new Padding(1);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(0, 3, 0, 0);
            iconButton1.Size = new Size(37, 23);
            iconButton1.TabIndex = 15;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 14;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(622, 127);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 13;
            label1.Text = "Buscar Por: ";
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(707, 124);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(121, 23);
            cbobuscar.TabIndex = 12;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(837, 124);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 23);
            txtbuscar.TabIndex = 11;
            // 
            // btnbuscar
            // 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(979, 124);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 10;
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnexportar
            // 
            btnexportar.Cursor = Cursors.Hand;
            btnexportar.FlatStyle = FlatStyle.Popup;
            btnexportar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexportar.IconColor = Color.LimeGreen;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnexportar.IconSize = 17;
            btnexportar.ImageAlign = ContentAlignment.TopCenter;
            btnexportar.Location = new Point(12, 157);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(127, 27);
            btnexportar.TabIndex = 193;
            btnexportar.Text = "Descargar Excel";
            btnexportar.TextAlign = ContentAlignment.MiddleRight;
            btnexportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // dgvdata
            // 
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Producto, Categoria, Medida, PrecioCompra, PrecioVenta, Stock, btneditar, btneliminar });
            dgvdata.Location = new Point(12, 199);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1049, 352);
            dgvdata.TabIndex = 194;
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
            Categoria.Width = 140;
            // 
            // Medida
            // 
            Medida.HeaderText = "Medida";
            Medida.Name = "Medida";
            Medida.Resizable = DataGridViewTriState.False;
            Medida.SortMode = DataGridViewColumnSortMode.NotSortable;
            Medida.Width = 130;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Resizable = DataGridViewTriState.False;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Resizable = DataGridViewTriState.False;
            PrecioVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Resizable = DataGridViewTriState.False;
            Stock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btneditar
            // 
            btneditar.HeaderText = "";
            btneditar.Name = "btneditar";
            btneditar.SortMode = DataGridViewColumnSortMode.NotSortable;
            btneditar.Width = 35;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.Resizable = DataGridViewTriState.False;
            btneliminar.SortMode = DataGridViewColumnSortMode.NotSortable;
            btneliminar.Width = 35;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 563);
            Controls.Add(dgvdata);
            Controls.Add(btnexportar);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(groupBox1);
            Controls.Add(btnnuevoproducto);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Producots :.";
            Load += frmProductos_Load;
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
        private FontAwesome.Sharp.IconButton btnnuevoproducto;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Label label1;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnexportar;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Medida;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn btneditar;
        private DataGridViewTextBoxColumn btneliminar;
    }
}