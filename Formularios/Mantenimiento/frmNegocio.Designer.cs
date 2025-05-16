namespace FARMACIA.Formularios.Mantenimiento
{
    partial class frmNegocio
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
            Usuarios = new Label();
            groupBox1 = new GroupBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            txtdireccion = new TextBox();
            txtruc = new TextBox();
            txtrazonsocial = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            picLogo = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 43);
            panel1.TabIndex = 18;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 143, 213);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(412, 8);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(69, 31);
            iconButton1.TabIndex = 213;
            iconButton1.Text = "Salir";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.BackColor = Color.FromArgb(0, 143, 213);
            Usuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Usuarios.ForeColor = SystemColors.ButtonHighlight;
            Usuarios.Location = new Point(15, 9);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(89, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "Negocio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(btnagregarproducto);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txtruc);
            groupBox1.Controls.Add(txtrazonsocial);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(picLogo);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 214);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // iconButton2
            // 
            iconButton2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(16, 172);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(136, 28);
            iconButton2.TabIndex = 211;
            iconButton2.Text = "Subir";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnagregarproducto.IconColor = Color.Black;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnagregarproducto.IconSize = 20;
            btnagregarproducto.ImageAlign = ContentAlignment.TopCenter;
            btnagregarproducto.Location = new Point(185, 172);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(264, 28);
            btnagregarproducto.TabIndex = 210;
            btnagregarproducto.Text = "Guardar Cambios";
            btnagregarproducto.TextAlign = ContentAlignment.MiddleRight;
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(185, 134);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(264, 23);
            txtdireccion.TabIndex = 209;
            // 
            // txtruc
            // 
            txtruc.Location = new Point(185, 90);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(264, 23);
            txtruc.TabIndex = 208;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Location = new Point(185, 46);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.Size = new Size(264, 23);
            txtrazonsocial.TabIndex = 207;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 116);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 72);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "NIT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 28);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Razon Social:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Logo:";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(16, 40);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(136, 125);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(495, 275);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmNegocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Negocio :.";
            Load += frmNegocio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Usuarios;
        private GroupBox groupBox1;
        private PictureBox picLogo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtdireccion;
        private TextBox txtruc;
        private TextBox txtrazonsocial;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
    }
}