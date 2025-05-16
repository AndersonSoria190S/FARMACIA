namespace FARMACIA.Formularios.Compras
{
    partial class frmBuscarCompra
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
            label1 = new Label();
            txtbusqueda = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnborrar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            lblEstado = new Label();
            groupBox1 = new GroupBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btndescargar = new FontAwesome.Sharp.IconButton();
            lbltotal = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            txtfecharegistro = new TextBox();
            txtnumerodocumento = new TextBox();
            txtusuarioregistro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 52);
            panel1.TabIndex = 19;
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
            iconButton1.Location = new Point(607, 11);
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
            Usuarios.Location = new Point(14, 18);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(153, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Buscar Compra";
            Usuarios.Click += Usuarios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 205;
            label1.Text = "Numero Documento: ";
            // 
            // txtbusqueda
            // 
            txtbusqueda.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbusqueda.Location = new Point(141, 62);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(150, 21);
            txtbusqueda.TabIndex = 202;
            txtbusqueda.TextChanged += txtbusqueda_TextChanged;
            txtbusqueda.KeyDown += txtbusqueda_KeyDown;
            // 
            // btnbuscar
            // 
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 17;
            btnbuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnbuscar.Location = new Point(297, 62);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(99, 23);
            btnbuscar.TabIndex = 206;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnborrar
            // 
            btnborrar.Cursor = Cursors.Hand;
            btnborrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 17;
            btnborrar.ImageAlign = ContentAlignment.MiddleRight;
            btnborrar.Location = new Point(402, 62);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(103, 23);
            btnborrar.TabIndex = 207;
            btnborrar.Text = "Limpiar";
            btnborrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(523, 65);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 208;
            label2.Text = "Estado: ";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(580, 65);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 209;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(btndescargar);
            groupBox1.Controls.Add(lbltotal);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 450);
            groupBox1.TabIndex = 210;
            groupBox1.TabStop = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.Control;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            iconButton2.IconColor = Color.Crimson;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.BottomCenter;
            iconButton2.Location = new Point(375, 413);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(147, 31);
            iconButton2.TabIndex = 148;
            iconButton2.Text = "Cancelar Compra";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // btndescargar
            // 
            btndescargar.BackColor = SystemColors.Control;
            btndescargar.Cursor = Cursors.Hand;
            btndescargar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btndescargar.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btndescargar.IconColor = Color.Crimson;
            btndescargar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btndescargar.IconSize = 17;
            btndescargar.ImageAlign = ContentAlignment.BottomCenter;
            btndescargar.Location = new Point(528, 412);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(128, 31);
            btndescargar.TabIndex = 147;
            btndescargar.Text = "Descargar PDF";
            btndescargar.TextAlign = ContentAlignment.MiddleRight;
            btndescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndescargar.UseVisualStyleBackColor = true;
            btndescargar.Click += btndescargar_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = SystemColors.ControlLightLight;
            lbltotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.Location = new Point(65, 420);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(35, 16);
            lbltotal.TabIndex = 22;
            lbltotal.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlLightLight;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 420);
            label9.Name = "label9";
            label9.Size = new Size(47, 16);
            label9.TabIndex = 21;
            label9.Text = "Total:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvdata);
            groupBox3.Location = new Point(6, 180);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(650, 226);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, PrecioCompra, SubTotal });
            dgvdata.Location = new Point(6, 22);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(638, 194);
            dgvdata.TabIndex = 197;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            Producto.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Resizable = DataGridViewTriState.False;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cantidad.Width = 80;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Resizable = DataGridViewTriState.False;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            PrecioCompra.Width = 120;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.Resizable = DataGridViewTriState.False;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            SubTotal.Width = 95;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(6, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(650, 68);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombreproveedor.Location = new Point(458, 25);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.ReadOnly = true;
            txtnombreproveedor.Size = new Size(177, 21);
            txtnombreproveedor.TabIndex = 205;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtdocproveedor.Location = new Point(123, 25);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.ReadOnly = true;
            txtdocproveedor.Size = new Size(150, 21);
            txtdocproveedor.TabIndex = 204;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(338, 28);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 2;
            label8.Text = "Nombre Proveedor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 28);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 1;
            label7.Text = "Doc. Proveedor:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 143, 213);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtfecharegistro);
            panel2.Controls.Add(txtnumerodocumento);
            panel2.Controls.Add(txtusuarioregistro);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(6, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 94);
            panel2.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(377, 15);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 206;
            label6.Text = "Numero Documento:";
            // 
            // txtfecharegistro
            // 
            txtfecharegistro.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtfecharegistro.Location = new Point(505, 58);
            txtfecharegistro.Name = "txtfecharegistro";
            txtfecharegistro.ReadOnly = true;
            txtfecharegistro.Size = new Size(130, 21);
            txtfecharegistro.TabIndex = 205;
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtnumerodocumento.Location = new Point(505, 12);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.ReadOnly = true;
            txtnumerodocumento.Size = new Size(130, 21);
            txtnumerodocumento.TabIndex = 204;
            // 
            // txtusuarioregistro
            // 
            txtusuarioregistro.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuarioregistro.Location = new Point(223, 55);
            txtusuarioregistro.Name = "txtusuarioregistro";
            txtusuarioregistro.ReadOnly = true;
            txtusuarioregistro.Size = new Size(130, 21);
            txtusuarioregistro.TabIndex = 203;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(377, 61);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 35;
            label3.Text = "Fecha Registro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(115, 58);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 8;
            label4.Text = "Usuario Registro:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 143, 213);
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(115, 12);
            label5.Name = "label5";
            label5.Size = new Size(216, 31);
            label5.TabIndex = 6;
            label5.Text = "Detalle Compra";
            // 
            // frmBuscarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(686, 546);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(lblEstado);
            Controls.Add(label2);
            Controls.Add(btnborrar);
            Controls.Add(btnbuscar);
            Controls.Add(label1);
            Controls.Add(txtbusqueda);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmBuscarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Buscar Compra :.";
            Load += frmBuscarCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Usuarios;
        private Label label1;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnborrar;
        private Label label2;
        private Label lblEstado;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtfecharegistro;
        private TextBox txtnumerodocumento;
        private TextBox txtusuarioregistro;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label8;
        private DataGridView dgvdata;
        private Label lbltotal;
        private Label label9;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btndescargar;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}