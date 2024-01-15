namespace ppt
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelMedia = new Label();
            lblMaq = new Label();
            lblJug = new Label();
            groupBox1 = new GroupBox();
            btnJuego = new Button();
            rbTijera = new RadioButton();
            rbPapel = new RadioButton();
            rbPiedra = new RadioButton();
            statusStrip1 = new StatusStrip();
            contador = new ToolStripStatusLabel();
            labelres = new Label();
            labelResultado = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 57);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Piedra,papel o tijera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 163);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Elige";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(280, 54);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(388, 58);
            textBox1.TabIndex = 3;
            textBox1.Text = "Tienes que elegir una de las opciones: piedra , papel o tijera. El PC elegirá su opción y dará el resultado. En tres segundos, empezara una nueva partida.";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(label8, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Controls.Add(labelMedia, 2, 0);
            tableLayoutPanel2.Controls.Add(lblMaq, 0, 1);
            tableLayoutPanel2.Controls.Add(lblJug, 2, 1);
            tableLayoutPanel2.Location = new Point(279, 244);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(389, 100);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(183, 67);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 5;
            label8.Text = "VS";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(30, 17);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "La Maquina";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(183, 17);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 1;
            label4.Text = "VS";
            // 
            // labelMedia
            // 
            labelMedia.Anchor = AnchorStyles.None;
            labelMedia.AutoSize = true;
            labelMedia.Location = new Point(299, 17);
            labelMedia.Name = "labelMedia";
            labelMedia.Size = new Size(49, 15);
            labelMedia.TabIndex = 2;
            labelMedia.Text = "Jugador";
            // 
            // lblMaq
            // 
            lblMaq.Anchor = AnchorStyles.None;
            lblMaq.AutoSize = true;
            lblMaq.Location = new Point(64, 67);
            lblMaq.Name = "lblMaq";
            lblMaq.Size = new Size(0, 15);
            lblMaq.TabIndex = 3;
            // 
            // lblJug
            // 
            lblJug.Anchor = AnchorStyles.None;
            lblJug.AutoSize = true;
            lblJug.Location = new Point(323, 67);
            lblJug.Name = "lblJug";
            lblJug.Size = new Size(0, 15);
            lblJug.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnJuego);
            groupBox1.Controls.Add(rbTijera);
            groupBox1.Controls.Add(rbPapel);
            groupBox1.Controls.Add(rbPiedra);
            groupBox1.Location = new Point(280, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 120);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona";
            // 
            // btnJuego
            // 
            btnJuego.Location = new Point(112, 74);
            btnJuego.Name = "btnJuego";
            btnJuego.Size = new Size(138, 23);
            btnJuego.TabIndex = 7;
            btnJuego.Text = "A jugar!";
            btnJuego.UseVisualStyleBackColor = true;
            btnJuego.Click += btnJuego_Click;
            // 
            // rbTijera
            // 
            rbTijera.AutoSize = true;
            rbTijera.Location = new Point(283, 27);
            rbTijera.Name = "rbTijera";
            rbTijera.Size = new Size(53, 19);
            rbTijera.TabIndex = 2;
            rbTijera.TabStop = true;
            rbTijera.Text = "Tijera";
            rbTijera.UseVisualStyleBackColor = true;
            // 
            // rbPapel
            // 
            rbPapel.AutoSize = true;
            rbPapel.Location = new Point(153, 27);
            rbPapel.Name = "rbPapel";
            rbPapel.Size = new Size(54, 19);
            rbPapel.TabIndex = 1;
            rbPapel.TabStop = true;
            rbPapel.Text = "Papel";
            rbPapel.UseVisualStyleBackColor = true;
            // 
            // rbPiedra
            // 
            rbPiedra.AutoSize = true;
            rbPiedra.Location = new Point(29, 27);
            rbPiedra.Name = "rbPiedra";
            rbPiedra.Size = new Size(58, 19);
            rbPiedra.TabIndex = 0;
            rbPiedra.TabStop = true;
            rbPiedra.Text = "Piedra";
            rbPiedra.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { contador });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // contador
            // 
            contador.Name = "contador";
            contador.Size = new Size(112, 17);
            contador.Text = "Siguiente ronda en :";
            // 
            // labelres
            // 
            labelres.AutoSize = true;
            labelres.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelres.Location = new Point(52, 347);
            labelres.Name = "labelres";
            labelres.Size = new Size(77, 15);
            labelres.TabIndex = 8;
            labelres.Text = "RESULTADO:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(56, 373);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(labelres);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Piedra, papel o tijera";
            Load += Form1_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private Label labelMedia;
        private Label lblMaq;
        private Label lblJug;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton rbTijera;
        private RadioButton rbPapel;
        private RadioButton rbPiedra;
        private Button btnJuego;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel contador;
        private Label labelres;
        private Label labelResultado;
        private System.Windows.Forms.Timer timer1;
    }
}