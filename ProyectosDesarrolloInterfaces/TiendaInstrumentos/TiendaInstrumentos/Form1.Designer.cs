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
            buttonVisualizarProductos = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            botonInsertar = new Button();
            labelNombre = new Label();
            labelCodigo = new Label();
            txboxNombre = new TextBox();
            txboxCodigo = new TextBox();
            tabPage2 = new TabPage();
            botonVisualizarClientes = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            botonVisualizarFacturas = new Button();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            botonVisualizarDetallesFacturas = new Button();
            dataGridView4 = new DataGridView();
            InsertarProducto = new TabControl();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabControl2 = new TabControl();
            tabPage8 = new TabPage();
            label1 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            tabPage9 = new TabPage();
            tabPage10 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            InsertarProducto.SuspendLayout();
            tabPage5.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage8.SuspendLayout();
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
            // buttonVisualizarProductos
            // 
            buttonVisualizarProductos.Location = new Point(0, 307);
            buttonVisualizarProductos.Name = "buttonVisualizarProductos";
            buttonVisualizarProductos.Size = new Size(976, 23);
            buttonVisualizarProductos.TabIndex = 1;
            buttonVisualizarProductos.Text = "Visualizar";
            buttonVisualizarProductos.UseVisualStyleBackColor = true;
            buttonVisualizarProductos.Click += button1_Click;
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
            tabPage1.Controls.Add(InsertarProducto);
            tabPage1.Controls.Add(buttonVisualizarProductos);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 588);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // botonInsertar
            // 
            botonInsertar.Location = new Point(425, 26);
            botonInsertar.Name = "botonInsertar";
            botonInsertar.Size = new Size(75, 23);
            botonInsertar.TabIndex = 4;
            botonInsertar.Text = "Insertar";
            botonInsertar.UseVisualStyleBackColor = true;
            botonInsertar.Click += botonInsertar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(0, 78);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(0, 23);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(46, 15);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo";
            // 
            // txboxNombre
            // 
            txboxNombre.Location = new Point(97, 70);
            txboxNombre.Name = "txboxNombre";
            txboxNombre.Size = new Size(300, 23);
            txboxNombre.TabIndex = 1;
            // 
            // txboxCodigo
            // 
            txboxCodigo.Location = new Point(97, 26);
            txboxCodigo.Name = "txboxCodigo";
            txboxCodigo.Size = new Size(300, 23);
            txboxCodigo.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Controls.Add(botonVisualizarClientes);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(976, 588);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Clientes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // botonVisualizarClientes
            // 
            botonVisualizarClientes.Location = new Point(0, 321);
            botonVisualizarClientes.Name = "botonVisualizarClientes";
            botonVisualizarClientes.Size = new Size(976, 23);
            botonVisualizarClientes.TabIndex = 8;
            botonVisualizarClientes.Text = "Visualizar";
            botonVisualizarClientes.UseVisualStyleBackColor = true;
            botonVisualizarClientes.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-3, 340);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(976, 252);
            dataGridView2.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(botonVisualizarFacturas);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(976, 588);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Facturas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // botonVisualizarFacturas
            // 
            botonVisualizarFacturas.Location = new Point(0, 270);
            botonVisualizarFacturas.Name = "botonVisualizarFacturas";
            botonVisualizarFacturas.Size = new Size(976, 23);
            botonVisualizarFacturas.TabIndex = 8;
            botonVisualizarFacturas.Text = "Visualizar";
            botonVisualizarFacturas.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 299);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(976, 252);
            dataGridView3.TabIndex = 6;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(botonVisualizarDetallesFacturas);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(976, 588);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "DetallesFactura";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // botonVisualizarDetallesFacturas
            // 
            botonVisualizarDetallesFacturas.Location = new Point(0, 270);
            botonVisualizarDetallesFacturas.Name = "botonVisualizarDetallesFacturas";
            botonVisualizarDetallesFacturas.Size = new Size(976, 23);
            botonVisualizarDetallesFacturas.TabIndex = 8;
            botonVisualizarDetallesFacturas.Text = "Visualizar";
            botonVisualizarDetallesFacturas.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(0, 299);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(976, 252);
            dataGridView4.TabIndex = 6;
            // 
            // InsertarProducto
            // 
            InsertarProducto.Controls.Add(tabPage5);
            InsertarProducto.Controls.Add(tabPage6);
            InsertarProducto.Controls.Add(tabPage7);
            InsertarProducto.Location = new Point(15, 79);
            InsertarProducto.Name = "InsertarProducto";
            InsertarProducto.SelectedIndex = 0;
            InsertarProducto.Size = new Size(595, 210);
            InsertarProducto.TabIndex = 5;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(labelCodigo);
            tabPage5.Controls.Add(botonInsertar);
            tabPage5.Controls.Add(txboxCodigo);
            tabPage5.Controls.Add(labelNombre);
            tabPage5.Controls.Add(txboxNombre);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(587, 182);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Insertar";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(587, 182);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Borrar";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(587, 182);
            tabPage7.TabIndex = 2;
            tabPage7.Text = "Update";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Controls.Add(tabPage9);
            tabControl2.Controls.Add(tabPage10);
            tabControl2.Location = new Point(49, 39);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(595, 210);
            tabControl2.TabIndex = 12;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(label1);
            tabPage8.Controls.Add(button2);
            tabPage8.Controls.Add(textBox3);
            tabPage8.Controls.Add(label2);
            tabPage8.Controls.Add(textBox4);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(587, 182);
            tabPage8.TabIndex = 0;
            tabPage8.Text = "Insertar";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "ClienteID";
            // 
            // button2
            // 
            button2.Location = new Point(425, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Insertar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 23);
            textBox3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 23);
            textBox4.TabIndex = 1;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(587, 182);
            tabPage9.TabIndex = 1;
            tabPage9.Text = "Borrar";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Location = new Point(4, 24);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(587, 182);
            tabPage10.TabIndex = 2;
            tabPage10.Text = "Update";
            tabPage10.UseVisualStyleBackColor = true;
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
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            InsertarProducto.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonVisualizarProductos;
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
        private Button botonVisualizarClientes;
        private DataGridView dataGridView2;
        private Button botonVisualizarFacturas;
        private DataGridView dataGridView3;
        private Button botonVisualizarDetallesFacturas;
        private DataGridView dataGridView4;
        private TabControl InsertarProducto;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabControl tabControl2;
        private TabPage tabPage8;
        private Label label1;
        private Button button2;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private TabPage tabPage9;
        private TabPage tabPage10;
    }
}
