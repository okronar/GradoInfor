namespace EjemploFireBase
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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAbrir = new Button();
            buttoninsertar = new Button();
            buttonRecuperar = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonAbrir, 0, 0);
            tableLayoutPanel1.Controls.Add(buttoninsertar, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonRecuperar, 1, 1);
            tableLayoutPanel1.Location = new Point(46, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(394, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAbrir
            // 
            buttonAbrir.Anchor = AnchorStyles.None;
            buttonAbrir.Location = new Point(27, 13);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(142, 23);
            buttonAbrir.TabIndex = 0;
            buttonAbrir.Text = "Abrir";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // buttoninsertar
            // 
            buttoninsertar.Anchor = AnchorStyles.None;
            buttoninsertar.Location = new Point(227, 13);
            buttoninsertar.Name = "buttoninsertar";
            buttoninsertar.Size = new Size(136, 23);
            buttoninsertar.TabIndex = 1;
            buttoninsertar.Text = "Insertar";
            buttoninsertar.UseVisualStyleBackColor = true;
            buttoninsertar.Click += buttoninsertar_Click;
            // 
            // buttonRecuperar
            // 
            buttonRecuperar.Anchor = AnchorStyles.None;
            buttonRecuperar.Location = new Point(227, 63);
            buttonRecuperar.Name = "buttonRecuperar";
            buttonRecuperar.Size = new Size(136, 23);
            buttonRecuperar.TabIndex = 2;
            buttonRecuperar.Text = "Recuperar";
            buttonRecuperar.UseVisualStyleBackColor = true;
            buttonRecuperar.Click += buttonRecuperar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(46, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(729, 289);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAbrir;
        private Button buttoninsertar;
        private Button buttonRecuperar;
        private PictureBox pictureBox1;
    }
}