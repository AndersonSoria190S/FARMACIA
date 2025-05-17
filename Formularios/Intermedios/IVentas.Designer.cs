namespace FARMACIA.Formularios.Intermedios
{
    partial class IVentas
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
            btnlistaventas = new FontAwesome.Sharp.IconButton();
            btnbuscarventa = new FontAwesome.Sharp.IconButton();
            btncerrar = new FontAwesome.Sharp.IconButton();
            btnnuevaventa = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnlistaventas);
            panel1.Controls.Add(btnbuscarventa);
            panel1.Controls.Add(btncerrar);
            panel1.Controls.Add(btnnuevaventa);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 260);
            panel1.TabIndex = 5;
            // 
            // btnlistaventas
            // 
            btnlistaventas.BackColor = Color.FromArgb(0, 143, 213);
            btnlistaventas.Cursor = Cursors.Hand;
            btnlistaventas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlistaventas.ForeColor = Color.White;
            btnlistaventas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnlistaventas.IconColor = Color.White;
            btnlistaventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlistaventas.IconSize = 40;
            btnlistaventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnlistaventas.Location = new Point(20, 131);
            btnlistaventas.Name = "btnlistaventas";
            btnlistaventas.Padding = new Padding(60, 3, 0, 0);
            btnlistaventas.Size = new Size(274, 50);
            btnlistaventas.TabIndex = 6;
            btnlistaventas.Text = "Lista de Ventas";
            btnlistaventas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlistaventas.UseVisualStyleBackColor = false;
            btnlistaventas.Click += btnlistaventas_Click;
            // 
            // btnbuscarventa
            // 
            btnbuscarventa.BackColor = Color.FromArgb(0, 143, 213);
            btnbuscarventa.Cursor = Cursors.Hand;
            btnbuscarventa.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscarventa.ForeColor = Color.White;
            btnbuscarventa.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarventa.IconColor = Color.White;
            btnbuscarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarventa.IconSize = 40;
            btnbuscarventa.ImageAlign = ContentAlignment.MiddleLeft;
            btnbuscarventa.Location = new Point(20, 75);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Padding = new Padding(60, 3, 0, 0);
            btnbuscarventa.Size = new Size(274, 50);
            btnbuscarventa.TabIndex = 5;
            btnbuscarventa.Text = "Buscar Venta";
            btnbuscarventa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarventa.UseVisualStyleBackColor = false;
            btnbuscarventa.Click += btnbuscarventa_Click;
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
            // btnnuevaventa
            // 
            btnnuevaventa.BackColor = Color.FromArgb(0, 143, 213);
            btnnuevaventa.Cursor = Cursors.Hand;
            btnnuevaventa.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnnuevaventa.ForeColor = Color.White;
            btnnuevaventa.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnnuevaventa.IconColor = Color.White;
            btnnuevaventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevaventa.IconSize = 40;
            btnnuevaventa.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevaventa.Location = new Point(20, 19);
            btnnuevaventa.Name = "btnnuevaventa";
            btnnuevaventa.Padding = new Padding(60, 3, 0, 0);
            btnnuevaventa.Size = new Size(274, 50);
            btnnuevaventa.TabIndex = 1;
            btnnuevaventa.Text = "Nueva Venta";
            btnnuevaventa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevaventa.UseVisualStyleBackColor = false;
            btnnuevaventa.Click += btnnuevaventa_Click;
            // 
            // IVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(342, 284);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IVentas";
            Load += IVentas_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnlistaventas;
        private FontAwesome.Sharp.IconButton btnbuscarventa;
        private FontAwesome.Sharp.IconButton btncerrar;
        private FontAwesome.Sharp.IconButton btnnuevaventa;
    }
}