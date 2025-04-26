namespace FARMACIA.Formularios.Intermedios
{
    partial class IProductos
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
            btncargamasiva = new FontAwesome.Sharp.IconButton();
            btnnuevacompra = new FontAwesome.Sharp.IconButton();
            btngenerarbarras = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btngenerarbarras);
            panel1.Controls.Add(btncargamasiva);
            panel1.Controls.Add(btnnuevacompra);
            panel1.Location = new Point(9, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 296);
            panel1.TabIndex = 0;
            // 
            // btncargamasiva
            // 
            btncargamasiva.BackColor = Color.FromArgb(0, 143, 213);
            btncargamasiva.Cursor = Cursors.Hand;
            btncargamasiva.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncargamasiva.ForeColor = Color.White;
            btncargamasiva.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btncargamasiva.IconColor = Color.White;
            btncargamasiva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncargamasiva.ImageAlign = ContentAlignment.MiddleLeft;
            btncargamasiva.Location = new Point(21, 87);
            btncargamasiva.Name = "btncargamasiva";
            btncargamasiva.Padding = new Padding(60, 3, 0, 0);
            btncargamasiva.Size = new Size(262, 55);
            btncargamasiva.TabIndex = 3;
            btncargamasiva.Text = "Carga Masiva";
            btncargamasiva.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncargamasiva.UseVisualStyleBackColor = false;
            btncargamasiva.Click += iconButton1_Click;
            // 
            // btnnuevacompra
            // 
            btnnuevacompra.BackColor = Color.FromArgb(0, 143, 213);
            btnnuevacompra.Cursor = Cursors.Hand;
            btnnuevacompra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnnuevacompra.ForeColor = Color.White;
            btnnuevacompra.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnnuevacompra.IconColor = Color.White;
            btnnuevacompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevacompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevacompra.Location = new Point(21, 26);
            btnnuevacompra.Name = "btnnuevacompra";
            btnnuevacompra.Padding = new Padding(60, 3, 0, 0);
            btnnuevacompra.Size = new Size(262, 55);
            btnnuevacompra.TabIndex = 2;
            btnnuevacompra.Text = "Nuevo Producto";
            btnnuevacompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevacompra.UseVisualStyleBackColor = false;
            btnnuevacompra.Click += btnnuevacompra_Click;
            // 
            // btngenerarbarras
            // 
            btngenerarbarras.BackColor = Color.FromArgb(0, 143, 213);
            btngenerarbarras.Cursor = Cursors.Hand;
            btngenerarbarras.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btngenerarbarras.ForeColor = Color.White;
            btngenerarbarras.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            btngenerarbarras.IconColor = Color.White;
            btngenerarbarras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btngenerarbarras.ImageAlign = ContentAlignment.MiddleLeft;
            btngenerarbarras.Location = new Point(21, 148);
            btngenerarbarras.Name = "btngenerarbarras";
            btngenerarbarras.Padding = new Padding(60, 3, 0, 0);
            btngenerarbarras.Size = new Size(262, 55);
            btngenerarbarras.TabIndex = 4;
            btngenerarbarras.Text = "Generar Barras";
            btngenerarbarras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btngenerarbarras.UseVisualStyleBackColor = false;
            // 
            // IProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(323, 313);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IProductos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnnuevacompra;
        private FontAwesome.Sharp.IconButton btncargamasiva;
        private FontAwesome.Sharp.IconButton btngenerarbarras;
    }
}