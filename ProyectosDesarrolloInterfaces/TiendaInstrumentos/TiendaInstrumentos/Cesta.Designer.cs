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
            components = new System.ComponentModel.Container();
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
            labelInstrucciones = new Label();
            botonMicros = new Button();
            botonBaterias = new Button();
            botonTeclados = new Button();
            botonBajo = new Button();
            botonGuitarras = new Button();
            toolTip1 = new ToolTip(components);
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
            toolTip1.SetToolTip(buttonVolver, "go back ");
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
            toolTip1.SetToolTip(buttonComprar, "BUY ");
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
            toolTip1.SetToolTip(txboxCodProdAñadir, "codigo for buying ");
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
            toolTip1.SetToolTip(buttonBorrarUltimo, "erase last product");
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
            // labelInstrucciones
            // 
            labelInstrucciones.Location = new Point(888, 569);
            labelInstrucciones.Name = "labelInstrucciones";
            labelInstrucciones.Size = new Size(353, 31);
            labelInstrucciones.TabIndex = 12;
            labelInstrucciones.Text = "Escriba el código debajo y clique en añadir para sumar al carro";
            labelInstrucciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botonMicros
            // 
            botonMicros.Location = new Point(367, 522);
            botonMicros.Name = "botonMicros";
            botonMicros.Size = new Size(85, 23);
            botonMicros.TabIndex = 17;
            botonMicros.Text = "Micrófonos";
            toolTip1.SetToolTip(botonMicros, "available mics");
            botonMicros.UseVisualStyleBackColor = true;
            botonMicros.Click += botonMicros_Click;
            // 
            // botonBaterias
            // 
            botonBaterias.Location = new Point(286, 522);
            botonBaterias.Name = "botonBaterias";
            botonBaterias.Size = new Size(75, 23);
            botonBaterias.TabIndex = 16;
            botonBaterias.Text = "Baterías";
            toolTip1.SetToolTip(botonBaterias, "available drums");
            botonBaterias.UseVisualStyleBackColor = true;
            botonBaterias.Click += botonBaterias_Click;
            // 
            // botonTeclados
            // 
            botonTeclados.Location = new Point(205, 522);
            botonTeclados.Name = "botonTeclados";
            botonTeclados.Size = new Size(75, 23);
            botonTeclados.TabIndex = 15;
            botonTeclados.Text = "Teclados";
            toolTip1.SetToolTip(botonTeclados, "available keyboards");
            botonTeclados.UseVisualStyleBackColor = true;
            botonTeclados.Click += botonTeclados_Click;
            // 
            // botonBajo
            // 
            botonBajo.Location = new Point(124, 522);
            botonBajo.Name = "botonBajo";
            botonBajo.Size = new Size(75, 23);
            botonBajo.TabIndex = 14;
            botonBajo.Text = "Bajos";
            toolTip1.SetToolTip(botonBajo, "available basses");
            botonBajo.UseVisualStyleBackColor = true;
            botonBajo.Click += botonBajo_Click;
            // 
            // botonGuitarras
            // 
            botonGuitarras.Location = new Point(43, 522);
            botonGuitarras.Name = "botonGuitarras";
            botonGuitarras.Size = new Size(75, 23);
            botonGuitarras.TabIndex = 13;
            botonGuitarras.Text = "Guitarras";
            toolTip1.SetToolTip(botonGuitarras, "available guitars");
            botonGuitarras.UseVisualStyleBackColor = true;
            botonGuitarras.Click += botonGuitarras_Click;
            // 
            // Cesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1764, 857);
            Controls.Add(botonMicros);
            Controls.Add(botonBaterias);
            Controls.Add(botonTeclados);
            Controls.Add(botonBajo);
            Controls.Add(botonGuitarras);
            Controls.Add(labelInstrucciones);
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
        private Label labelInstrucciones;
        private Button botonMicros;
        private Button botonBaterias;
        private Button botonTeclados;
        private Button botonBajo;
        private Button botonGuitarras;
        private ToolTip toolTip1;
    }
}