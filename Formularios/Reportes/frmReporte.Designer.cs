namespace FARMACIA.Formularios.Reportes
{
    partial class frmReporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Usuarios = new Label();
            panel2 = new Panel();
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtTop = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(304, 134);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(500, 350);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(739, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 143, 213);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(Usuarios);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 57);
            panel1.TabIndex = 20;
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
            iconButton1.Location = new Point(776, 18);
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
            Usuarios.Location = new Point(12, 18);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(114, 24);
            Usuarios.TabIndex = 6;
            Usuarios.Text = "GRAFICOS";
            Usuarios.Click += Usuarios_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(treeView1);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(12, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 522);
            panel2.TabIndex = 21;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(6, 6);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(233, 513);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(245, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 13);
            groupBox1.TabIndex = 204;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(265, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 13);
            groupBox2.TabIndex = 205;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(265, 79);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 206;
            label1.Text = "*Ingrese el top a mostrar:";
            label1.Click += label1_Click;
            // 
            // txtTop
            // 
            txtTop.Location = new Point(422, 73);
            txtTop.Name = "txtTop";
            txtTop.Size = new Size(100, 23);
            txtTop.TabIndex = 207;
            txtTop.Text = "5";
            txtTop.KeyDown += txtTop_KeyDown;
            // 
            // frmReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(872, 675);
            ControlBox = false;
            Controls.Add(txtTop);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Graficos :.";
            Load += frmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ComboBox comboBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label Usuarios;
        private Panel panel2;
        private TreeView treeView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtTop;
    }
}