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
            menuProveedores = new FontAwesome.Sharp.IconButton();
            menuCompras = new FontAwesome.Sharp.IconButton();
            menuVentas = new FontAwesome.Sharp.IconButton();
            menuProductos = new FontAwesome.Sharp.IconButton();
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
            statusStrip1.Size = new Size(652, 25);
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
            menuMantenimiento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuMantenimiento.ForeColor = SystemColors.ControlLightLight;
            menuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            menuMantenimiento.IconColor = Color.White;
            menuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenimiento.IconSize = 80;
            menuMantenimiento.ImageAlign = ContentAlignment.TopCenter;
            menuMantenimiento.Location = new Point(480, 291);
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
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 104);
            panel1.TabIndex = 4;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(0, 143, 213);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 50;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(587, 13);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 53);
            iconButton2.TabIndex = 5;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 143, 213);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(528, 13);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(53, 53);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // menuClientes
            // 
            menuClientes.BackColor = Color.FromArgb(0, 143, 213);
            menuClientes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuClientes.ForeColor = SystemColors.ControlLightLight;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            menuClientes.IconColor = Color.White;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 80;
            menuClientes.ImageAlign = ContentAlignment.TopCenter;
            menuClientes.Location = new Point(268, 150);
            menuClientes.Margin = new Padding(1);
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(117, 91);
            menuClientes.TabIndex = 12;
            menuClientes.Text = "Mantenimiento";
            menuClientes.TextAlign = ContentAlignment.BottomCenter;
            menuClientes.UseVisualStyleBackColor = false;
            // 
            // menuProveedores
            // 
            menuProveedores.BackColor = Color.FromArgb(0, 143, 213);
            menuProveedores.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuProveedores.ForeColor = SystemColors.ControlLightLight;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            menuProveedores.IconColor = Color.White;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 80;
            menuProveedores.ImageAlign = ContentAlignment.TopCenter;
            menuProveedores.Location = new Point(480, 150);
            menuProveedores.Margin = new Padding(1);
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(117, 91);
            menuProveedores.TabIndex = 13;
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextAlign = ContentAlignment.BottomCenter;
            menuProveedores.UseVisualStyleBackColor = false;
            // 
            // menuCompras
            // 
            menuCompras.BackColor = Color.FromArgb(0, 143, 213);
            menuCompras.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuCompras.ForeColor = SystemColors.ControlLightLight;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.Trello;
            menuCompras.IconColor = Color.White;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 70;
            menuCompras.ImageAlign = ContentAlignment.TopCenter;
            menuCompras.Location = new Point(268, 291);
            menuCompras.Margin = new Padding(1);
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(117, 91);
            menuCompras.TabIndex = 16;
            menuCompras.Text = "Reportes";
            menuCompras.TextAlign = ContentAlignment.BottomCenter;
            menuCompras.UseVisualStyleBackColor = false;
            // 
            // menuVentas
            // 
            menuVentas.BackColor = Color.FromArgb(0, 143, 213);
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
            // 
            // menuProductos
            // 
            menuProductos.BackColor = Color.FromArgb(0, 143, 213);
            menuProductos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuProductos.ForeColor = SystemColors.ControlLightLight;
            menuProductos.IconChar = FontAwesome.Sharp.IconChar.FirstAid;
            menuProductos.IconColor = Color.White;
            menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProductos.IconSize = 70;
            menuProductos.ImageAlign = ContentAlignment.TopCenter;
            menuProductos.Location = new Point(50, 291);
            menuProductos.Margin = new Padding(1);
            menuProductos.Name = "menuProductos";
            menuProductos.Size = new Size(117, 91);
            menuProductos.TabIndex = 14;
            menuProductos.Text = "Productos Farmacia";
            menuProductos.TextAlign = ContentAlignment.BottomCenter;
            menuProductos.UseVisualStyleBackColor = false;
            menuProductos.Click += menuProductos_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(652, 485);
            Controls.Add(menuCompras);
            Controls.Add(menuVentas);
            Controls.Add(menuProductos);
            Controls.Add(menuProveedores);
            Controls.Add(menuClientes);
            Controls.Add(panel1);
            Controls.Add(menuMantenimiento);
            Controls.Add(statusStrip1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
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
        private FontAwesome.Sharp.IconButton menuProveedores;
        private FontAwesome.Sharp.IconButton menuCompras;
        private FontAwesome.Sharp.IconButton menuVentas;
        private FontAwesome.Sharp.IconButton menuProductos;
    }
}