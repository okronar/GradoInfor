namespace Informes
{
    partial class Form1
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
            botonConectar = new Button();
            botonInforme = new Button();
            dgv_DB = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_DB).BeginInit();
            SuspendLayout();
            // 
            // botonConectar
            // 
            botonConectar.Location = new Point(28, 12);
            botonConectar.Name = "botonConectar";
            botonConectar.Size = new Size(75, 23);
            botonConectar.TabIndex = 0;
            botonConectar.Text = "Conectar";
            botonConectar.UseVisualStyleBackColor = true;
            botonConectar.Click += botonConectar_Click;
            // 
            // botonInforme
            // 
            botonInforme.Location = new Point(713, 415);
            botonInforme.Name = "botonInforme";
            botonInforme.Size = new Size(75, 23);
            botonInforme.TabIndex = 1;
            botonInforme.Text = "Informe";
            botonInforme.UseVisualStyleBackColor = true;
            botonInforme.Click += botonInforme_Click;
            // 
            // dgv_DB
            // 
            dgv_DB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DB.Location = new Point(28, 41);
            dgv_DB.Name = "dgv_DB";
            dgv_DB.Size = new Size(760, 357);
            dgv_DB.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_DB);
            Controls.Add(botonInforme);
            Controls.Add(botonConectar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_DB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botonConectar;
        private Button botonInforme;
        private DataGridView dgv_DB;
    }
}
