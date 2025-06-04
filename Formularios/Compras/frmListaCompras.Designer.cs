namespace FARMACIA.Formularios.Compras
{
    partial class frmListaCompras
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
            btnexportar = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            txtfechainicio = new DateTimePicker();
            txtfechafin = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            FechaRegistro = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            CodigoProd = new DataGridViewTextBoxColumn();
            DescripcionProducto = new DataGridViewTextBoxColumn();
            CategoriaProd = new DataGridViewTextBoxColumn();
            MedidaProducto = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
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
            panel1.Size = new Size(1086, 52);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 143, 213);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(1002, 11);
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
            Usuarios.Location = new Point(15, 13);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(171, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "LIsta de Compras";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, NroDocumento, UsuarioRegistro, Proveedor, MontoTotal, CodigoProd, DescripcionProducto, CategoriaProd, MedidaProducto, PrecioVenta, PrecioCompra, Cantidad, SubTotal, FechaVencimiento });
            dgvdata.Location = new Point(12, 194);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1056, 352);
            dgvdata.TabIndex = 202;
            // 
            // btnexportar
            // 
            btnexportar.BackColor = SystemColors.Control;
            btnexportar.Cursor = Cursors.Hand;
            btnexportar.FlatStyle = FlatStyle.Popup;
            btnexportar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexportar.IconColor = Color.ForestGreen;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnexportar.IconSize = 17;
            btnexportar.ImageAlign = ContentAlignment.TopCenter;
            btnexportar.Location = new Point(12, 149);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(127, 23);
            btnexportar.TabIndex = 201;
            btnexportar.Text = "Descargar Excel";
            btnexportar.TextAlign = ContentAlignment.MiddleRight;
            btnexportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 18;
            iconButton2.Location = new Point(1031, 148);
            iconButton2.Margin = new Padding(1);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(0, 3, 0, 0);
            iconButton2.Size = new Size(37, 23);
            iconButton2.TabIndex = 200;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(657, 152);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 198;
            label1.Text = "Buscar Por: ";
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(732, 148);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(121, 23);
            cbobuscar.TabIndex = 197;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(859, 148);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 23);
            txtbuscar.TabIndex = 196;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.WhiteSmoke;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(992, 148);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 195;
            btnbuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 14);
            groupBox1.TabIndex = 203;
            groupBox1.TabStop = false;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(96, 70);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(97, 23);
            txtfechainicio.TabIndex = 204;
            // 
            // txtfechafin
            // 
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(296, 70);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(108, 23);
            txtfechafin.TabIndex = 205;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 206;
            label2.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 75);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 207;
            label3.Text = "Fecha Fin";
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.Cursor = Cursors.Hand;
            btnbuscarproveedor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 17;
            btnbuscarproveedor.ImageAlign = ContentAlignment.MiddleRight;
            btnbuscarproveedor.Location = new Point(422, 67);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(113, 26);
            btnbuscarproveedor.TabIndex = 208;
            btnbuscarproveedor.Text = "Buscar";
            btnbuscarproveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproveedor.UseVisualStyleBackColor = true;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Resizable = DataGridViewTriState.False;
            FechaRegistro.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro de Documento";
            NroDocumento.Name = "NroDocumento";
            NroDocumento.Resizable = DataGridViewTriState.False;
            NroDocumento.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.Resizable = DataGridViewTriState.False;
            UsuarioRegistro.SortMode = DataGridViewColumnSortMode.NotSortable;
            UsuarioRegistro.Width = 220;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            Proveedor.Resizable = DataGridViewTriState.False;
            Proveedor.SortMode = DataGridViewColumnSortMode.NotSortable;
            Proveedor.Width = 140;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.Name = "MontoTotal";
            // 
            // CodigoProd
            // 
            CodigoProd.HeaderText = "Codigo Producto";
            CodigoProd.Name = "CodigoProd";
            CodigoProd.Resizable = DataGridViewTriState.False;
            CodigoProd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.HeaderText = "Descripcion Producto";
            DescripcionProducto.Name = "DescripcionProducto";
            DescripcionProducto.Resizable = DataGridViewTriState.False;
            DescripcionProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            DescripcionProducto.Width = 130;
            // 
            // CategoriaProd
            // 
            CategoriaProd.HeaderText = "Categoria Producto";
            CategoriaProd.Name = "CategoriaProd";
            CategoriaProd.Resizable = DataGridViewTriState.False;
            CategoriaProd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MedidaProducto
            // 
            MedidaProducto.HeaderText = "Medida Producto";
            MedidaProducto.Name = "MedidaProducto";
            MedidaProducto.Resizable = DataGridViewTriState.False;
            MedidaProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precia Compra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "Fecha Vencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            // 
            // frmListaCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1080, 558);
            ControlBox = false;
            Controls.Add(btnbuscarproveedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtfechafin);
            Controls.Add(txtfechainicio);
            Controls.Add(groupBox1);
            Controls.Add(dgvdata);
            Controls.Add(btnexportar);
            Controls.Add(iconButton2);
            Controls.Add(label1);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmListaCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Lista de Compras :.";
            Load += frmListaCompras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Usuarios;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private GroupBox groupBox1;
        private DateTimePicker txtfechainicio;
        private DateTimePicker txtfechafin;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn CodigoProd;
        private DataGridViewTextBoxColumn DescripcionProducto;
        private DataGridViewTextBoxColumn CategoriaProd;
        private DataGridViewTextBoxColumn MedidaProducto;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn FechaVencimiento;
    }
}