namespace FARMACIA.Formularios.Compras
{
    partial class frmNuevaCompra
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
            txtfecharegistro = new TextBox();
            label2 = new Label();
            txtnumerodocumento = new TextBox();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            Usuarios = new Label();
            groupBox1 = new GroupBox();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            txtpreciocompra = new TextBox();
            txtproducto = new TextBox();
            txtnombreproveedor = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            txtcantidad = new NumericUpDown();
            txtprecioventa = new TextBox();
            txtcodproducto = new TextBox();
            txtdocproveedor = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            btnCrearCompra = new FontAwesome.Sharp.IconButton();
            btnCancelarCompra = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            txttotalpagar = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(txtfecharegistro);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtnumerodocumento);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 94);
            panel1.TabIndex = 17;
            // 
            // txtfecharegistro
            // 
            txtfecharegistro.Location = new Point(506, 55);
            txtfecharegistro.Name = "txtfecharegistro";
            txtfecharegistro.ReadOnly = true;
            txtfecharegistro.Size = new Size(138, 21);
            txtfecharegistro.TabIndex = 36;
            txtfecharegistro.TextAlign = HorizontalAlignment.Center;
            txtfecharegistro.TextChanged += txtfecharegistro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(393, 61);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 35;
            label2.Text = "Fecha Registro:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Cursor = Cursors.IBeam;
            txtnumerodocumento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtnumerodocumento.Location = new Point(243, 55);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.ReadOnly = true;
            txtnumerodocumento.Size = new Size(119, 21);
            txtnumerodocumento.TabIndex = 34;
            txtnumerodocumento.Text = "Autogenerado";
            txtnumerodocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(115, 58);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 8;
            label1.Text = "Numero Documento:";
            label1.Click += label1_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(0, 143, 213);
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 70;
            iconPictureBox1.Location = new Point(24, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(85, 70);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(223, 12);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(223, 31);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Nuevo Producto";
            Usuarios.Click += Usuarios_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnagregarproducto);
            groupBox1.Controls.Add(txtpreciocompra);
            groupBox1.Controls.Add(txtproducto);
            groupBox1.Controls.Add(txtnombreproveedor);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnbuscarproducto);
            groupBox1.Controls.Add(btnbuscarproveedor);
            groupBox1.Controls.Add(txtcantidad);
            groupBox1.Controls.Add(txtprecioventa);
            groupBox1.Controls.Add(txtcodproducto);
            groupBox1.Controls.Add(txtdocproveedor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 145);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnagregarproducto.IconColor = Color.Black;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnagregarproducto.IconSize = 17;
            btnagregarproducto.ImageAlign = ContentAlignment.TopCenter;
            btnagregarproducto.Location = new Point(457, 109);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(167, 21);
            btnagregarproducto.TabIndex = 207;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextAlign = ContentAlignment.MiddleRight;
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(457, 82);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(167, 21);
            txtpreciocompra.TabIndex = 206;
            txtpreciocompra.KeyPress += txtpreciocompra_KeyPress;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(457, 54);
            txtproducto.Name = "txtproducto";
            txtproducto.ReadOnly = true;
            txtproducto.Size = new Size(167, 21);
            txtproducto.TabIndex = 205;
            txtproducto.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(457, 27);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.ReadOnly = true;
            txtnombreproveedor.Size = new Size(167, 21);
            txtnombreproveedor.TabIndex = 204;
            txtnombreproveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(337, 82);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 203;
            label9.Text = "Precio Compra:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 54);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 202;
            label8.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 24);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 201;
            label7.Text = "Nombre Proveedor:";
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 17;
            btnbuscarproducto.ImageAlign = ContentAlignment.MiddleRight;
            btnbuscarproducto.Location = new Point(243, 53);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(79, 21);
            btnbuscarproducto.TabIndex = 200;
            btnbuscarproducto.Text = "Buscar";
            btnbuscarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproducto.UseVisualStyleBackColor = true;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.Cursor = Cursors.Hand;
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 17;
            btnbuscarproveedor.ImageAlign = ContentAlignment.MiddleRight;
            btnbuscarproveedor.Location = new Point(243, 21);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(79, 21);
            btnbuscarproveedor.TabIndex = 199;
            btnbuscarproveedor.Text = "Buscar";
            btnbuscarproveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproveedor.UseVisualStyleBackColor = true;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(104, 82);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(133, 21);
            txtcantidad.TabIndex = 8;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(104, 108);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(133, 21);
            txtprecioventa.TabIndex = 7;
            txtprecioventa.TextChanged += txtprecioventa_TextChanged;
            txtprecioventa.KeyPress += txtprecioventa_KeyPress;
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(104, 53);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(133, 21);
            txtcodproducto.TabIndex = 5;
            txtcodproducto.TextChanged += txtcodproducto_TextChanged;
            txtcodproducto.KeyDown += txtcodproducto_KeyDown;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(104, 24);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(133, 21);
            txtdocproveedor.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 111);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 3;
            label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 82);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 2;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 54);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 1;
            label4.Text = "Cod. Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 27);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "Doc. Proveedor:";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Producto, Categoria, Medida, Cantidad, PrecioVenta, PrecioCompra, SubTotal, btneliminar });
            dgvdata.Location = new Point(12, 251);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(630, 229);
            dgvdata.TabIndex = 196;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
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
            Codigo.SortMode = DataGridViewColumnSortMode.NotSortable;
            Codigo.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Resizable = DataGridViewTriState.False;
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            Producto.Width = 260;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Resizable = DataGridViewTriState.False;
            Categoria.Visible = false;
            // 
            // Medida
            // 
            Medida.HeaderText = "Medida";
            Medida.Name = "Medida";
            Medida.Visible = false;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Resizable = DataGridViewTriState.False;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cantidad.Width = 70;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Resizable = DataGridViewTriState.False;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.Resizable = DataGridViewTriState.False;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            SubTotal.Width = 80;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.Width = 35;
            // 
            // btnCrearCompra
            // 
            btnCrearCompra.Cursor = Cursors.Hand;
            btnCrearCompra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnCrearCompra.IconColor = Color.LimeGreen;
            btnCrearCompra.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCrearCompra.IconSize = 17;
            btnCrearCompra.Location = new Point(12, 486);
            btnCrearCompra.Name = "btnCrearCompra";
            btnCrearCompra.Size = new Size(118, 21);
            btnCrearCompra.TabIndex = 208;
            btnCrearCompra.Text = "Crear Compra";
            btnCrearCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearCompra.UseVisualStyleBackColor = true;
            btnCrearCompra.Click += btnCrearCompra_Click;
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.Cursor = Cursors.Hand;
            btnCancelarCompra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarCompra.IconChar = FontAwesome.Sharp.IconChar.Times;
            btnCancelarCompra.IconColor = Color.Red;
            btnCancelarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarCompra.IconSize = 17;
            btnCancelarCompra.Location = new Point(136, 486);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(85, 21);
            btnCancelarCompra.TabIndex = 209;
            btnCancelarCompra.Text = "Salir";
            btnCancelarCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarCompra.UseVisualStyleBackColor = true;
            btnCancelarCompra.Click += btnCancelarCompra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(422, 489);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 208;
            label10.Text = "Pagar a Total: ";
            // 
            // txttotalpagar
            // 
            txttotalpagar.Location = new Point(524, 486);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.ReadOnly = true;
            txttotalpagar.Size = new Size(118, 21);
            txttotalpagar.TabIndex = 208;
            txttotalpagar.TextAlign = HorizontalAlignment.Center;
            // 
            // frmNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(654, 519);
            ControlBox = false;
            Controls.Add(txttotalpagar);
            Controls.Add(label10);
            Controls.Add(btnCancelarCompra);
            Controls.Add(btnCrearCompra);
            Controls.Add(dgvdata);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmNuevaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Nueva Compra :.";
            Load += frmNuevaCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label Usuarios;
        private Label label1;
        private TextBox txtnumerodocumento;
        private TextBox txtfecharegistro;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private NumericUpDown txtcantidad;
        private TextBox txtprecioventa;
        private TextBox txtcodproducto;
        private TextBox txtdocproveedor;
        private Label label6;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private TextBox txtpreciocompra;
        private TextBox txtproducto;
        private TextBox txtnombreproveedor;
        private Label label9;
        private Label label8;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Medida;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private FontAwesome.Sharp.IconButton btnCrearCompra;
        private FontAwesome.Sharp.IconButton btnCancelarCompra;
        private Label label10;
        private TextBox txttotalpagar;
    }
}