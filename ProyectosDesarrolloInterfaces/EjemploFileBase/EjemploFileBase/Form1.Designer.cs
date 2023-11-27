namespace EjemploFileBase
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelId = new Label();
            labelDireccion = new Label();
            labelEdad = new Label();
            textBoxId = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxEdad = new TextBox();
            labelNombre = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonInsertar = new Button();
            buttonRecuperar = new Button();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            dgv1 = new DataGridView();
            buttonGestor = new Button();
            labeltitle = new Label();
            buttonAgregar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(labelId, 0, 0);
            tableLayoutPanel1.Controls.Add(labelDireccion, 0, 2);
            tableLayoutPanel1.Controls.Add(labelEdad, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxId, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxDireccion, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxEdad, 1, 3);
            tableLayoutPanel1.Controls.Add(labelNombre, 0, 1);
            tableLayoutPanel1.Location = new Point(53, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(482, 147);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelId.AutoSize = true;
            labelId.Location = new Point(3, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(23, 36);
            labelId.TabIndex = 0;
            labelId.Text = "Id :";
            labelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDireccion
            // 
            labelDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(3, 72);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(63, 36);
            labelDireccion.TabIndex = 2;
            labelDireccion.Text = "Direccion :";
            labelDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelEdad
            // 
            labelEdad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(3, 108);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(39, 39);
            labelEdad.TabIndex = 3;
            labelEdad.Text = "Edad :";
            labelEdad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(147, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(332, 23);
            textBoxId.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(147, 39);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(332, 23);
            textBoxNombre.TabIndex = 5;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(147, 75);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(332, 23);
            textBoxDireccion.TabIndex = 6;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(147, 111);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(332, 23);
            textBoxEdad.TabIndex = 7;
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(3, 36);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(57, 36);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre :";
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(buttonInsertar, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonRecuperar, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonActualizar, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonEliminar, 0, 3);
            tableLayoutPanel2.Location = new Point(557, 89);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(209, 144);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Anchor = AnchorStyles.None;
            buttonInsertar.Location = new Point(33, 6);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(143, 23);
            buttonInsertar.TabIndex = 0;
            buttonInsertar.Text = "Insertar elemento";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonRecuperar
            // 
            buttonRecuperar.Anchor = AnchorStyles.None;
            buttonRecuperar.Location = new Point(34, 42);
            buttonRecuperar.Name = "buttonRecuperar";
            buttonRecuperar.Size = new Size(140, 23);
            buttonRecuperar.TabIndex = 1;
            buttonRecuperar.Text = "Recuperar elemento";
            buttonRecuperar.UseVisualStyleBackColor = true;
            buttonRecuperar.Click += buttonRecuperar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Anchor = AnchorStyles.None;
            buttonActualizar.Location = new Point(33, 78);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(142, 23);
            buttonActualizar.TabIndex = 2;
            buttonActualizar.Text = "Actualizar elemento";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.None;
            buttonEliminar.Location = new Point(33, 114);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(142, 23);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar elemento";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(53, 268);
            dgv1.Name = "dgv1";
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(713, 150);
            dgv1.TabIndex = 2;
            // 
            // buttonGestor
            // 
            buttonGestor.Location = new Point(249, 424);
            buttonGestor.Name = "buttonGestor";
            buttonGestor.Size = new Size(286, 23);
            buttonGestor.TabIndex = 3;
            buttonGestor.Text = "Gestor de imagenes";
            buttonGestor.UseVisualStyleBackColor = true;
            buttonGestor.Click += buttonGestor_Click;
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitle.Location = new Point(53, 19);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(434, 46);
            labeltitle.TabIndex = 4;
            labeltitle.Text = "Informacion del elemento";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(662, 239);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(104, 23);
            buttonAgregar.TabIndex = 5;
            buttonAgregar.Text = "Agregar datos";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAgregar);
            Controls.Add(labeltitle);
            Controls.Add(buttonGestor);
            Controls.Add(dgv1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelId;
        private Label labelDireccion;
        private Label labelEdad;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private TextBox textBoxDireccion;
        private TextBox textBoxEdad;
        private Label labelNombre;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonInsertar;
        private Button buttonRecuperar;
        private Button buttonActualizar;
        private Button buttonEliminar;
        private DataGridView dgv1;
        private Button buttonGestor;
        private Label labeltitle;
        private Button buttonAgregar;
    }
}