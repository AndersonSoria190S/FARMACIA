namespace FARMACIA.Formularios.Mantenimiento
{
    partial class frmMantUsuario
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
            txtusuario = new TextBox();
            txtnombre = new TextBox();
            txtconfirmarclave = new TextBox();
            txtclave = new TextBox();
            cborol = new ComboBox();
            panel1 = new Panel();
            Usuarios = new Label();
            btnguardar = new FontAwesome.Sharp.IconButton();
            lblresultado = new Label();
            label1 = new Label();
            label2 = new Label();
            Rol = new Label();
            label3 = new Label();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(12, 75);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(238, 21);
            txtusuario.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(12, 119);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(238, 21);
            txtnombre.TabIndex = 1;
            // 
            // txtconfirmarclave
            // 
            txtconfirmarclave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtconfirmarclave.Location = new Point(12, 251);
            txtconfirmarclave.Name = "txtconfirmarclave";
            txtconfirmarclave.Size = new Size(238, 21);
            txtconfirmarclave.TabIndex = 2;
            // 
            // txtclave
            // 
            txtclave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtclave.Location = new Point(12, 207);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(238, 21);
            txtclave.TabIndex = 3;
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(12, 163);
            cborol.Name = "cborol";
            cborol.Size = new Size(238, 23);
            cborol.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 40);
            panel1.TabIndex = 5;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(66, 9);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(151, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Detalle Usuario";
            Usuarios.Click += Usuarios_Click;
            // 
            // btnguardar
            // 
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnguardar.IconSize = 17;
            btnguardar.ImageAlign = ContentAlignment.TopCenter;
            btnguardar.Location = new Point(12, 311);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(99, 21);
            btnguardar.TabIndex = 6;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblresultado.Location = new Point(12, 283);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(63, 15);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre Completo:";
            label2.Click += label2_Click;
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Rol.Location = new Point(12, 145);
            Rol.Name = "Rol";
            Rol.Size = new Size(32, 15);
            Rol.TabIndex = 10;
            Rol.Text = "Rol: ";
            Rol.Click += Rol_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 189);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 11;
            label3.Text = "Contraseña: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 233);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 12;
            label4.Text = " Confirmar Contraseña: ";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(151, 311);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(99, 21);
            iconButton1.TabIndex = 13;
            iconButton1.Text = "Cerrar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmMantUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(265, 344);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Rol);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblresultado);
            Controls.Add(btnguardar);
            Controls.Add(panel1);
            Controls.Add(cborol);
            Controls.Add(txtclave);
            Controls.Add(txtconfirmarclave);
            Controls.Add(txtnombre);
            Controls.Add(txtusuario);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmMantUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Detalle Usuario :.";
            Load += frmMantUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusuario;
        private TextBox txtnombre;
        private TextBox txtconfirmarclave;
        private TextBox txtclave;
        private ComboBox cborol;
        private Panel panel1;
        private Label Usuarios;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label lblresultado;
        private Label label1;
        private Label label2;
        private Label Rol;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}