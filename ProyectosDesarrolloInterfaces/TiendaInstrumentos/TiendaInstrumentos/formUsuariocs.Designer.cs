namespace TiendaInstrumentos
{
    partial class formUsuariocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuariocs));
            botonMicros = new Button();
            botonBaterias = new Button();
            botonTeclados = new Button();
            botonBajo = new Button();
            botonGuitarras = new Button();
            dataGridViewUsu = new DataGridView();
            botonCesta = new Button();
            picbox2 = new PictureBox();
            buttonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox2).BeginInit();
            SuspendLayout();
            // 
            // botonMicros
            // 
            botonMicros.Location = new Point(336, 331);
            botonMicros.Name = "botonMicros";
            botonMicros.Size = new Size(85, 23);
            botonMicros.TabIndex = 12;
            botonMicros.Text = "Micrófonos";
            botonMicros.UseVisualStyleBackColor = true;
            botonMicros.Click += botonMicros_Click;
            // 
            // botonBaterias
            // 
            botonBaterias.Location = new Point(255, 331);
            botonBaterias.Name = "botonBaterias";
            botonBaterias.Size = new Size(75, 23);
            botonBaterias.TabIndex = 11;
            botonBaterias.Text = "Baterías";
            botonBaterias.UseVisualStyleBackColor = true;
            botonBaterias.Click += botonBaterias_Click;
            // 
            // botonTeclados
            // 
            botonTeclados.Location = new Point(174, 331);
            botonTeclados.Name = "botonTeclados";
            botonTeclados.Size = new Size(75, 23);
            botonTeclados.TabIndex = 10;
            botonTeclados.Text = "Teclados";
            botonTeclados.UseVisualStyleBackColor = true;
            botonTeclados.Click += botonTeclados_Click;
            // 
            // botonBajo
            // 
            botonBajo.Location = new Point(93, 331);
            botonBajo.Name = "botonBajo";
            botonBajo.Size = new Size(75, 23);
            botonBajo.TabIndex = 9;
            botonBajo.Text = "Bajos";
            botonBajo.UseVisualStyleBackColor = true;
            botonBajo.Click += botonBajo_Click;
            // 
            // botonGuitarras
            // 
            botonGuitarras.Location = new Point(12, 331);
            botonGuitarras.Name = "botonGuitarras";
            botonGuitarras.Size = new Size(75, 23);
            botonGuitarras.TabIndex = 8;
            botonGuitarras.Text = "Guitarras";
            botonGuitarras.UseVisualStyleBackColor = true;
            botonGuitarras.Click += botonGuitarras_Click;
            // 
            // dataGridViewUsu
            // 
            dataGridViewUsu.AllowUserToAddRows = false;
            dataGridViewUsu.AllowUserToDeleteRows = false;
            dataGridViewUsu.AllowUserToResizeColumns = false;
            dataGridViewUsu.AllowUserToResizeRows = false;
            dataGridViewUsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsu.Location = new Point(12, 360);
            dataGridViewUsu.Name = "dataGridViewUsu";
            dataGridViewUsu.ReadOnly = true;
            dataGridViewUsu.Size = new Size(1027, 252);
            dataGridViewUsu.TabIndex = 7;
            // 
            // botonCesta
            // 
            botonCesta.Location = new Point(889, 316);
            botonCesta.Name = "botonCesta";
            botonCesta.Size = new Size(150, 38);
            botonCesta.TabIndex = 13;
            botonCesta.Text = "Cesta";
            botonCesta.UseVisualStyleBackColor = true;
            botonCesta.Click += botonCesta_Click;
            // 
            // picbox2
            // 
            picbox2.BackgroundImage = (Image)resources.GetObject("picbox2.BackgroundImage");
            picbox2.Location = new Point(0, 0);
            picbox2.Name = "picbox2";
            picbox2.Size = new Size(1092, 310);
            picbox2.TabIndex = 14;
            picbox2.TabStop = false;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(570, 316);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(156, 38);
            buttonVolver.TabIndex = 15;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // formUsuariocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 629);
            Controls.Add(buttonVolver);
            Controls.Add(picbox2);
            Controls.Add(botonCesta);
            Controls.Add(botonMicros);
            Controls.Add(botonBaterias);
            Controls.Add(botonTeclados);
            Controls.Add(botonBajo);
            Controls.Add(botonGuitarras);
            Controls.Add(dataGridViewUsu);
            Name = "formUsuariocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            FormClosing += formUsuariocs_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botonMicros;
        private Button botonBaterias;
        private Button botonTeclados;
        private Button botonBajo;
        private Button botonGuitarras;
        private DataGridView dataGridViewUsu;
        private Button botonCesta;
        private PictureBox picbox2;
        private Button buttonVolver;
    }
}