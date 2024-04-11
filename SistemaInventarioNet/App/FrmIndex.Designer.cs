namespace SistemaInventarioNet
{
    partial class FrmIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btncerrarsesion = new Button();
            btnConfiguracion = new Button();
            btnReportes = new Button();
            btnBodega = new Button();
            btnInventario = new Button();
            btnProducto = new Button();
            btnDashboard = new Button();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btncerrar = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 58, 71);
            panel1.Controls.Add(btncerrarsesion);
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnBodega);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 568);
            panel1.TabIndex = 0;
            // 
            // btncerrarsesion
            // 
            btncerrarsesion.Dock = DockStyle.Bottom;
            btncerrarsesion.FlatAppearance.BorderSize = 0;
            btncerrarsesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btncerrarsesion.FlatStyle = FlatStyle.Flat;
            btncerrarsesion.ForeColor = Color.White;
            btncerrarsesion.Image = Properties.Resources.logout_16;
            btncerrarsesion.ImageAlign = ContentAlignment.MiddleLeft;
            btncerrarsesion.Location = new Point(0, 542);
            btncerrarsesion.Name = "btncerrarsesion";
            btncerrarsesion.Size = new Size(200, 26);
            btncerrarsesion.TabIndex = 9;
            btncerrarsesion.Text = "Salir";
            btncerrarsesion.UseVisualStyleBackColor = true;
            btncerrarsesion.Click += btncerrarsesion_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.Image = Properties.Resources.settings_16;
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 269);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(200, 26);
            btnConfiguracion.TabIndex = 8;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = Properties.Resources.printing_16;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 243);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(200, 26);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnBodega
            // 
            btnBodega.Dock = DockStyle.Top;
            btnBodega.FlatAppearance.BorderSize = 0;
            btnBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnBodega.FlatStyle = FlatStyle.Flat;
            btnBodega.ForeColor = Color.White;
            btnBodega.Image = Properties.Resources.stock_16;
            btnBodega.ImageAlign = ContentAlignment.MiddleLeft;
            btnBodega.Location = new Point(0, 217);
            btnBodega.Name = "btnBodega";
            btnBodega.Size = new Size(200, 26);
            btnBodega.TabIndex = 6;
            btnBodega.Text = "bodega";
            btnBodega.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = Properties.Resources.pie_chart_16;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 191);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(200, 26);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.ForeColor = Color.White;
            btnProducto.Image = Properties.Resources.product_16;
            btnProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducto.Location = new Point(0, 165);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(200, 26);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 33, 79);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard_16;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 139);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 26);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.c_sharp;
            pictureBox1.Location = new Point(53, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(109, 33, 79);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 39);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(179, 55, 113);
            panel3.Controls.Add(btncerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(844, 39);
            panel3.TabIndex = 1;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            // 
            // btncerrar
            // 
            btncerrar.Dock = DockStyle.Right;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncerrar.ForeColor = Color.White;
            btncerrar.Location = new Point(803, 0);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(41, 39);
            btncerrar.TabIndex = 0;
            btncerrar.Text = "X";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(844, 529);
            panel4.TabIndex = 2;
            // 
            // FrmIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 568);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmIndex";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btncerrar;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button btnDashboard;
        private Button btnConfiguracion;
        private Button btnReportes;
        private Button btnBodega;
        private Button btnInventario;
        private Button btnProducto;
        private Button btncerrarsesion;
    }
}
