namespace FARMACIA.Formularios.Mantenimiento
{
    partial class frmPermisos
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
            panel2 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            a_mantenimiento = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            a_proveedores = new CheckBox();
            a_clientes = new CheckBox();
            a_productos = new CheckBox();
            a_compras = new CheckBox();
            a_ventas = new CheckBox();
            panel3 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            e_mantenimiento = new CheckBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            e_proveedores = new CheckBox();
            e_clientes = new CheckBox();
            e_productos = new CheckBox();
            e_compras = new CheckBox();
            e_ventas = new CheckBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 177, 234);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-6, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 45);
            panel1.TabIndex = 0;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(5, 177, 234);
            btnsalir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.ForeColor = SystemColors.ControlLightLight;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnsalir.IconSize = 24;
            btnsalir.ImageAlign = ContentAlignment.BottomCenter;
            btnsalir.Location = new Point(356, 9);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(69, 31);
            btnsalir.TabIndex = 211;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(18, 10);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(96, 24);
            Usuarios.TabIndex = 2;
            Usuarios.Text = "Permisos";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(a_mantenimiento);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(a_proveedores);
            panel2.Controls.Add(a_clientes);
            panel2.Controls.Add(a_productos);
            panel2.Controls.Add(a_compras);
            panel2.Controls.Add(a_ventas);
            panel2.Location = new Point(12, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 213);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 17;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(13, 181);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(156, 23);
            iconButton1.TabIndex = 22;
            iconButton1.Text = "Guardar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(80, 152);
            label12.Name = "label12";
            label12.Size = new Size(89, 15);
            label12.TabIndex = 21;
            label12.Text = "Mantenimiento";
            // 
            // a_mantenimiento
            // 
            a_mantenimiento.AutoSize = true;
            a_mantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            a_mantenimiento.Location = new Point(13, 152);
            a_mantenimiento.Name = "a_mantenimiento";
            a_mantenimiento.Size = new Size(15, 14);
            a_mantenimiento.TabIndex = 20;
            a_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(97, 132);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 19;
            label11.Text = "Proveedores";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(120, 112);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 18;
            label10.Text = "Clientes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 92);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 17;
            label9.Text = "Productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(114, 71);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 16;
            label8.Text = "Compras";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 51);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 15;
            label7.Text = "Ventas";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(156, 13);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 11);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "Menú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 11);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 12;
            label3.Text = "Activar";
            // 
            // a_proveedores
            // 
            a_proveedores.AutoSize = true;
            a_proveedores.Location = new Point(13, 132);
            a_proveedores.Name = "a_proveedores";
            a_proveedores.Size = new Size(15, 14);
            a_proveedores.TabIndex = 11;
            a_proveedores.UseVisualStyleBackColor = true;
            // 
            // a_clientes
            // 
            a_clientes.AutoSize = true;
            a_clientes.Location = new Point(13, 112);
            a_clientes.Name = "a_clientes";
            a_clientes.Size = new Size(15, 14);
            a_clientes.TabIndex = 10;
            a_clientes.UseVisualStyleBackColor = true;
            a_clientes.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // a_productos
            // 
            a_productos.AutoSize = true;
            a_productos.Location = new Point(13, 92);
            a_productos.Name = "a_productos";
            a_productos.Size = new Size(15, 14);
            a_productos.TabIndex = 9;
            a_productos.UseVisualStyleBackColor = true;
            // 
            // a_compras
            // 
            a_compras.AutoSize = true;
            a_compras.Location = new Point(13, 72);
            a_compras.Name = "a_compras";
            a_compras.Size = new Size(15, 14);
            a_compras.TabIndex = 8;
            a_compras.UseVisualStyleBackColor = true;
            // 
            // a_ventas
            // 
            a_ventas.AutoSize = true;
            a_ventas.Location = new Point(13, 52);
            a_ventas.Name = "a_ventas";
            a_ventas.Size = new Size(15, 14);
            a_ventas.TabIndex = 7;
            a_ventas.UseVisualStyleBackColor = true;
            a_ventas.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(e_mantenimiento);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(e_proveedores);
            panel3.Controls.Add(e_clientes);
            panel3.Controls.Add(e_productos);
            panel3.Controls.Add(e_compras);
            panel3.Controls.Add(e_ventas);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(226, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 213);
            panel3.TabIndex = 2;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 17;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(9, 181);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(156, 23);
            iconButton2.TabIndex = 23;
            iconButton2.Text = "Guardar";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(76, 152);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 33;
            label13.Text = "Mantenimiento";
            // 
            // e_mantenimiento
            // 
            e_mantenimiento.AutoSize = true;
            e_mantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            e_mantenimiento.Location = new Point(9, 152);
            e_mantenimiento.Name = "e_mantenimiento";
            e_mantenimiento.Size = new Size(15, 14);
            e_mantenimiento.TabIndex = 32;
            e_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(93, 132);
            label14.Name = "label14";
            label14.Size = new Size(72, 15);
            label14.TabIndex = 31;
            label14.Text = "Proveedores";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(116, 112);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 30;
            label15.Text = "Clientes";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(104, 92);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 29;
            label16.Text = "Productos";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(110, 71);
            label17.Name = "label17";
            label17.Size = new Size(55, 15);
            label17.TabIndex = 28;
            label17.Text = "Compras";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(124, 51);
            label18.Name = "label18";
            label18.Size = new Size(41, 15);
            label18.TabIndex = 27;
            label18.Text = "Ventas";
            // 
            // e_proveedores
            // 
            e_proveedores.AutoSize = true;
            e_proveedores.Location = new Point(9, 132);
            e_proveedores.Name = "e_proveedores";
            e_proveedores.Size = new Size(15, 14);
            e_proveedores.TabIndex = 26;
            e_proveedores.UseVisualStyleBackColor = true;
            // 
            // e_clientes
            // 
            e_clientes.AutoSize = true;
            e_clientes.Location = new Point(9, 112);
            e_clientes.Name = "e_clientes";
            e_clientes.Size = new Size(15, 14);
            e_clientes.TabIndex = 25;
            e_clientes.UseVisualStyleBackColor = true;
            // 
            // e_productos
            // 
            e_productos.AutoSize = true;
            e_productos.Location = new Point(9, 92);
            e_productos.Name = "e_productos";
            e_productos.Size = new Size(15, 14);
            e_productos.TabIndex = 24;
            e_productos.UseVisualStyleBackColor = true;
            // 
            // e_compras
            // 
            e_compras.AutoSize = true;
            e_compras.Location = new Point(9, 72);
            e_compras.Name = "e_compras";
            e_compras.Size = new Size(15, 14);
            e_compras.TabIndex = 23;
            e_compras.UseVisualStyleBackColor = true;
            // 
            // e_ventas
            // 
            e_ventas.AutoSize = true;
            e_ventas.Location = new Point(9, 52);
            e_ventas.Name = "e_ventas";
            e_ventas.Size = new Size(15, 14);
            e_ventas.TabIndex = 22;
            e_ventas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(9, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(156, 13);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 11);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "Menú";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 11);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 15;
            label6.Text = "Activar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 9;
            label2.Text = "Permisos Administrador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(226, 58);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 10;
            label1.Text = "Permisos Farmaceuticos";
            // 
            // frmPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(422, 311);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPermisos";
            StartPosition = FormStartPosition.CenterParent;
            Text = ".: Permisos :.";
            Load += frmPermisos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label Usuarios;
        private Label label2;
        private Label label1;
        private CheckBox a_ventas;
        private CheckBox a_proveedores;
        private CheckBox a_clientes;
        private CheckBox a_productos;
        private CheckBox a_compras;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label12;
        private CheckBox a_mantenimiento;
        private Label label11;
        private Label label10;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label13;
        private CheckBox e_mantenimiento;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private CheckBox e_proveedores;
        private CheckBox e_clientes;
        private CheckBox e_productos;
        private CheckBox e_compras;
        private CheckBox e_ventas;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}