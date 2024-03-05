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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNoUsuario));
            dataGridViewNoUsu = new DataGridView();
            botonGuitarras = new Button();
            botonBajo = new Button();
            botonTeclados = new Button();
            botonBaterias = new Button();
            botonMicros = new Button();
            picBox1 = new PictureBox();
            buttonVolver = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNoUsu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNoUsu
            // 
            dataGridViewNoUsu.AllowUserToAddRows = false;
            dataGridViewNoUsu.AllowUserToDeleteRows = false;
            dataGridViewNoUsu.AllowUserToResizeColumns = false;
            dataGridViewNoUsu.AllowUserToResizeRows = false;
            dataGridViewNoUsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNoUsu.Location = new Point(12, 337);
            dataGridViewNoUsu.Name = "dataGridViewNoUsu";
            dataGridViewNoUsu.ReadOnly = true;
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
            // picBox1
            // 
            picBox1.Image = (Image)resources.GetObject("picBox1.Image");
            picBox1.Location = new Point(12, 3);
            picBox1.Name = "picBox1";
            picBox1.Size = new Size(1049, 299);
            picBox1.TabIndex = 7;
            picBox1.TabStop = false;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(886, 310);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(153, 23);
            buttonVolver.TabIndex = 8;
            buttonVolver.Text = "Volver";
            toolTip1.SetToolTip(buttonVolver, "go back");
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // formNoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 613);
            Controls.Add(buttonVolver);
            Controls.Add(picBox1);
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
            ((System.ComponentModel.ISupportInitialize)picBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNoUsu;
        private Button botonGuitarras;
        private Button botonBajo;
        private Button botonTeclados;
        private Button botonBaterias;
        private Button botonMicros;
        private PictureBox picBox1;
        private Button buttonVolver;
        private ToolTip toolTip1;
    }
}