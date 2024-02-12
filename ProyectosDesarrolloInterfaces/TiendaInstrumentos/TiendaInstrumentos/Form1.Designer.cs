namespace TiendaInstrumentos
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
            dataGridView1 = new DataGridView();
            buttonVisualizar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txboxCodigo = new TextBox();
            txboxNombre = new TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            labelCodigo = new Label();
            labelNombre = new Label();
            botonInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(976, 252);
            dataGridView1.TabIndex = 0;
            // 
            // buttonVisualizar
            // 
            buttonVisualizar.Location = new Point(0, 307);
            buttonVisualizar.Name = "buttonVisualizar";
            buttonVisualizar.Size = new Size(976, 23);
            buttonVisualizar.TabIndex = 1;
            buttonVisualizar.Text = "Visualizar";
            buttonVisualizar.UseVisualStyleBackColor = true;
            buttonVisualizar.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(27, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 616);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(botonInsertar);
            tabPage1.Controls.Add(labelNombre);
            tabPage1.Controls.Add(labelCodigo);
            tabPage1.Controls.Add(txboxNombre);
            tabPage1.Controls.Add(buttonVisualizar);
            tabPage1.Controls.Add(txboxCodigo);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 588);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(976, 588);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Clientes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txboxCodigo
            // 
            txboxCodigo.Location = new Point(140, 78);
            txboxCodigo.Name = "txboxCodigo";
            txboxCodigo.Size = new Size(300, 23);
            txboxCodigo.TabIndex = 0;
            // 
            // txboxNombre
            // 
            txboxNombre.Location = new Point(140, 122);
            txboxNombre.Name = "txboxNombre";
            txboxNombre.Size = new Size(300, 23);
            txboxNombre.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(976, 588);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Facturas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(976, 588);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "DetallesFactura";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(43, 75);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(46, 15);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(43, 130);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // botonInsertar
            // 
            botonInsertar.Location = new Point(509, 79);
            botonInsertar.Name = "botonInsertar";
            botonInsertar.Size = new Size(75, 23);
            botonInsertar.TabIndex = 4;
            botonInsertar.Text = "Insertar";
            botonInsertar.UseVisualStyleBackColor = true;
            botonInsertar.Click += botonInsertar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 640);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonVisualizar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txboxNombre;
        private TextBox txboxCodigo;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button botonInsertar;
        private Label labelNombre;
        private Label labelCodigo;
    }
}
