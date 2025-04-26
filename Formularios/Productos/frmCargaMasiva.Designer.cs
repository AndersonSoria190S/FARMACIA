namespace FARMACIA.Formularios.Productos
{
    partial class frmCargaMasiva
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
            btnsalir = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtarchivo = new TextBox();
            btncargar = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            lblresumen = new Label();
            btndescargar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            dgvdata = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            NroFila = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Mensaje = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 45);
            panel1.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 143, 213);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(692, 8);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(69, 31);
            iconButton1.TabIndex = 212;
            iconButton1.Text = "Salir";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(0, 143, 213);
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.ForeColor = SystemColors.ControlLightLight;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnsalir.IconColor = Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnsalir.IconSize = 24;
            btnsalir.Location = new Point(952, 8);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(69, 31);
            btnsalir.TabIndex = 211;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(12, 9);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(172, 24);
            Usuarios.TabIndex = 3;
            Usuarios.Text = "Cargar Productos";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(15, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 15);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 6;
            label1.Text = "Seleccionar Archivo : ";
            // 
            // txtarchivo
            // 
            txtarchivo.Cursor = Cursors.IBeam;
            txtarchivo.Location = new Point(133, 61);
            txtarchivo.Name = "txtarchivo";
            txtarchivo.ReadOnly = true;
            txtarchivo.Size = new Size(344, 23);
            txtarchivo.TabIndex = 140;
            // 
            // btncargar
            // 
            btncargar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btncargar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btncargar.IconColor = Color.Black;
            btncargar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btncargar.IconSize = 17;
            btncargar.ImageAlign = ContentAlignment.TopCenter;
            btncargar.Location = new Point(483, 63);
            btncargar.Name = "btncargar";
            btncargar.Size = new Size(76, 21);
            btncargar.TabIndex = 141;
            btncargar.Text = "Subir";
            btncargar.TextAlign = ContentAlignment.MiddleRight;
            btncargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncargar.UseVisualStyleBackColor = true;
            btncargar.Click += btnguardar_Click;
            // 
            // iconButton2
            // 
            iconButton2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 17;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(565, 63);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(76, 21);
            iconButton2.TabIndex = 142;
            iconButton2.Text = "Procesar";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(659, 63);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(102, 21);
            progressBar1.TabIndex = 143;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(80, 97);
            label2.Name = "label2";
            label2.Size = new Size(58, 13);
            label2.TabIndex = 144;
            label2.Text = "Resumen: ";
            // 
            // lblresumen
            // 
            lblresumen.AutoSize = true;
            lblresumen.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblresumen.ForeColor = Color.Blue;
            lblresumen.Location = new Point(149, 97);
            lblresumen.Name = "lblresumen";
            lblresumen.Size = new Size(35, 13);
            lblresumen.TabIndex = 145;
            lblresumen.Text = "label3";
            // 
            // btndescargar
            // 
            btndescargar.BackColor = SystemColors.Control;
            btndescargar.Cursor = Cursors.Hand;
            btndescargar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btndescargar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btndescargar.IconColor = Color.ForestGreen;
            btndescargar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btndescargar.IconSize = 17;
            btndescargar.ImageAlign = ContentAlignment.BottomCenter;
            btndescargar.Location = new Point(622, 142);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(128, 21);
            btndescargar.TabIndex = 146;
            btndescargar.Text = "Descargar Excel";
            btndescargar.TextAlign = ContentAlignment.MiddleRight;
            btndescargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndescargar.UseVisualStyleBackColor = true;
            btndescargar.Click += btndescargar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 194;
            label3.Text = "RESULTADOS";
            label3.Click += label3_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { NroFila, Codigo, Mensaje, Estado });
            dgvdata.Location = new Point(12, 184);
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(749, 352);
            dgvdata.TabIndex = 195;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // NroFila
            // 
            NroFila.HeaderText = "Nro. Fila";
            NroFila.Name = "NroFila";
            NroFila.Resizable = DataGridViewTriState.False;
            NroFila.SortMode = DataGridViewColumnSortMode.NotSortable;
            NroFila.Visible = false;
            NroFila.Width = 70;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Resizable = DataGridViewTriState.False;
            Codigo.SortMode = DataGridViewColumnSortMode.NotSortable;
            Codigo.Width = 120;
            // 
            // Mensaje
            // 
            Mensaje.HeaderText = "Producto";
            Mensaje.Name = "Mensaje";
            Mensaje.Resizable = DataGridViewTriState.False;
            Mensaje.SortMode = DataGridViewColumnSortMode.NotSortable;
            Mensaje.Width = 450;
            // 
            // Estado
            // 
            Estado.HeaderText = "";
            Estado.Name = "Estado";
            Estado.Resizable = DataGridViewTriState.False;
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            Estado.Width = 135;
            // 
            // frmCargaMasiva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(773, 569);
            ControlBox = false;
            Controls.Add(dgvdata);
            Controls.Add(btndescargar);
            Controls.Add(label3);
            Controls.Add(lblresumen);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(iconButton2);
            Controls.Add(btncargar);
            Controls.Add(txtarchivo);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCargaMasiva";
            StartPosition = FormStartPosition.CenterParent;
            Text = ".: Carga Masiva :.";
            Load += frmCargaMasiva_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private Label Usuarios;
        private FontAwesome.Sharp.IconButton iconButton1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtarchivo;
        private FontAwesome.Sharp.IconButton btncargar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ProgressBar progressBar1;
        private Label label2;
        private Label lblresumen;
        private FontAwesome.Sharp.IconButton btndescargar;
        private Label label3;
        private DataGridView dgvdata;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn NroFila;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Mensaje;
        private DataGridViewTextBoxColumn Estado;
    }
}