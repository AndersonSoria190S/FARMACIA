namespace FARMACIA.Formularios.Venta
{
    partial class frmListaVentas
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
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label2 = new Label();
            txtfechafin = new DateTimePicker();
            txtfechainicio = new DateTimePicker();
            groupBox1 = new GroupBox();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            PagoCon = new DataGridViewTextBoxColumn();
            Cambio = new DataGridViewTextBoxColumn();
            CodigoProd = new DataGridViewTextBoxColumn();
            DescripcionProducto = new DataGridViewTextBoxColumn();
            CategoriaProd = new DataGridViewTextBoxColumn();
            MedidaProducto = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnexportar = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cbobuscar = new ComboBox();
            txtbuscar = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnbuscarproveedor.Location = new Point(423, 59);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(113, 26);
            btnbuscarproveedor.TabIndex = 222;
            btnbuscarproveedor.Text = "Buscar";
            btnbuscarproveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproveedor.UseVisualStyleBackColor = true;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(221, 67);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 221;
            label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 220;
            label2.Text = "Fecha Inicio:";
            // 
            // txtfechafin
            // 
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(297, 62);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(108, 23);
            txtfechafin.TabIndex = 219;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(97, 62);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(97, 23);
            txtfechainicio.TabIndex = 218;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 14);
            groupBox1.TabIndex = 217;
            groupBox1.TabStop = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, NroDocumento, UsuarioRegistro, Cliente, MontoTotal, PagoCon, Cambio, CodigoProd, DescripcionProducto, CategoriaProd, MedidaProducto, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(13, 151);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1079, 436);
            dgvdata.TabIndex = 216;
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
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.Resizable = DataGridViewTriState.False;
            Cliente.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cliente.Width = 140;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.Name = "MontoTotal";
            // 
            // PagoCon
            // 
            PagoCon.HeaderText = "Pago Con";
            PagoCon.Name = "PagoCon";
            // 
            // Cambio
            // 
            Cambio.HeaderText = "Cambio";
            Cambio.Name = "Cambio";
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
            btnexportar.Location = new Point(13, 119);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(127, 23);
            btnexportar.TabIndex = 215;
            btnexportar.Text = "Descargar Excel";
            btnexportar.TextAlign = ContentAlignment.MiddleRight;
            btnexportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.ControlLight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 18;
            iconButton2.Location = new Point(1055, 122);
            iconButton2.Margin = new Padding(1);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(0, 3, 0, 0);
            iconButton2.Size = new Size(37, 23);
            iconButton2.TabIndex = 214;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(677, 124);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 213;
            label1.Text = "Buscar Por: ";
            // 
            // cbobuscar
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(756, 122);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new Size(121, 23);
            cbobuscar.TabIndex = 212;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(883, 122);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(129, 23);
            txtbuscar.TabIndex = 211;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.WhiteSmoke;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(1016, 122);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(37, 23);
            btnbuscar.TabIndex = 210;
            btnbuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 56);
            panel1.TabIndex = 209;
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
            iconButton1.Location = new Point(1026, 11);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(69, 31);
            iconButton1.TabIndex = 213;
            iconButton1.Text = "Salir";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(15, 18);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(171, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "LIsta de Compras";
            // 
            // frmListaVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1104, 590);
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
            Name = "frmListaVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListaVentas";
            Load += frmListaVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private Label label3;
        private Label label2;
        private DateTimePicker txtfechafin;
        private DateTimePicker txtfechainicio;
        private GroupBox groupBox1;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private ComboBox cbobuscar;
        private TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Usuarios;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn PagoCon;
        private DataGridViewTextBoxColumn Cambio;
        private DataGridViewTextBoxColumn CodigoProd;
        private DataGridViewTextBoxColumn DescripcionProducto;
        private DataGridViewTextBoxColumn CategoriaProd;
        private DataGridViewTextBoxColumn MedidaProducto;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}