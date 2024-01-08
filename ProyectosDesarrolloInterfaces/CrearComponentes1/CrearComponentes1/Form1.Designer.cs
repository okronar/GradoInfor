namespace CrearComponentes1
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
            components = new System.ComponentModel.Container();
            userControl11 = new UserControl1();
            superBoton1 = new SuperBoton();
            visualizadorImagenes2 = new VisualizadorImagenes(components);
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(12, 37);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(440, 270);
            userControl11.TabIndex = 0;
            // 
            // superBoton1
            // 
            superBoton1.Location = new Point(593, 98);
            superBoton1.Name = "superBoton1";
            superBoton1.Size = new Size(75, 23);
            superBoton1.TabIndex = 2;
            superBoton1.Text = "superBoton1";
            superBoton1.UseVisualStyleBackColor = true;
            // 
            // visualizadorImagenes2
            // 
            visualizadorImagenes2.Location = new Point(491, 245);
            visualizadorImagenes2.Name = "visualizadorImagenes2";
            visualizadorImagenes2.Size = new Size(200, 100);
            visualizadorImagenes2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(visualizadorImagenes2);
            Controls.Add(superBoton1);
            Controls.Add(userControl11);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl11;
        private SuperBoton superBoton1;
        private VisualizadorImagenes visualizadorImagenes2;
    }
}