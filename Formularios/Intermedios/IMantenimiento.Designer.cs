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
            btnnuevacompra.Size = new Size(237, 50);
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
            btnbuscarcompra.Location = new Point(31, 88);
            btnbuscarcompra.Name = "btnbuscarcompra";
            btnbuscarcompra.Padding = new Padding(60, 3, 0, 0);
            btnbuscarcompra.Size = new Size(237, 50);
            btnbuscarcompra.TabIndex = 2;
            btnbuscarcompra.Text = "Permisos";
            btnbuscarcompra.UseVisualStyleBackColor = false;
            btnbuscarcompra.Click += btnbuscarcompra_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnbuscarcompra);
            panel1.Controls.Add(btnnuevacompra);
            panel1.Location = new Point(9, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 296);
            panel1.TabIndex = 3;
            // 
            // IMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(322, 314);
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
    }
}