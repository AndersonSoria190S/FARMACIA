namespace FARMACIA.Formularios.Proveedores
{
    partial class frmMantProveedor
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
            Usuarios = new Label();
            label2 = new Label();
            label1 = new Label();
            txtnombre = new TextBox();
            txtnumero = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            lblresultado = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 44);
            panel1.TabIndex = 17;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(57, 10);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(177, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Detalle Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 21;
            label2.Text = "Nombre Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 52);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 20;
            label1.Text = "Numero de Documento:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(19, 114);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(238, 23);
            txtnombre.TabIndex = 19;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(19, 70);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(238, 23);
            txtnumero.TabIndex = 18;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(158, 173);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(99, 21);
            iconButton1.TabIndex = 24;
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
            btnguardar.Location = new Point(19, 173);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(99, 21);
            btnguardar.TabIndex = 23;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(19, 140);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 15);
            lblresultado.TabIndex = 25;
            // 
            // frmMantProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(277, 206);
            ControlBox = false;
            Controls.Add(lblresultado);
            Controls.Add(iconButton1);
            Controls.Add(btnguardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnombre);
            Controls.Add(txtnumero);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMantProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = ".: Detalle Proveedor :.";
            Load += frmMantProveedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Usuarios;
        private Label Rol;
        private Label label2;
        private Label label1;
        private TextBox txtnombre;
        private TextBox txtnumero;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label lblresultado;
    }
}