namespace FARMACIA.Formularios.Venta
{
    partial class frmBuscarVenta
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
            groupBox1 = new GroupBox();
            lblcambio = new Label();
            lblpagocon = new Label();
            label13 = new Label();
            label11 = new Label();
            btncancelarventa = new FontAwesome.Sharp.IconButton();
            btndescargarpdf = new FontAwesome.Sharp.IconButton();
            lbltotal = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
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
            lblEstado = new Label();
            label2 = new Label();
            btnborrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtbusqueda = new TextBox();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblcambio);
            groupBox1.Controls.Add(lblpagocon);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btncancelarventa);
            groupBox1.Controls.Add(btndescargarpdf);
            groupBox1.Controls.Add(lbltotal);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(11, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 450);
            groupBox1.TabIndex = 218;
            groupBox1.TabStop = false;
            // 
            // lblcambio
            // 
            lblcambio.AutoSize = true;
            lblcambio.BackColor = SystemColors.ControlLightLight;
            lblcambio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblcambio.Location = new Point(302, 421);
            lblcambio.Name = "lblcambio";
            lblcambio.Size = new Size(35, 16);
            lblcambio.TabIndex = 224;
            lblcambio.Text = "0.00";
            // 
            // lblpagocon
            // 
            lblpagocon.AutoSize = true;
            lblpagocon.BackColor = SystemColors.ControlLightLight;
            lblpagocon.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblpagocon.Location = new Point(186, 421);
            lblpagocon.Name = "lblpagocon";
            lblpagocon.Size = new Size(35, 16);
            lblpagocon.TabIndex = 223;
            lblpagocon.Text = "0.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(242, 421);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 222;
            label13.Text = "Cambio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(121, 421);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 212;
            label11.Text = "Pagar con: ";
            // 
            // btncancelarventa
            // 
            btncancelarventa.BackColor = SystemColors.Control;
            btncancelarventa.Cursor = Cursors.Hand;
            btncancelarventa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelarventa.IconChar = FontAwesome.Sharp.IconChar.Times;
            btncancelarventa.IconColor = Color.Crimson;
            btncancelarventa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btncancelarventa.IconSize = 20;
            btncancelarventa.ImageAlign = ContentAlignment.BottomCenter;
            btncancelarventa.Location = new Point(375, 413);
            btncancelarventa.Name = "btncancelarventa";
            btncancelarventa.Size = new Size(147, 31);
            btncancelarventa.TabIndex = 148;
            btncancelarventa.Text = "Cancelar Compra";
            btncancelarventa.TextAlign = ContentAlignment.MiddleRight;
            btncancelarventa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelarventa.UseVisualStyleBackColor = true;
            btncancelarventa.Click += btncancelarventa_Click;
            // 
            // btndescargarpdf
            // 
            btndescargarpdf.BackColor = SystemColors.Control;
            btndescargarpdf.Cursor = Cursors.Hand;
            btndescargarpdf.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btndescargarpdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btndescargarpdf.IconColor = Color.Crimson;
            btndescargarpdf.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btndescargarpdf.IconSize = 17;
            btndescargarpdf.ImageAlign = ContentAlignment.BottomCenter;
            btndescargarpdf.Location = new Point(528, 412);
            btndescargarpdf.Name = "btndescargarpdf";
            btndescargarpdf.Size = new Size(128, 31);
            btndescargarpdf.TabIndex = 147;
            btndescargarpdf.Text = "Descargar PDF";
            btndescargarpdf.TextAlign = ContentAlignment.MiddleRight;
            btndescargarpdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndescargarpdf.UseVisualStyleBackColor = true;
            btndescargarpdf.Click += btndescargarpdf_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Precio, SubTotal });
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
            // Precio
            // 
            Precio.HeaderText = "Precio ";
            Precio.Name = "Precio";
            Precio.Resizable = DataGridViewTriState.False;
            Precio.SortMode = DataGridViewColumnSortMode.NotSortable;
            Precio.Width = 120;
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
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(6, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(650, 68);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombrecliente.Location = new Point(458, 25);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.ReadOnly = true;
            txtnombrecliente.Size = new Size(177, 21);
            txtnombrecliente.TabIndex = 205;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtdoccliente.Location = new Point(123, 25);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.ReadOnly = true;
            txtdoccliente.Size = new Size(150, 21);
            txtdoccliente.TabIndex = 204;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(338, 28);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 2;
            label8.Text = "Nombre Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 28);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 1;
            label7.Text = "Doc. Cliente:";
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
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(579, 71);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 217;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(522, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 216;
            label2.Text = "Estado: ";
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
            btnborrar.Location = new Point(401, 68);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(103, 23);
            btnborrar.TabIndex = 215;
            btnborrar.Text = "Limpiar";
            btnborrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
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
            btnbuscar.Location = new Point(296, 68);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(99, 23);
            btnbuscar.TabIndex = 214;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 71);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 213;
            label1.Text = "Numero Documento: ";
            // 
            // txtbusqueda
            // 
            txtbusqueda.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbusqueda.Location = new Point(140, 68);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(150, 21);
            txtbusqueda.TabIndex = 212;
            txtbusqueda.KeyDown += txtbusqueda_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 57);
            panel1.TabIndex = 211;
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
            // 
            // frmBuscarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(682, 553);
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
            Name = "frmBuscarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Buscar Venta :.";
            Load += frmBuscarVenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btncancelarventa;
        private FontAwesome.Sharp.IconButton btndescargarpdf;
        private Label lbltotal;
        private Label label9;
        private GroupBox groupBox3;
        private DataGridView dgvdata;
        private GroupBox groupBox2;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private Label label6;
        private TextBox txtfecharegistro;
        private TextBox txtnumerodocumento;
        private TextBox txtusuarioregistro;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label5;
        private Label lblEstado;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Label label1;
        private TextBox txtbusqueda;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Usuarios;
        private Label label11;
        private Label lblcambio;
        private Label lblpagocon;
        private Label label13;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
    }
}