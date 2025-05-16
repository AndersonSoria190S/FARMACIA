namespace FARMACIA.Intermedios
{
    partial class IMantenimiento
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
            fileSystemWatcher1 = new FileSystemWatcher();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnnuevacompra = new FontAwesome.Sharp.IconButton();
            btnbuscarcompra = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnnuevacompra
            // 
            btnnuevacompra.BackColor = Color.FromArgb(0, 143, 213);
            btnnuevacompra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnnuevacompra.ForeColor = Color.White;
            btnnuevacompra.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnnuevacompra.IconColor = Color.White;
            btnnuevacompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevacompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevacompra.Location = new Point(31, 22);
            btnnuevacompra.Name = "btnnuevacompra";
            btnnuevacompra.Padding = new Padding(60, 3, 0, 0);
            btnnuevacompra.Size = new Size(282, 50);
            btnnuevacompra.TabIndex = 1;
            btnnuevacompra.Text = "Usuarios";
            btnnuevacompra.UseVisualStyleBackColor = false;
            btnnuevacompra.Click += iconButton1_Click;
            // 
            // btnbuscarcompra
            // 
            btnbuscarcompra.BackColor = Color.FromArgb(0, 143, 213);
            btnbuscarcompra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscarcompra.ForeColor = Color.White;
            btnbuscarcompra.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            btnbuscarcompra.IconColor = Color.White;
            btnbuscarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarcompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnbuscarcompra.Location = new Point(31, 78);
            btnbuscarcompra.Name = "btnbuscarcompra";
            btnbuscarcompra.Padding = new Padding(60, 3, 0, 0);
            btnbuscarcompra.Size = new Size(282, 50);
            btnbuscarcompra.TabIndex = 2;
            btnbuscarcompra.Text = "Permisos";
            btnbuscarcompra.UseVisualStyleBackColor = false;
            btnbuscarcompra.Click += btnbuscarcompra_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnbuscarcompra);
            panel1.Controls.Add(btnnuevacompra);
            panel1.Location = new Point(9, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 261);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(0, 143, 213);
            iconButton2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(31, 134);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(60, 3, 0, 0);
            iconButton2.Size = new Size(282, 50);
            iconButton2.TabIndex = 4;
            iconButton2.Text = " Datos de Negocio";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 143, 213);
            iconButton1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(31, 190);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(60, 3, 0, 0);
            iconButton1.Size = new Size(282, 50);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Cerrar";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // IMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(362, 279);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IMantenimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMantenimiento";
            Load += IMantenimiento_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton btnnuevacompra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnbuscarcompra;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}