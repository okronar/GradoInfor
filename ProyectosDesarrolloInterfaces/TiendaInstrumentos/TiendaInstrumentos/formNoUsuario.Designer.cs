namespace TiendaInstrumentos
{
    partial class formNoUsuario
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
            dataGridViewNoUsu = new DataGridView();
            botonGuitarras = new Button();
            botonBajo = new Button();
            botonTeclados = new Button();
            botonBaterias = new Button();
            botonMicros = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNoUsu).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNoUsu
            // 
            dataGridViewNoUsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNoUsu.Location = new Point(12, 337);
            dataGridViewNoUsu.Name = "dataGridViewNoUsu";
            dataGridViewNoUsu.Size = new Size(1027, 252);
            dataGridViewNoUsu.TabIndex = 1;
            // 
            // botonGuitarras
            // 
            botonGuitarras.Location = new Point(12, 308);
            botonGuitarras.Name = "botonGuitarras";
            botonGuitarras.Size = new Size(75, 23);
            botonGuitarras.TabIndex = 2;
            botonGuitarras.Text = "Guitarras";
            botonGuitarras.UseVisualStyleBackColor = true;
            botonGuitarras.Click += botonGuitarras_Click;
            // 
            // botonBajo
            // 
            botonBajo.Location = new Point(93, 308);
            botonBajo.Name = "botonBajo";
            botonBajo.Size = new Size(75, 23);
            botonBajo.TabIndex = 3;
            botonBajo.Text = "Bajos";
            botonBajo.UseVisualStyleBackColor = true;
            botonBajo.Click += botonBajo_Click;
            // 
            // botonTeclados
            // 
            botonTeclados.Location = new Point(174, 308);
            botonTeclados.Name = "botonTeclados";
            botonTeclados.Size = new Size(75, 23);
            botonTeclados.TabIndex = 4;
            botonTeclados.Text = "Teclados";
            botonTeclados.UseVisualStyleBackColor = true;
            botonTeclados.Click += botonTeclados_Click;
            // 
            // botonBaterias
            // 
            botonBaterias.Location = new Point(255, 308);
            botonBaterias.Name = "botonBaterias";
            botonBaterias.Size = new Size(75, 23);
            botonBaterias.TabIndex = 5;
            botonBaterias.Text = "Baterías";
            botonBaterias.UseVisualStyleBackColor = true;
            botonBaterias.Click += botonBaterias_Click;
            // 
            // botonMicros
            // 
            botonMicros.Location = new Point(336, 308);
            botonMicros.Name = "botonMicros";
            botonMicros.Size = new Size(85, 23);
            botonMicros.TabIndex = 6;
            botonMicros.Text = "Micrófonos";
            botonMicros.UseVisualStyleBackColor = true;
            botonMicros.Click += botonMicros_Click;
            // 
            // formNoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 613);
            Controls.Add(botonMicros);
            Controls.Add(botonBaterias);
            Controls.Add(botonTeclados);
            Controls.Add(botonBajo);
            Controls.Add(botonGuitarras);
            Controls.Add(dataGridViewNoUsu);
            Name = "formNoUsuario";
            Text = "Visitante";
            FormClosing += formNoUsuario_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNoUsu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNoUsu;
        private Button botonGuitarras;
        private Button botonBajo;
        private Button botonTeclados;
        private Button botonBaterias;
        private Button botonMicros;
    }
}