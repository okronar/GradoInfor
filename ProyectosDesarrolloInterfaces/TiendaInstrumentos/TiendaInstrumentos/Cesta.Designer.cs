namespace TiendaInstrumentos
{
    partial class Cesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cesta));
            labelCodigo = new Label();
            buttonVolver = new Button();
            buttonAñadir = new Button();
            buttonComprar = new Button();
            labelCarro = new Label();
            txboxCodProdAñadir = new TextBox();
            dataGridProductosDisp = new DataGridView();
            buttonBorrarUltimo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridProductosDisp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelCodigo
            // 
            labelCodigo.Location = new Point(838, 625);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(112, 35);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo :";
            labelCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(1559, 793);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(176, 40);
            buttonVolver.TabIndex = 4;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonAñadir
            // 
            buttonAñadir.Location = new Point(1006, 669);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(161, 63);
            buttonAñadir.TabIndex = 5;
            buttonAñadir.Text = "Añadir";
            buttonAñadir.UseVisualStyleBackColor = true;
            buttonAñadir.Click += buttonAñadir_Click;
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(1350, 793);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(177, 40);
            buttonComprar.TabIndex = 6;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // labelCarro
            // 
            labelCarro.Location = new Point(1350, 112);
            labelCarro.Name = "labelCarro";
            labelCarro.Size = new Size(385, 576);
            labelCarro.TabIndex = 7;
            // 
            // txboxCodProdAñadir
            // 
            txboxCodProdAñadir.Location = new Point(975, 632);
            txboxCodProdAñadir.Name = "txboxCodProdAñadir";
            txboxCodProdAñadir.Size = new Size(243, 23);
            txboxCodProdAñadir.TabIndex = 8;
            txboxCodProdAñadir.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridProductosDisp
            // 
            dataGridProductosDisp.AllowUserToAddRows = false;
            dataGridProductosDisp.AllowUserToDeleteRows = false;
            dataGridProductosDisp.AllowUserToResizeColumns = false;
            dataGridProductosDisp.AllowUserToResizeRows = false;
            dataGridProductosDisp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductosDisp.Location = new Point(41, 551);
            dataGridProductosDisp.Name = "dataGridProductosDisp";
            dataGridProductosDisp.ReadOnly = true;
            dataGridProductosDisp.Size = new Size(647, 270);
            dataGridProductosDisp.TabIndex = 9;
            // 
            // buttonBorrarUltimo
            // 
            buttonBorrarUltimo.Location = new Point(1445, 710);
            buttonBorrarUltimo.Name = "buttonBorrarUltimo";
            buttonBorrarUltimo.Size = new Size(188, 40);
            buttonBorrarUltimo.TabIndex = 10;
            buttonBorrarUltimo.Text = "Borrar último";
            buttonBorrarUltimo.UseVisualStyleBackColor = true;
            buttonBorrarUltimo.Click += buttonBorrarUltimo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1350, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 65);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Cesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1764, 857);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBorrarUltimo);
            Controls.Add(dataGridProductosDisp);
            Controls.Add(txboxCodProdAñadir);
            Controls.Add(labelCarro);
            Controls.Add(buttonComprar);
            Controls.Add(buttonAñadir);
            Controls.Add(buttonVolver);
            Controls.Add(labelCodigo);
            Name = "Cesta";
            Text = "Cesta";
            FormClosing += Cesta_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridProductosDisp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCodigo;
        private Button buttonVolver;
        private Button buttonAñadir;
        private Button buttonComprar;
        private Label labelCarro;
        private TextBox txboxCodProdAñadir;
        private DataGridView dataGridProductosDisp;
        private Button buttonBorrarUltimo;
        private PictureBox pictureBox1;
    }
}