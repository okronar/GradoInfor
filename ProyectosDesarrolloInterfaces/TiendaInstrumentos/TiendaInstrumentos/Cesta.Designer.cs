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
            labelProducto = new Label();
            labelCodigo = new Label();
            labelResultado = new Label();
            buttonVolver = new Button();
            SuspendLayout();
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Location = new Point(46, 27);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(59, 15);
            labelProducto.TabIndex = 0;
            labelProducto.Text = "Producto:";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(50, 78);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(52, 15);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo :";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(185, 27);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 3;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(787, 457);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(75, 23);
            buttonVolver.TabIndex = 4;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // Cesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 492);
            Controls.Add(buttonVolver);
            Controls.Add(labelResultado);
            Controls.Add(labelCodigo);
            Controls.Add(labelProducto);
            Name = "Cesta";
            Text = "Cesta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProducto;
        private Label labelCodigo;
        private Label labelResultado;
        private Button buttonVolver;
    }
}