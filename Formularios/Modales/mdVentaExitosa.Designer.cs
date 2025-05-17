namespace FARMACIA.Formularios.Modales
{
    partial class mdVentaExitosa
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
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            txtnumerodocumento = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnagregarproducto.IconColor = Color.Black;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnagregarproducto.IconSize = 17;
            btnagregarproducto.ImageAlign = ContentAlignment.TopCenter;
            btnagregarproducto.Location = new Point(191, 100);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(83, 23);
            btnagregarproducto.TabIndex = 215;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextAlign = ContentAlignment.MiddleRight;
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(79, 71);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.ReadOnly = true;
            txtnumerodocumento.Size = new Size(195, 23);
            txtnumerodocumento.TabIndex = 214;
            txtnumerodocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.MenuHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            iconPictureBox1.IconColor = SystemColors.MenuHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 51;
            iconPictureBox1.Location = new Point(17, 40);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(54, 51);
            iconPictureBox1.TabIndex = 213;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 53);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 212;
            label1.Text = "Numero de Documento Generado:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(79, 29);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 211;
            label9.Text = "Compra Registrada!";
            // 
            // mdVentaExitosa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnagregarproducto);
            Controls.Add(txtnumerodocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Controls.Add(label9);
            Name = "mdVentaExitosa";
            Text = "mdVentaExitosa";
            Load += mdVentaExitosa_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private TextBox txtnumerodocumento;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label9;
    }
}