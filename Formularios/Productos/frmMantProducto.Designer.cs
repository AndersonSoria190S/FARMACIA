namespace FARMACIA.Formularios.Productos
{
    partial class frmMantProducto
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
            txtcodigo = new TextBox();
            txtproducto = new TextBox();
            txtmedida = new TextBox();
            txtcategoria = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            Usuarios = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblresultado = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(19, 77);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(238, 23);
            txtcodigo.TabIndex = 0;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(19, 121);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(238, 23);
            txtproducto.TabIndex = 1;
            // 
            // txtmedida
            // 
            txtmedida.Location = new Point(19, 209);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(238, 23);
            txtmedida.TabIndex = 2;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(19, 165);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(238, 23);
            txtcategoria.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(158, 261);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(99, 21);
            iconButton1.TabIndex = 15;
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
            btnguardar.Location = new Point(19, 261);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(99, 21);
            btnguardar.TabIndex = 14;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 43);
            panel1.TabIndex = 16;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(62, 9);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(164, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Detalle Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 17;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 103);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 18;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 147);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 19;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 191);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 20;
            label4.Text = "Medida:";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(20, 235);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(69, 15);
            lblresultado.TabIndex = 21;
            lblresultado.Text = "lblresultado";
            // 
            // frmMantProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(276, 294);
            ControlBox = false;
            Controls.Add(lblresultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(iconButton1);
            Controls.Add(btnguardar);
            Controls.Add(txtcategoria);
            Controls.Add(txtmedida);
            Controls.Add(txtproducto);
            Controls.Add(txtcodigo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMantProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = ".: Detalle Producto :.";
            Load += frmMantProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcodigo;
        private TextBox txtproducto;
        private TextBox txtmedida;
        private TextBox txtcategoria;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Panel panel1;
        private Label Usuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblresultado;
    }
}