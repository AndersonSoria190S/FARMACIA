namespace FARMACIA.Formularios.Venta
{
    partial class frmNuevaVenta
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
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            txtprecioventa = new TextBox();
            label9 = new Label();
            txtstock = new TextBox();
            label8 = new Label();
            txtproducto = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            txtcantidad = new NumericUpDown();
            txtcodproducto = new TextBox();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            txttotalpagar = new TextBox();
            label11 = new Label();
            btnCancelarVenta = new FontAwesome.Sharp.IconButton();
            btnCrearVenta = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            txtpagocon = new TextBox();
            label13 = new Label();
            txtcambio = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            groupBox3.SuspendLayout();
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
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 100);
            panel1.TabIndex = 18;
            // 
            // txtfecharegistro
            // 
            txtfecharegistro.Location = new Point(545, 63);
            txtfecharegistro.Name = "txtfecharegistro";
            txtfecharegistro.ReadOnly = true;
            txtfecharegistro.Size = new Size(138, 23);
            txtfecharegistro.TabIndex = 36;
            txtfecharegistro.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(431, 68);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 35;
            label2.Text = "Fecha Registro:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Cursor = Cursors.IBeam;
            txtnumerodocumento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtnumerodocumento.Location = new Point(243, 65);
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
            label1.Location = new Point(115, 65);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 8;
            label1.Text = "Numero Documento:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(0, 143, 213);
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 70;
            iconPictureBox1.Location = new Point(14, 16);
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
            Usuarios.Location = new Point(286, 16);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(182, 31);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Nueva Venta";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnagregarproducto);
            groupBox1.Controls.Add(btnbuscarproducto);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtprecioventa);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtstock);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtproducto);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnbuscarcliente);
            groupBox1.Controls.Add(txtcantidad);
            groupBox1.Controls.Add(txtcodproducto);
            groupBox1.Controls.Add(txtnombrecliente);
            groupBox1.Controls.Add(txtdoccliente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 180);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnagregarproducto.IconColor = Color.Black;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnagregarproducto.IconSize = 17;
            btnagregarproducto.ImageAlign = ContentAlignment.TopCenter;
            btnagregarproducto.Location = new Point(393, 147);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(79, 23);
            btnagregarproducto.TabIndex = 219;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextAlign = ContentAlignment.MiddleRight;
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 17;
            btnbuscarproducto.ImageAlign = ContentAlignment.MiddleRight;
            btnbuscarproducto.Location = new Point(393, 101);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(79, 23);
            btnbuscarproducto.TabIndex = 218;
            btnbuscarproducto.Text = "Buscar";
            btnbuscarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarproducto.UseVisualStyleBackColor = true;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(272, 129);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 217;
            label10.Text = "Precio Venta:";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(272, 147);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(106, 23);
            txtprecioventa.TabIndex = 216;
            txtprecioventa.KeyPress += txtprecioventa_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 129);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 215;
            label9.Text = "Stock:";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(181, 147);
            txtstock.Name = "txtstock";
            txtstock.ReadOnly = true;
            txtstock.Size = new Size(69, 23);
            txtstock.TabIndex = 214;
            txtstock.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 83);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 213;
            label8.Text = "Producto:";
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(181, 101);
            txtproducto.Name = "txtproducto";
            txtproducto.ReadOnly = true;
            txtproducto.Size = new Size(197, 23);
            txtproducto.TabIndex = 212;
            txtproducto.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(17, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 14);
            groupBox2.TabIndex = 211;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(405, 37);
            label7.Name = "label7";
            label7.Size = new Size(270, 15);
            label7.TabIndex = 210;
            label7.Text = "*Ingrese los datos directamente o puede buscarlo.";
            // 
            // btnbuscarcliente
            // 
            btnbuscarcliente.Cursor = Cursors.Hand;
            btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarcliente.IconColor = Color.Black;
            btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarcliente.IconSize = 17;
            btnbuscarcliente.ImageAlign = ContentAlignment.MiddleRight;
            btnbuscarcliente.Location = new Point(320, 35);
            btnbuscarcliente.Name = "btnbuscarcliente";
            btnbuscarcliente.Size = new Size(79, 25);
            btnbuscarcliente.TabIndex = 209;
            btnbuscarcliente.Text = "Buscar";
            btnbuscarcliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarcliente.UseVisualStyleBackColor = true;
            btnbuscarcliente.Click += btnbuscarcliente_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(17, 147);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(133, 23);
            txtcantidad.TabIndex = 208;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(17, 101);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(133, 23);
            txtcodproducto.TabIndex = 207;
            txtcodproducto.KeyDown += txtcodproducto_KeyDown;
            txtcodproducto.KeyPress += txtcodproducto_KeyPress;
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(156, 37);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.Size = new Size(158, 23);
            txtnombrecliente.TabIndex = 206;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(17, 37);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.Size = new Size(133, 23);
            txtdoccliente.TabIndex = 205;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 83);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 204;
            label6.Text = "Codigo Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 129);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 203;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 19);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 202;
            label4.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 19);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 201;
            label3.Text = "Doc. Cliente:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvdata);
            groupBox3.Location = new Point(12, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(690, 210);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Producto, Categoria, Medida, Cantidad, Precio, SubTotal, btneliminar });
            dgvdata.Location = new Point(6, 16);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(678, 188);
            dgvdata.TabIndex = 197;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Resizable = DataGridViewTriState.False;
            Precio.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // txttotalpagar
            // 
            txttotalpagar.Location = new Point(300, 516);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.ReadOnly = true;
            txttotalpagar.Size = new Size(90, 23);
            txttotalpagar.TabIndex = 210;
            txttotalpagar.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(400, 519);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 211;
            label11.Text = "Pagar con: ";
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Cursor = Cursors.Hand;
            btnCancelarVenta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarVenta.IconChar = FontAwesome.Sharp.IconChar.Times;
            btnCancelarVenta.IconColor = Color.Red;
            btnCancelarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarVenta.IconSize = 19;
            btnCancelarVenta.Location = new Point(121, 516);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(68, 23);
            btnCancelarVenta.TabIndex = 213;
            btnCancelarVenta.Text = "Salir";
            btnCancelarVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.Cursor = Cursors.Hand;
            btnCrearVenta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnCrearVenta.IconColor = Color.SteelBlue;
            btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCrearVenta.IconSize = 19;
            btnCrearVenta.Location = new Point(18, 516);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(97, 23);
            btnCrearVenta.TabIndex = 212;
            btnCrearVenta.Text = "Crear Venta";
            btnCrearVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearVenta.UseVisualStyleBackColor = true;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlLightLight;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(207, 520);
            label12.Name = "label12";
            label12.Size = new Size(88, 13);
            label12.TabIndex = 214;
            label12.Text = "Total a Pagar:";
            // 
            // txtpagocon
            // 
            txtpagocon.Location = new Point(472, 516);
            txtpagocon.Name = "txtpagocon";
            txtpagocon.Size = new Size(78, 23);
            txtpagocon.TabIndex = 220;
            txtpagocon.KeyDown += txtpagocon_KeyDown;
            txtpagocon.KeyPress += txtpagocon_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(556, 519);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 221;
            label13.Text = "Cambio:";
            // 
            // txtcambio
            // 
            txtcambio.Location = new Point(612, 516);
            txtcambio.Name = "txtcambio";
            txtcambio.ReadOnly = true;
            txtcambio.Size = new Size(84, 23);
            txtcambio.TabIndex = 222;
            txtcambio.TextAlign = HorizontalAlignment.Center;
            // 
            // frmNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(710, 551);
            ControlBox = false;
            Controls.Add(txtcambio);
            Controls.Add(label13);
            Controls.Add(txtpagocon);
            Controls.Add(label12);
            Controls.Add(txttotalpagar);
            Controls.Add(label11);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnCrearVenta);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmNuevaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " .: Nueva Venta :.";
            Load += frmNuevaVenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtfecharegistro;
        private Label label2;
        private TextBox txtnumerodocumento;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label Usuarios;
        private GroupBox groupBox1;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private NumericUpDown txtcantidad;
        private TextBox txtcodproducto;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private Label label10;
        private TextBox txtprecioventa;
        private Label label9;
        private TextBox txtstock;
        private Label label8;
        private TextBox txtproducto;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private GroupBox groupBox3;
        private DataGridView dgvdata;
        private TextBox txttotalpagar;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnCancelarVenta;
        private FontAwesome.Sharp.IconButton btnCrearVenta;
        private Label label12;
        private TextBox txtpagocon;
        private Label label13;
        private TextBox txtcambio;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Medida;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
    }
}