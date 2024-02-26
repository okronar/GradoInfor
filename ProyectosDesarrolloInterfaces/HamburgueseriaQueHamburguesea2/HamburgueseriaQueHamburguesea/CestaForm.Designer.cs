namespace HamburgueseriaQueHamburguesea
{
    partial class CestaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CestaForm));
            pictureBox1 = new PictureBox();
            botonVolverCesta = new Button();
            botonPagarCesta = new Button();
            pictureBox2 = new PictureBox();
            LabelPedido = new Label();
            labelAnotaciones = new Label();
            buttonUlt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-7, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 718);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // botonVolverCesta
            // 
            botonVolverCesta.Location = new Point(530, 405);
            botonVolverCesta.Name = "botonVolverCesta";
            botonVolverCesta.Size = new Size(122, 23);
            botonVolverCesta.TabIndex = 1;
            botonVolverCesta.Text = "Volver";
            botonVolverCesta.UseVisualStyleBackColor = true;
            botonVolverCesta.Click += botonVolverCesta_Click;
            // 
            // botonPagarCesta
            // 
            botonPagarCesta.Location = new Point(668, 405);
            botonPagarCesta.Name = "botonPagarCesta";
            botonPagarCesta.Size = new Size(120, 23);
            botonPagarCesta.TabIndex = 2;
            botonPagarCesta.Text = "Pagar";
            botonPagarCesta.UseVisualStyleBackColor = true;
            botonPagarCesta.Click += botonPagarCesta_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // LabelPedido
            // 
            LabelPedido.Location = new Point(509, -2);
            LabelPedido.Name = "LabelPedido";
            LabelPedido.Size = new Size(294, 234);
            LabelPedido.TabIndex = 3;
            LabelPedido.Text = "Pedido";
            // 
            // labelAnotaciones
            // 
            labelAnotaciones.Location = new Point(509, 253);
            labelAnotaciones.Name = "labelAnotaciones";
            labelAnotaciones.Size = new Size(294, 110);
            labelAnotaciones.TabIndex = 6;
            labelAnotaciones.Text = "Anotaciones";
            // 
            // buttonUlt
            // 
            buttonUlt.Location = new Point(203, 362);
            buttonUlt.Name = "buttonUlt";
            buttonUlt.Size = new Size(122, 23);
            buttonUlt.TabIndex = 7;
            buttonUlt.Text = "Ultimo pedido";
            buttonUlt.UseMnemonic = false;
            buttonUlt.UseVisualStyleBackColor = true;
            buttonUlt.Click += buttonUlt_Click;
            // 
            // CestaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUlt);
            Controls.Add(labelAnotaciones);
            Controls.Add(LabelPedido);
            Controls.Add(pictureBox2);
            Controls.Add(botonPagarCesta);
            Controls.Add(botonVolverCesta);
            Controls.Add(pictureBox1);
            Name = "CestaForm";
            Text = "Pedido";
            FormClosing += CestaForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button botonVolverCesta;
        private Button botonPagarCesta;
        private PictureBox pictureBox2;
        private Label LabelPedido;
        private Label labelAnotaciones;
        private Button buttonUlt;
    }
}