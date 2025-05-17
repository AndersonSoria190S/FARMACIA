namespace FARMACIA
{
    partial class Inicio
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblstatus1 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblstatus2 = new ToolStripStatusLabel();
            menuMantenimiento = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menuClientes = new FontAwesome.Sharp.IconButton();
            menuCompras = new FontAwesome.Sharp.IconButton();
            menuReportes = new FontAwesome.Sharp.IconButton();
            menuVentas = new FontAwesome.Sharp.IconButton();
            menuProductos = new FontAwesome.Sharp.IconButton();
            menuProveedores = new FontAwesome.Sharp.IconButton();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 143, 213);
            statusStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblstatus1, toolStripStatusLabel3, lblstatus2 });
            statusStrip1.Location = new Point(0, 460);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(725, 25);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = SystemColors.ControlLightLight;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(148, 20);
            toolStripStatusLabel1.Text = "Nombre Usuario: ";
            // 
            // lblstatus1
            // 
            lblstatus1.ForeColor = SystemColors.ControlLightLight;
            lblstatus1.Name = "lblstatus1";
            lblstatus1.Size = new Size(184, 20);
            lblstatus1.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.ForeColor = SystemColors.ControlLightLight;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(103, 20);
            toolStripStatusLabel3.Text = "Fecha Hora";
            // 
            // lblstatus2
            // 
            lblstatus2.ForeColor = SystemColors.ControlLightLight;
            lblstatus2.Name = "lblstatus2";
            lblstatus2.Size = new Size(184, 20);
            lblstatus2.Text = "toolStripStatusLabel4";
            // 
            // menuMantenimiento
            // 
            menuMantenimiento.BackColor = Color.FromArgb(0, 143, 213);
            menuMantenimiento.FlatStyle = FlatStyle.Flat;
            menuMantenimiento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuMantenimiento.ForeColor = SystemColors.ControlLightLight;
            menuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            menuMantenimiento.IconColor = Color.White;
            menuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenimiento.IconSize = 80;
            menuMantenimiento.ImageAlign = ContentAlignment.TopCenter;
            menuMantenimiento.Location = new Point(475, 291);
            menuMantenimiento.Margin = new Padding(1);
            menuMantenimiento.Name = "menuMantenimiento";
            menuMantenimiento.Size = new Size(117, 91);
            menuMantenimiento.TabIndex = 2;
            menuMantenimiento.Text = "Mantenimiento";
            menuMantenimiento.TextAlign = ContentAlignment.BottomCenter;
            menuMantenimiento.UseVisualStyleBackColor = false;
            menuMantenimiento.Click += iconButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 78);
            panel1.TabIndex = 4;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(0, 143, 213);
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 50;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(660, 12);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 53);
            iconButton2.TabIndex = 5;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 143, 213);
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = SystemColors.ActiveCaption;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(601, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(53, 53);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // menuClientes
            // 
            menuClientes.BackColor = Color.FromArgb(0, 143, 213);
            menuClientes.FlatStyle = FlatStyle.Flat;
            menuClientes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuClientes.ForeColor = SystemColors.ControlLightLight;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            menuClientes.IconColor = Color.White;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 80;
            menuClientes.ImageAlign = ContentAlignment.TopCenter;
            menuClientes.Location = new Point(213, 150);
            menuClientes.Margin = new Padding(1);
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(117, 91);
            menuClientes.TabIndex = 12;
            menuClientes.Text = "Clientes";
            menuClientes.TextAlign = ContentAlignment.BottomCenter;
            menuClientes.UseVisualStyleBackColor = false;
            menuClientes.Click += menuClientes_Click;
            // 
            // menuCompras
            // 
            menuCompras.BackColor = Color.FromArgb(0, 143, 213);
            menuCompras.FlatStyle = FlatStyle.Flat;
            menuCompras.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuCompras.ForeColor = SystemColors.ControlLightLight;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            menuCompras.IconColor = Color.White;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 80;
            menuCompras.ImageAlign = ContentAlignment.TopCenter;
            menuCompras.Location = new Point(384, 150);
            menuCompras.Margin = new Padding(1);
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(117, 91);
            menuCompras.TabIndex = 13;
            menuCompras.Text = "Compras";
            menuCompras.TextAlign = ContentAlignment.BottomCenter;
            menuCompras.UseVisualStyleBackColor = false;
            menuCompras.Click += menuCompras_Click;
            // 
            // menuReportes
            // 
            menuReportes.BackColor = Color.FromArgb(0, 143, 213);
            menuReportes.FlatStyle = FlatStyle.Flat;
            menuReportes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuReportes.ForeColor = SystemColors.ControlLightLight;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.Trello;
            menuReportes.IconColor = Color.White;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 70;
            menuReportes.ImageAlign = ContentAlignment.TopCenter;
            menuReportes.Location = new Point(297, 291);
            menuReportes.Margin = new Padding(1);
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(117, 91);
            menuReportes.TabIndex = 16;
            menuReportes.Text = "Reportes";
            menuReportes.TextAlign = ContentAlignment.BottomCenter;
            menuReportes.UseVisualStyleBackColor = false;
            // 
            // menuVentas
            // 
            menuVentas.BackColor = Color.FromArgb(0, 143, 213);
            menuVentas.FlatStyle = FlatStyle.Flat;
            menuVentas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuVentas.ForeColor = SystemColors.ControlLightLight;
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.White;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 80;
            menuVentas.ImageAlign = ContentAlignment.TopCenter;
            menuVentas.Location = new Point(50, 150);
            menuVentas.Margin = new Padding(1);
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(117, 91);
            menuVentas.TabIndex = 15;
            menuVentas.Text = "Ventas";
            menuVentas.TextAlign = ContentAlignment.BottomCenter;
            menuVentas.UseVisualStyleBackColor = false;
            menuVentas.Click += menuVentas_Click;
            // 
            // menuProductos
            // 
            menuProductos.BackColor = Color.FromArgb(0, 143, 213);
            menuProductos.FlatStyle = FlatStyle.Flat;
            menuProductos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuProductos.ForeColor = SystemColors.ControlLightLight;
            menuProductos.IconChar = FontAwesome.Sharp.IconChar.FirstAid;
            menuProductos.IconColor = Color.White;
            menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProductos.IconSize = 70;
            menuProductos.ImageAlign = ContentAlignment.TopCenter;
            menuProductos.Location = new Point(129, 291);
            menuProductos.Margin = new Padding(1);
            menuProductos.Name = "menuProductos";
            menuProductos.Size = new Size(117, 91);
            menuProductos.TabIndex = 14;
            menuProductos.Text = "Productos Farmacia";
            menuProductos.TextAlign = ContentAlignment.BottomCenter;
            menuProductos.UseVisualStyleBackColor = false;
            menuProductos.Click += menuProductos_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.BackColor = Color.FromArgb(0, 143, 213);
            menuProveedores.FlatStyle = FlatStyle.Flat;
            menuProveedores.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuProveedores.ForeColor = SystemColors.ControlLightLight;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Trello;
            menuProveedores.IconColor = Color.White;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 70;
            menuProveedores.ImageAlign = ContentAlignment.TopCenter;
            menuProveedores.Location = new Point(549, 150);
            menuProveedores.Margin = new Padding(1);
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(117, 91);
            menuProveedores.TabIndex = 17;
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextAlign = ContentAlignment.BottomCenter;
            menuProveedores.UseVisualStyleBackColor = false;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(725, 485);
            Controls.Add(menuProveedores);
            Controls.Add(menuReportes);
            Controls.Add(menuVentas);
            Controls.Add(menuProductos);
            Controls.Add(menuCompras);
            Controls.Add(menuClientes);
            Controls.Add(panel1);
            Controls.Add(menuMantenimiento);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Inicio :.";
            Load += Inicio_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblstatus1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblstatus2;
        private FontAwesome.Sharp.IconButton menuMantenimiento;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton menuClientes;
        private FontAwesome.Sharp.IconButton menuCompras;
        private FontAwesome.Sharp.IconButton menuReportes;
        private FontAwesome.Sharp.IconButton menuVentas;
        private FontAwesome.Sharp.IconButton menuProductos;
        private FontAwesome.Sharp.IconButton menuProveedores;
    }
}