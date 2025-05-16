namespace FARMACIA.Formularios.Intermedios
{
    partial class ICompras
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
            btnlistacompra = new FontAwesome.Sharp.IconButton();
            btnbuscarcompra = new FontAwesome.Sharp.IconButton();
            btncerrar = new FontAwesome.Sharp.IconButton();
            btnnuevacompra = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnlistacompra);
            panel1.Controls.Add(btnbuscarcompra);
            panel1.Controls.Add(btncerrar);
            panel1.Controls.Add(btnnuevacompra);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 260);
            panel1.TabIndex = 4;
            // 
            // btnlistacompra
            // 
            btnlistacompra.BackColor = Color.FromArgb(0, 143, 213);
            btnlistacompra.Cursor = Cursors.Hand;
            btnlistacompra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlistacompra.ForeColor = Color.White;
            btnlistacompra.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnlistacompra.IconColor = Color.White;
            btnlistacompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlistacompra.IconSize = 40;
            btnlistacompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnlistacompra.Location = new Point(20, 131);
            btnlistacompra.Name = "btnlistacompra";
            btnlistacompra.Padding = new Padding(60, 3, 0, 0);
            btnlistacompra.Size = new Size(274, 50);
            btnlistacompra.TabIndex = 6;
            btnlistacompra.Text = "Lista de Compras";
            btnlistacompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlistacompra.UseVisualStyleBackColor = false;
            btnlistacompra.Click += btnlistacompra_Click;
            // 
            // btnbuscarcompra
            // 
            btnbuscarcompra.BackColor = Color.FromArgb(0, 143, 213);
            btnbuscarcompra.Cursor = Cursors.Hand;
            btnbuscarcompra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscarcompra.ForeColor = Color.White;
            btnbuscarcompra.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarcompra.IconColor = Color.White;
            btnbuscarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarcompra.IconSize = 40;
            btnbuscarcompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnbuscarcompra.Location = new Point(20, 75);
            btnbuscarcompra.Name = "btnbuscarcompra";
            btnbuscarcompra.Padding = new Padding(60, 3, 0, 0);
            btnbuscarcompra.Size = new Size(274, 50);
            btnbuscarcompra.TabIndex = 5;
            btnbuscarcompra.Text = "Buscar Compra";
            btnbuscarcompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarcompra.UseVisualStyleBackColor = false;
            btnbuscarcompra.Click += btnbuscarcompra_Click;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.FromArgb(0, 143, 213);
            btncerrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncerrar.ForeColor = Color.White;
            btncerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btncerrar.IconColor = Color.White;
            btncerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btncerrar.IconSize = 40;
            btncerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btncerrar.Location = new Point(20, 187);
            btncerrar.Name = "btncerrar";
            btncerrar.Padding = new Padding(60, 3, 0, 0);
            btncerrar.Size = new Size(274, 50);
            btncerrar.TabIndex = 3;
            btncerrar.Text = "Cerrar";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
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
            btnnuevacompra.IconSize = 40;
            btnnuevacompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevacompra.Location = new Point(20, 19);
            btnnuevacompra.Name = "btnnuevacompra";
            btnnuevacompra.Padding = new Padding(60, 3, 0, 0);
            btnnuevacompra.Size = new Size(274, 50);
            btnnuevacompra.TabIndex = 1;
            btnnuevacompra.Text = "Nueva Compra";
            btnnuevacompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevacompra.UseVisualStyleBackColor = false;
            btnnuevacompra.Click += btnnuevacompra_Click;
            // 
            // ICompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(342, 284);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ICompras";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ICompras";
            Load += ICompras_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btncerrar;
        private FontAwesome.Sharp.IconButton btnnuevacompra;
        private FontAwesome.Sharp.IconButton btnlistacompra;
        private FontAwesome.Sharp.IconButton btnbuscarcompra;
    }
}