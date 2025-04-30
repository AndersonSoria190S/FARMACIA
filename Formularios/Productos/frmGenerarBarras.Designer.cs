namespace FARMACIA.Formularios.Productos
{
    partial class frmGenerarBarras
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtdescripcion = new TextBox();
            txtcodigo = new TextBox();
            txtnumeroetiquetas = new NumericUpDown();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            chkmostrardescripcion = new CheckBox();
            chkmostrarcodigo = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            cboorientacion = new ComboBox();
            cbotipocodigo = new ComboBox();
            progressBar1 = new ProgressBar();
            btngenerardocumento = new FontAwesome.Sharp.IconButton();
            btngenerarimagen = new FontAwesome.Sharp.IconButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtnumeroetiquetas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 44);
            panel1.TabIndex = 2;
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
            iconButton1.Location = new Point(750, 8);
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
            Usuarios.Size = new Size(278, 24);
            Usuarios.TabIndex = 3;
            Usuarios.Text = "Generador Codigo de Barras";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnbuscar);
            groupBox1.Controls.Add(txtdescripcion);
            groupBox1.Controls.Add(txtcodigo);
            groupBox1.Controls.Add(txtnumeroetiquetas);
            groupBox1.Location = new Point(11, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Etiqueta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 80);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 14;
            label3.Text = "Nro Etiquetas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 52);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 13;
            label2.Text = "Descripcion: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 12;
            label1.Text = "Codigo:";
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.WhiteSmoke;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(310, 20);
            btnbuscar.Margin = new Padding(1);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new Padding(0, 3, 0, 0);
            btnbuscar.Size = new Size(32, 23);
            btnbuscar.TabIndex = 11;
            btnbuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(123, 49);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(219, 23);
            txtdescripcion.TabIndex = 2;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(123, 20);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(183, 23);
            txtcodigo.TabIndex = 1;
            txtcodigo.KeyDown += txtcodigo_KeyDown;
            // 
            // txtnumeroetiquetas
            // 
            txtnumeroetiquetas.Location = new Point(123, 78);
            txtnumeroetiquetas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtnumeroetiquetas.Name = "txtnumeroetiquetas";
            txtnumeroetiquetas.Size = new Size(219, 23);
            txtnumeroetiquetas.TabIndex = 0;
            txtnumeroetiquetas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboorientacion);
            groupBox2.Controls.Add(cbotipocodigo);
            groupBox2.Location = new Point(374, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Configuracion";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkmostrardescripcion);
            groupBox3.Controls.Add(chkmostrarcodigo);
            groupBox3.Location = new Point(10, 73);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 46);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Etiqueta";
            // 
            // chkmostrardescripcion
            // 
            chkmostrardescripcion.AutoSize = true;
            chkmostrardescripcion.Location = new Point(141, 19);
            chkmostrardescripcion.Name = "chkmostrardescripcion";
            chkmostrardescripcion.Size = new Size(132, 19);
            chkmostrardescripcion.TabIndex = 1;
            chkmostrardescripcion.Text = "Mostrar Descripcion";
            chkmostrardescripcion.UseVisualStyleBackColor = true;
            // 
            // chkmostrarcodigo
            // 
            chkmostrarcodigo.AutoSize = true;
            chkmostrarcodigo.Location = new Point(13, 19);
            chkmostrarcodigo.Name = "chkmostrarcodigo";
            chkmostrarcodigo.Size = new Size(109, 19);
            chkmostrarcodigo.TabIndex = 0;
            chkmostrarcodigo.Text = "Mostrar Codigo";
            chkmostrarcodigo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 47);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 3;
            label5.Text = "Orientacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 20);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 2;
            label4.Text = "Tipo:";
            label4.Click += label4_Click;
            // 
            // cboorientacion
            // 
            cboorientacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboorientacion.FormattingEnabled = true;
            cboorientacion.Location = new Point(135, 44);
            cboorientacion.Name = "cboorientacion";
            cboorientacion.Size = new Size(164, 23);
            cboorientacion.TabIndex = 1;
            // 
            // cbotipocodigo
            // 
            cbotipocodigo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipocodigo.FormattingEnabled = true;
            cbotipocodigo.Location = new Point(135, 16);
            cbotipocodigo.Name = "cbotipocodigo";
            cbotipocodigo.Size = new Size(164, 23);
            cbotipocodigo.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(11, 191);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(668, 34);
            progressBar1.TabIndex = 5;
            // 
            // btngenerardocumento
            // 
            btngenerardocumento.BackColor = SystemColors.ControlLight;
            btngenerardocumento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btngenerardocumento.ForeColor = SystemColors.ActiveCaptionText;
            btngenerardocumento.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            btngenerardocumento.IconColor = Color.FromArgb(0, 143, 213);
            btngenerardocumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btngenerardocumento.IconSize = 40;
            btngenerardocumento.ImageAlign = ContentAlignment.TopCenter;
            btngenerardocumento.Location = new Point(693, 68);
            btngenerardocumento.Margin = new Padding(1);
            btngenerardocumento.Name = "btngenerardocumento";
            btngenerardocumento.Size = new Size(125, 54);
            btngenerardocumento.TabIndex = 15;
            btngenerardocumento.Text = "Generar Documento";
            btngenerardocumento.TextAlign = ContentAlignment.BottomCenter;
            btngenerardocumento.UseVisualStyleBackColor = false;
            btngenerardocumento.Click += btngenerardocumento_Click;
            // 
            // btngenerarimagen
            // 
            btngenerarimagen.BackColor = SystemColors.ControlLight;
            btngenerarimagen.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btngenerarimagen.ForeColor = SystemColors.ActiveCaptionText;
            btngenerarimagen.IconChar = FontAwesome.Sharp.IconChar.Image;
            btngenerarimagen.IconColor = Color.FromArgb(0, 143, 213);
            btngenerarimagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btngenerarimagen.IconSize = 40;
            btngenerarimagen.ImageAlign = ContentAlignment.TopCenter;
            btngenerarimagen.Location = new Point(693, 133);
            btngenerarimagen.Margin = new Padding(1);
            btngenerarimagen.Name = "btngenerarimagen";
            btngenerarimagen.Size = new Size(125, 52);
            btngenerarimagen.TabIndex = 16;
            btngenerarimagen.Text = "Generar Imagen";
            btngenerarimagen.TextAlign = ContentAlignment.BottomCenter;
            btngenerarimagen.UseVisualStyleBackColor = false;
            btngenerarimagen.Click += btngenerarimagen_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // frmGenerarBarras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(830, 237);
            ControlBox = false;
            Controls.Add(btngenerarimagen);
            Controls.Add(btngenerardocumento);
            Controls.Add(progressBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmGenerarBarras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Generar Barras :.";
            Load += frmGenerarBarras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtnumeroetiquetas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private Label Usuarios;
        private GroupBox groupBox1;
        private TextBox txtdescripcion;
        private TextBox txtcodigo;
        private NumericUpDown txtnumeroetiquetas;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cboorientacion;
        private ComboBox cbotipocodigo;
        private Label label5;
        private GroupBox groupBox3;
        private CheckBox chkmostrardescripcion;
        private CheckBox chkmostrarcodigo;
        private ProgressBar progressBar1;
        private FontAwesome.Sharp.IconButton btngenerardocumento;
        private FontAwesome.Sharp.IconButton btngenerarimagen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}