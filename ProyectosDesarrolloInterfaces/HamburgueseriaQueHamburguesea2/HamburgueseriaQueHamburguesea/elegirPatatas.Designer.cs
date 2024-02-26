namespace HamburgueseriaQueHamburguesea
{
    partial class elegirPatatas
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
            userControl11 = new UserControl1();
            opcionPatacas = new GroupBox();
            radioSimple = new RadioButton();
            radioDoble = new RadioButton();
            lblAnotaciones = new Label();
            txtboxAnotaciones = new TextBox();
            opcionPatacas.SuspendLayout();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(0, 2);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(230, 447);
            userControl11.TabIndex = 0;
            // 
            // opcionPatacas
            // 
            opcionPatacas.Controls.Add(radioSimple);
            opcionPatacas.Controls.Add(radioDoble);
            opcionPatacas.Location = new Point(236, 144);
            opcionPatacas.Name = "opcionPatacas";
            opcionPatacas.Size = new Size(240, 100);
            opcionPatacas.TabIndex = 3;
            opcionPatacas.TabStop = false;
            opcionPatacas.Text = "Elija la ración de patacas";
            // 
            // radioSimple
            // 
            radioSimple.AutoSize = true;
            radioSimple.Location = new Point(26, 39);
            radioSimple.Name = "radioSimple";
            radioSimple.Size = new Size(61, 19);
            radioSimple.TabIndex = 2;
            radioSimple.TabStop = true;
            radioSimple.Text = "Simple";
            radioSimple.UseVisualStyleBackColor = true;
            radioSimple.CheckedChanged += radioSimple_CheckedChanged;
            // 
            // radioDoble
            // 
            radioDoble.AutoSize = true;
            radioDoble.Location = new Point(149, 39);
            radioDoble.Name = "radioDoble";
            radioDoble.Size = new Size(56, 19);
            radioDoble.TabIndex = 1;
            radioDoble.TabStop = true;
            radioDoble.Text = "Doble";
            radioDoble.UseVisualStyleBackColor = true;
            radioDoble.CheckedChanged += radioSimple_CheckedChanged;
            // 
            // lblAnotaciones
            // 
            lblAnotaciones.AutoSize = true;
            lblAnotaciones.Location = new Point(236, 316);
            lblAnotaciones.Name = "lblAnotaciones";
            lblAnotaciones.Size = new Size(217, 15);
            lblAnotaciones.TabIndex = 12;
            lblAnotaciones.Text = "Anotaciones Extra especifique producto";
            // 
            // txtboxAnotaciones
            // 
            txtboxAnotaciones.Location = new Point(236, 350);
            txtboxAnotaciones.Name = "txtboxAnotaciones";
            txtboxAnotaciones.Size = new Size(240, 23);
            txtboxAnotaciones.TabIndex = 11;
            // 
            // elegirPatatas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(502, 450);
            Controls.Add(lblAnotaciones);
            Controls.Add(txtboxAnotaciones);
            Controls.Add(opcionPatacas);
            Controls.Add(userControl11);
            Name = "elegirPatatas";
            Text = "ElegirPatacas";
            FormClosing += elegirPatatas_FormClosing;
            opcionPatacas.ResumeLayout(false);
            opcionPatacas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControl1 userControl11;
        private GroupBox opcionPatacas;
        private RadioButton radioSimple;
        private RadioButton radioDoble;
        private Label lblAnotaciones;
        private TextBox txtboxAnotaciones;
    }
}