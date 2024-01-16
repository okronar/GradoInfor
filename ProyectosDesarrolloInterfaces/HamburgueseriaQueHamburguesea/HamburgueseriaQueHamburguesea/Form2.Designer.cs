namespace HamburgueseriaQueHamburguesea
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            instrucciones = new Label();
            botonBurguer = new Button();
            botonBebida = new Button();
            botonPatacas = new Button();
            botonCesta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(0, -2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(641, 564);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(101, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(439, 96);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // instrucciones
            // 
            instrucciones.AutoSize = true;
            instrucciones.BackColor = SystemColors.ButtonHighlight;
            instrucciones.FlatStyle = FlatStyle.Flat;
            instrucciones.Location = new Point(247, 97);
            instrucciones.Name = "instrucciones";
            instrucciones.Size = new Size(147, 15);
            instrucciones.TabIndex = 8;
            instrucciones.Text = "Clica para añadir producto";
            // 
            // botonBurguer
            // 
            botonBurguer.BackgroundImage = (Image)resources.GetObject("botonBurguer.BackgroundImage");
            botonBurguer.ForeColor = SystemColors.Window;
            botonBurguer.Location = new Point(273, 252);
            botonBurguer.Name = "botonBurguer";
            botonBurguer.Size = new Size(121, 32);
            botonBurguer.TabIndex = 9;
            botonBurguer.Text = "Hamburguesa";
            botonBurguer.UseVisualStyleBackColor = true;
            botonBurguer.Click += botonBurguer_Click;
            // 
            // botonBebida
            // 
            botonBebida.BackgroundImage = (Image)resources.GetObject("botonBebida.BackgroundImage");
            botonBebida.ForeColor = SystemColors.ButtonFace;
            botonBebida.Location = new Point(0, 252);
            botonBebida.Name = "botonBebida";
            botonBebida.Size = new Size(109, 32);
            botonBebida.TabIndex = 10;
            botonBebida.Text = "Bebida";
            botonBebida.UseVisualStyleBackColor = true;
            botonBebida.Click += botonBebida_Click;
            // 
            // botonPatacas
            // 
            botonPatacas.BackgroundImage = (Image)resources.GetObject("botonPatacas.BackgroundImage");
            botonPatacas.ForeColor = SystemColors.ControlLightLight;
            botonPatacas.Location = new Point(517, 252);
            botonPatacas.Name = "botonPatacas";
            botonPatacas.Size = new Size(124, 32);
            botonPatacas.TabIndex = 11;
            botonPatacas.Text = "Patacas";
            botonPatacas.UseVisualStyleBackColor = true;
            botonPatacas.Click += botonPatacas_Click;
            // 
            // botonCesta
            // 
            botonCesta.BackgroundImage = (Image)resources.GetObject("botonCesta.BackgroundImage");
            botonCesta.ForeColor = SystemColors.ControlLight;
            botonCesta.Location = new Point(247, 470);
            botonCesta.Name = "botonCesta";
            botonCesta.Size = new Size(170, 27);
            botonCesta.TabIndex = 12;
            botonCesta.Text = "Cestaca";
            botonCesta.UseVisualStyleBackColor = true;
            botonCesta.Click += botonCesta_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(639, 563);
            Controls.Add(botonCesta);
            Controls.Add(botonPatacas);
            Controls.Add(botonBebida);
            Controls.Add(botonBurguer);
            Controls.Add(instrucciones);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Name = "Form2";
            Text = "Form2";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label instrucciones;
        private Button botonBurguer;
        private Button botonBebida;
        private Button botonPatacas;
        private Button botonCesta;
    }
}