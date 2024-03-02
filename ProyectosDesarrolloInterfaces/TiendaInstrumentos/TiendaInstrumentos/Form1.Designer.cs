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
            dataGridProductos = new DataGridView();
            buttonVisualizarProductos = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            InsertarProducto = new TabControl();
            tabPage5 = new TabPage();
            txboxPrecio = new TextBox();
            txboxMarca = new TextBox();
            txboxFamilia = new TextBox();
            labelprecio = new Label();
            labelMarca = new Label();
            labelfamilia = new Label();
            labelCodigo = new Label();
            botonInsert = new Button();
            txboxCodigo = new TextBox();
            txboxNombre = new TextBox();
            labelNombre = new Label();
            tabPage6 = new TabPage();
            label3 = new Label();
            botonBorrar = new Button();
            txboxCodigoBorrar = new TextBox();
            tabPage4 = new TabPage();
            txboxPrecioUpd = new TextBox();
            txboxMarcaUpd = new TextBox();
            txboxFamiliaupd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonUpdate = new Button();
            txboxCodigoUpd = new TextBox();
            txboxNombreUpd = new TextBox();
            label8 = new Label();
            tabPage2 = new TabPage();
            update = new TabControl();
            tabPage8 = new TabPage();
            labelPsswd = new Label();
            textBoxPasswordInsert = new TextBox();
            txboxEmailInser = new TextBox();
            txboxApeInsert = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            buttonInsertClie = new Button();
            txboxInsertCliId = new TextBox();
            txboxNombreCliInsert = new TextBox();
            label10 = new Label();
            tabPage9 = new TabPage();
            tabPage7 = new TabPage();
            txboxEmailUpd = new TextBox();
            txboxApellidoUpd = new TextBox();
            EmailUpd = new Label();
            apellidoUpd = new Label();
            ClienteIdUpd = new Label();
            buttonUpdateCliente = new Button();
            txboxClienteUpd = new TextBox();
            txboxNombreCliUpd = new TextBox();
            NombreClienteUpd = new Label();
            botonVisualizarClientes = new Button();
            dataGridClientes = new DataGridView();
            tabPage3 = new TabPage();
            botonVisualizarFacturas = new Button();
            dataGridFacturas = new DataGridView();
            laberRepetir = new Label();
            RepetirPassInsert = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            InsertarProducto.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage2.SuspendLayout();
            update.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFacturas).BeginInit();
            SuspendLayout();
            // 
            // dataGridProductos
            // 
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Location = new Point(0, 336);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.Size = new Size(976, 252);
            dataGridProductos.TabIndex = 0;
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
            tabPage1.Controls.Add(dataGridProductos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 588);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // InsertarProducto
            // 
            InsertarProducto.Controls.Add(tabPage5);
            InsertarProducto.Controls.Add(tabPage6);
            InsertarProducto.Controls.Add(tabPage4);
            InsertarProducto.Location = new Point(15, 19);
            InsertarProducto.Name = "InsertarProducto";
            InsertarProducto.SelectedIndex = 0;
            InsertarProducto.Size = new Size(925, 270);
            InsertarProducto.TabIndex = 5;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(txboxPrecio);
            tabPage5.Controls.Add(txboxMarca);
            tabPage5.Controls.Add(txboxFamilia);
            tabPage5.Controls.Add(labelprecio);
            tabPage5.Controls.Add(labelMarca);
            tabPage5.Controls.Add(labelfamilia);
            tabPage5.Controls.Add(labelCodigo);
            tabPage5.Controls.Add(botonInsert);
            tabPage5.Controls.Add(txboxCodigo);
            tabPage5.Controls.Add(txboxNombre);
            tabPage5.Controls.Add(labelNombre);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(917, 242);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Insertar";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txboxPrecio
            // 
            txboxPrecio.Location = new Point(87, 129);
            txboxPrecio.Name = "txboxPrecio";
            txboxPrecio.Size = new Size(300, 23);
            txboxPrecio.TabIndex = 10;
            // 
            // txboxMarca
            // 
            txboxMarca.Location = new Point(87, 100);
            txboxMarca.Name = "txboxMarca";
            txboxMarca.Size = new Size(300, 23);
            txboxMarca.TabIndex = 9;
            // 
            // txboxFamilia
            // 
            txboxFamilia.Location = new Point(87, 71);
            txboxFamilia.Name = "txboxFamilia";
            txboxFamilia.Size = new Size(300, 23);
            txboxFamilia.TabIndex = 8;
            // 
            // labelprecio
            // 
            labelprecio.AutoSize = true;
            labelprecio.Location = new Point(13, 137);
            labelprecio.Name = "labelprecio";
            labelprecio.Size = new Size(40, 15);
            labelprecio.TabIndex = 7;
            labelprecio.Text = "Precio";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(11, 108);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(40, 15);
            labelMarca.TabIndex = 6;
            labelMarca.Text = "Marca";
            // 
            // labelfamilia
            // 
            labelfamilia.AutoSize = true;
            labelfamilia.Location = new Point(10, 79);
            labelfamilia.Name = "labelfamilia";
            labelfamilia.Size = new Size(45, 15);
            labelfamilia.TabIndex = 5;
            labelfamilia.Text = "Familia";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(454, 87);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(46, 15);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Codigo";
            // 
            // botonInsert
            // 
            botonInsert.Location = new Point(633, 133);
            botonInsert.Name = "botonInsert";
            botonInsert.Size = new Size(75, 23);
            botonInsert.TabIndex = 4;
            botonInsert.Text = "Insert";
            botonInsert.UseVisualStyleBackColor = true;
            botonInsert.Click += botonInsertar_Click;
            // 
            // txboxCodigo
            // 
            txboxCodigo.Location = new Point(527, 84);
            txboxCodigo.Name = "txboxCodigo";
            txboxCodigo.Size = new Size(300, 23);
            txboxCodigo.TabIndex = 0;
            // 
            // txboxNombre
            // 
            txboxNombre.Location = new Point(87, 42);
            txboxNombre.Name = "txboxNombre";
            txboxNombre.Size = new Size(300, 23);
            txboxNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(11, 50);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label3);
            tabPage6.Controls.Add(botonBorrar);
            tabPage6.Controls.Add(txboxCodigoBorrar);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(917, 242);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Borrar";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 78);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Codigo";
            // 
            // botonBorrar
            // 
            botonBorrar.Location = new Point(468, 81);
            botonBorrar.Name = "botonBorrar";
            botonBorrar.Size = new Size(75, 23);
            botonBorrar.TabIndex = 7;
            botonBorrar.Text = "Borrar";
            botonBorrar.UseVisualStyleBackColor = true;
            botonBorrar.Click += botonBorrar_Click;
            // 
            // txboxCodigoBorrar
            // 
            txboxCodigoBorrar.Location = new Point(140, 81);
            txboxCodigoBorrar.Name = "txboxCodigoBorrar";
            txboxCodigoBorrar.Size = new Size(300, 23);
            txboxCodigoBorrar.TabIndex = 5;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txboxPrecioUpd);
            tabPage4.Controls.Add(txboxMarcaUpd);
            tabPage4.Controls.Add(txboxFamiliaupd);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(buttonUpdate);
            tabPage4.Controls.Add(txboxCodigoUpd);
            tabPage4.Controls.Add(txboxNombreUpd);
            tabPage4.Controls.Add(label8);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(917, 242);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Update";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txboxPrecioUpd
            // 
            txboxPrecioUpd.Location = new Point(127, 151);
            txboxPrecioUpd.Name = "txboxPrecioUpd";
            txboxPrecioUpd.Size = new Size(300, 23);
            txboxPrecioUpd.TabIndex = 21;
            // 
            // txboxMarcaUpd
            // 
            txboxMarcaUpd.Location = new Point(127, 122);
            txboxMarcaUpd.Name = "txboxMarcaUpd";
            txboxMarcaUpd.Size = new Size(300, 23);
            txboxMarcaUpd.TabIndex = 20;
            // 
            // txboxFamiliaupd
            // 
            txboxFamiliaupd.Location = new Point(127, 93);
            txboxFamiliaupd.Name = "txboxFamiliaupd";
            txboxFamiliaupd.Size = new Size(300, 23);
            txboxFamiliaupd.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 159);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 18;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 130);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 17;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 101);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 16;
            label6.Text = "Familia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 109);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 13;
            label7.Text = "Codigo";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(673, 155);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 15;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // txboxCodigoUpd
            // 
            txboxCodigoUpd.Location = new Point(567, 106);
            txboxCodigoUpd.Name = "txboxCodigoUpd";
            txboxCodigoUpd.Size = new Size(300, 23);
            txboxCodigoUpd.TabIndex = 11;
            // 
            // txboxNombreUpd
            // 
            txboxNombreUpd.Location = new Point(127, 64);
            txboxNombreUpd.Name = "txboxNombreUpd";
            txboxNombreUpd.Size = new Size(300, 23);
            txboxNombreUpd.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 72);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 14;
            label8.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(update);
            tabPage2.Controls.Add(botonVisualizarClientes);
            tabPage2.Controls.Add(dataGridClientes);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(976, 588);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Clientes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Controls.Add(tabPage8);
            update.Controls.Add(tabPage9);
            update.Controls.Add(tabPage7);
            update.Location = new Point(17, 6);
            update.Name = "update";
            update.SelectedIndex = 0;
            update.Size = new Size(953, 309);
            update.TabIndex = 12;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(RepetirPassInsert);
            tabPage8.Controls.Add(laberRepetir);
            tabPage8.Controls.Add(labelPsswd);
            tabPage8.Controls.Add(textBoxPasswordInsert);
            tabPage8.Controls.Add(txboxEmailInser);
            tabPage8.Controls.Add(txboxApeInsert);
            tabPage8.Controls.Add(label1);
            tabPage8.Controls.Add(label2);
            tabPage8.Controls.Add(label9);
            tabPage8.Controls.Add(buttonInsertClie);
            tabPage8.Controls.Add(txboxInsertCliId);
            tabPage8.Controls.Add(txboxNombreCliInsert);
            tabPage8.Controls.Add(label10);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(945, 281);
            tabPage8.TabIndex = 0;
            tabPage8.Text = "Insertar";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // labelPsswd
            // 
            labelPsswd.AutoSize = true;
            labelPsswd.Location = new Point(508, 99);
            labelPsswd.Name = "labelPsswd";
            labelPsswd.Size = new Size(67, 15);
            labelPsswd.TabIndex = 42;
            labelPsswd.Text = "Contraseña";
            // 
            // textBoxPasswordInsert
            // 
            textBoxPasswordInsert.Location = new Point(581, 91);
            textBoxPasswordInsert.Name = "textBoxPasswordInsert";
            textBoxPasswordInsert.Size = new Size(300, 23);
            textBoxPasswordInsert.TabIndex = 41;
            // 
            // txboxEmailInser
            // 
            txboxEmailInser.Location = new Point(141, 141);
            txboxEmailInser.Name = "txboxEmailInser";
            txboxEmailInser.Size = new Size(300, 23);
            txboxEmailInser.TabIndex = 40;
            // 
            // txboxApeInsert
            // 
            txboxApeInsert.Location = new Point(141, 112);
            txboxApeInsert.Name = "txboxApeInsert";
            txboxApeInsert.Size = new Size(300, 23);
            txboxApeInsert.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 149);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 38;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 120);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 37;
            label2.Text = "Apellido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(512, 64);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 34;
            label9.Text = "ClienteId";
            // 
            // buttonInsertClie
            // 
            buttonInsertClie.Location = new Point(687, 174);
            buttonInsertClie.Name = "buttonInsertClie";
            buttonInsertClie.Size = new Size(75, 23);
            buttonInsertClie.TabIndex = 36;
            buttonInsertClie.Text = "Insertar";
            buttonInsertClie.UseVisualStyleBackColor = true;
            buttonInsertClie.Click += buttonInsertClie_Click;
            // 
            // txboxInsertCliId
            // 
            txboxInsertCliId.Location = new Point(581, 58);
            txboxInsertCliId.Name = "txboxInsertCliId";
            txboxInsertCliId.Size = new Size(300, 23);
            txboxInsertCliId.TabIndex = 32;
            // 
            // txboxNombreCliInsert
            // 
            txboxNombreCliInsert.Location = new Point(141, 83);
            txboxNombreCliInsert.Name = "txboxNombreCliInsert";
            txboxNombreCliInsert.Size = new Size(300, 23);
            txboxNombreCliInsert.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(65, 91);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 35;
            label10.Text = "Nombre";
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(945, 281);
            tabPage9.TabIndex = 1;
            tabPage9.Text = "Borrar";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(txboxEmailUpd);
            tabPage7.Controls.Add(txboxApellidoUpd);
            tabPage7.Controls.Add(EmailUpd);
            tabPage7.Controls.Add(apellidoUpd);
            tabPage7.Controls.Add(ClienteIdUpd);
            tabPage7.Controls.Add(buttonUpdateCliente);
            tabPage7.Controls.Add(txboxClienteUpd);
            tabPage7.Controls.Add(txboxNombreCliUpd);
            tabPage7.Controls.Add(NombreClienteUpd);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(945, 281);
            tabPage7.TabIndex = 2;
            tabPage7.Text = "Update";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // txboxEmailUpd
            // 
            txboxEmailUpd.Location = new Point(141, 141);
            txboxEmailUpd.Name = "txboxEmailUpd";
            txboxEmailUpd.Size = new Size(300, 23);
            txboxEmailUpd.TabIndex = 31;
            // 
            // txboxApellidoUpd
            // 
            txboxApellidoUpd.Location = new Point(141, 112);
            txboxApellidoUpd.Name = "txboxApellidoUpd";
            txboxApellidoUpd.Size = new Size(300, 23);
            txboxApellidoUpd.TabIndex = 30;
            // 
            // EmailUpd
            // 
            EmailUpd.AutoSize = true;
            EmailUpd.Location = new Point(65, 149);
            EmailUpd.Name = "EmailUpd";
            EmailUpd.Size = new Size(36, 15);
            EmailUpd.TabIndex = 28;
            EmailUpd.Text = "Email";
            // 
            // apellidoUpd
            // 
            apellidoUpd.AutoSize = true;
            apellidoUpd.Location = new Point(64, 120);
            apellidoUpd.Name = "apellidoUpd";
            apellidoUpd.Size = new Size(51, 15);
            apellidoUpd.TabIndex = 27;
            apellidoUpd.Text = "Apellido";
            // 
            // ClienteIdUpd
            // 
            ClienteIdUpd.AutoSize = true;
            ClienteIdUpd.Location = new Point(508, 128);
            ClienteIdUpd.Name = "ClienteIdUpd";
            ClienteIdUpd.Size = new Size(54, 15);
            ClienteIdUpd.TabIndex = 24;
            ClienteIdUpd.Text = "ClienteId";
            // 
            // buttonUpdateCliente
            // 
            buttonUpdateCliente.Location = new Point(687, 174);
            buttonUpdateCliente.Name = "buttonUpdateCliente";
            buttonUpdateCliente.Size = new Size(75, 23);
            buttonUpdateCliente.TabIndex = 26;
            buttonUpdateCliente.Text = "Update";
            buttonUpdateCliente.UseVisualStyleBackColor = true;
            // 
            // txboxClienteUpd
            // 
            txboxClienteUpd.Location = new Point(581, 125);
            txboxClienteUpd.Name = "txboxClienteUpd";
            txboxClienteUpd.Size = new Size(300, 23);
            txboxClienteUpd.TabIndex = 22;
            // 
            // txboxNombreCliUpd
            // 
            txboxNombreCliUpd.Location = new Point(141, 83);
            txboxNombreCliUpd.Name = "txboxNombreCliUpd";
            txboxNombreCliUpd.Size = new Size(300, 23);
            txboxNombreCliUpd.TabIndex = 23;
            // 
            // NombreClienteUpd
            // 
            NombreClienteUpd.AutoSize = true;
            NombreClienteUpd.Location = new Point(65, 91);
            NombreClienteUpd.Name = "NombreClienteUpd";
            NombreClienteUpd.Size = new Size(51, 15);
            NombreClienteUpd.TabIndex = 25;
            NombreClienteUpd.Text = "Nombre";
            // 
            // botonVisualizarClientes
            // 
            botonVisualizarClientes.Location = new Point(0, 321);
            botonVisualizarClientes.Name = "botonVisualizarClientes";
            botonVisualizarClientes.Size = new Size(976, 23);
            botonVisualizarClientes.TabIndex = 8;
            botonVisualizarClientes.Text = "Visualizar";
            botonVisualizarClientes.UseVisualStyleBackColor = true;
            botonVisualizarClientes.Click += botonVisualizarClientes_Click;
            // 
            // dataGridClientes
            // 
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(-3, 340);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.Size = new Size(976, 252);
            dataGridClientes.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(botonVisualizarFacturas);
            tabPage3.Controls.Add(dataGridFacturas);
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
            botonVisualizarFacturas.Click += botonVisualizarFacturas_Click;
            // 
            // dataGridFacturas
            // 
            dataGridFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFacturas.Location = new Point(0, 299);
            dataGridFacturas.Name = "dataGridFacturas";
            dataGridFacturas.Size = new Size(976, 252);
            dataGridFacturas.TabIndex = 6;
            // 
            // laberRepetir
            // 
            laberRepetir.AutoSize = true;
            laberRepetir.Location = new Point(470, 132);
            laberRepetir.Name = "laberRepetir";
            laberRepetir.Size = new Size(105, 15);
            laberRepetir.TabIndex = 43;
            laberRepetir.Text = "Repetir contraseña";
            // 
            // RepetirPassInsert
            // 
            RepetirPassInsert.Location = new Point(581, 131);
            RepetirPassInsert.Name = "RepetirPassInsert";
            RepetirPassInsert.Size = new Size(300, 23);
            RepetirPassInsert.TabIndex = 44;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 640);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Admin";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            InsertarProducto.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage2.ResumeLayout(false);
            update.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProductos;
        private Button buttonVisualizarProductos;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button botonVisualizarClientes;
        private DataGridView dataGridClientes;
        private Button botonVisualizarFacturas;
        private DataGridView dataGridFacturas;
        private TabControl update;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabControl InsertarProducto;
        private TabPage tabPage5;
        private Label labelCodigo;
        private Button botonInsert;
        private TextBox txboxCodigo;
        private TextBox txboxNombre;
        private Label labelNombre;
        private TabPage tabPage6;
        private Label label3;
        private Button botonBorrar;
        private TextBox txboxCodigoBorrar;
        private Label labelprecio;
        private Label labelMarca;
        private Label labelfamilia;
        private TextBox txboxPrecio;
        private TextBox txboxMarca;
        private TextBox txboxFamilia;
        private TabPage tabPage4;
        private TextBox txboxPrecioUpd;
        private TextBox txboxMarcaUpd;
        private TextBox txboxFamiliaupd;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonUpdate;
        private TextBox txboxCodigoUpd;
        private TextBox txboxNombreUpd;
        private Label label8;
        private TabPage tabPage7;
        private TextBox txboxEmailInser;
        private TextBox txboxApeInsert;
        private Label label1;
        private Label label2;
        private Label label9;
        private Button buttonInsertClie;
        private TextBox txboxInsertCliId;
        private TextBox txboxNombreCliInsert;
        private Label label10;
        private TextBox txboxEmailUpd;
        private TextBox txboxApellidoUpd;
        private Label EmailUpd;
        private Label apellidoUpd;
        private Label ClienteIdUpd;
        private Button buttonUpdateCliente;
        private TextBox txboxClienteUpd;
        private TextBox txboxNombreCliUpd;
        private Label NombreClienteUpd;
        private Label labelPsswd;
        private TextBox textBoxPasswordInsert;
        private TextBox RepetirPassInsert;
        private Label laberRepetir;
    }
}
