namespace FARMACIA.Formularios.Clientes
{
    partial class frmMantCliente
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
            lblresultado = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            txtnombre = new TextBox();
            txtnumero = new TextBox();
            panel1 = new Panel();
            Usuarios = new Label();
            lblresultado1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(21, 147);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 15);
            lblresultado.TabIndex = 33;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(166, 173);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(99, 21);
            iconButton1.TabIndex = 32;
            iconButton1.Text = "Cerrar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnguardar
            // 
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnguardar.IconSize = 17;
            btnguardar.ImageAlign = ContentAlignment.TopCenter;
            btnguardar.Location = new Point(12, 173);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(99, 21);
            btnguardar.TabIndex = 31;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 30;
            label2.Text = "Nombre Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 29;
            label1.Text = "Numero de Documento:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(12, 121);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(253, 23);
            txtnombre.TabIndex = 28;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(12, 77);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(253, 23);
            txtnumero.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 48);
            panel1.TabIndex = 26;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(67, 11);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(145, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Detalle Cliente";
            // 
            // lblresultado1
            // 
            lblresultado1.AutoSize = true;
            lblresultado1.Location = new Point(12, 151);
            lblresultado1.Name = "lblresultado1";
            lblresultado1.Size = new Size(38, 15);
            lblresultado1.TabIndex = 34;
            lblresultado1.Text = "label3";
            // 
            // frmMantCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(277, 206);
            ControlBox = false;
            Controls.Add(lblresultado1);
            Controls.Add(lblresultado);
            Controls.Add(iconButton1);
            Controls.Add(btnguardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnombre);
            Controls.Add(txtnumero);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMantCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Detalle Cliente :.";
            Load += frmMantCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblresultado;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label2;
        private Label label1;
        private TextBox txtnombre;
        private TextBox txtnumero;
        private Panel panel1;
        private Label Usuarios;
        private Label lblresultado1;
    }
}