namespace HamburgueseriaQueHamburguesea
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            Panel = new Panel();
            botonAnadir = new Button();
            botonVolver = new Button();
            precio = new Label();
            nombre = new Label();
            Imagen = new PictureBox();
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Imagen).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Controls.Add(botonAnadir);
            Panel.Controls.Add(botonVolver);
            Panel.Controls.Add(precio);
            Panel.Controls.Add(nombre);
            Panel.Controls.Add(Imagen);
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(223, 399);
            Panel.TabIndex = 0;
            // 
            // botonAnadir
            // 
            botonAnadir.Location = new Point(124, 349);
            botonAnadir.Name = "botonAnadir";
            botonAnadir.Size = new Size(75, 23);
            botonAnadir.TabIndex = 4;
            botonAnadir.Text = "Añadir";
            botonAnadir.UseVisualStyleBackColor = true;
            // 
            // botonVolver
            // 
            botonVolver.Location = new Point(24, 349);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(75, 23);
            botonVolver.TabIndex = 3;
            botonVolver.Text = "Volver";
            botonVolver.UseVisualStyleBackColor = true;
            // 
            // precio
            // 
            precio.AutoSize = true;
            precio.Location = new Point(83, 199);
            precio.Name = "precio";
            precio.Size = new Size(40, 15);
            precio.TabIndex = 2;
            precio.Text = "precio";
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(83, 155);
            nombre.Name = "nombre";
            nombre.Size = new Size(49, 15);
            nombre.TabIndex = 1;
            nombre.Text = "nombre";
            nombre.Click += nombre_Click;
            // 
            // Imagen
            // 
            Imagen.Location = new Point(0, 0);
            Imagen.Name = "Imagen";
            Imagen.Size = new Size(223, 130);
            Imagen.TabIndex = 0;
            Imagen.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel);
            Name = "UserControl1";
            Size = new Size(223, 399);
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

         public Panel Panel;
         public Label precio;
         public Label nombre;
         public PictureBox Imagen;
         public Button botonAnadir;
         public Button botonVolver;
    }
}
