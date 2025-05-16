namespace FARMACIA.Formularios.Modales
{
    partial class mdCompraExistosa
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
            label9 = new Label();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtnumerodocumento = new TextBox();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(74, 20);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 204;
            label9.Text = "Compra Registrada!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 44);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 205;
            label1.Text = "Numero de Documento Generado:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.MenuHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            iconPictureBox1.IconColor = SystemColors.MenuHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 51;
            iconPictureBox1.Location = new Point(12, 31);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(54, 51);
            iconPictureBox1.TabIndex = 206;
            iconPictureBox1.TabStop = false;
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(74, 62);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.ReadOnly = true;
            txtnumerodocumento.Size = new Size(195, 23);
            txtnumerodocumento.TabIndex = 209;
            txtnumerodocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnagregarproducto.IconColor = Color.Black;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnagregarproducto.IconSize = 17;
            btnagregarproducto.ImageAlign = ContentAlignment.TopCenter;
            btnagregarproducto.Location = new Point(186, 91);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(83, 23);
            btnagregarproducto.TabIndex = 210;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextAlign = ContentAlignment.MiddleRight;
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            btnagregarproducto.Click += btnagregarproducto_Click;
            // 
            // mdCompraExistosa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(281, 124);
            ControlBox = false;
            Controls.Add(btnagregarproducto);
            Controls.Add(txtnumerodocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "mdCompraExistosa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Mensaje :.";
            Load += mdCompraExistosa_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtnumerodocumento;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
    }
}