﻿namespace HamburgueseriaQueHamburguesea
{
    partial class ElegirHamburguesa
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
            opcionBurguer = new GroupBox();
            radioBurra = new RadioButton();
            radioApocalipsis = new RadioButton();
            lbIngredientes = new Label();
            lbLabel = new Label();
            lblAnotaciones = new Label();
            txtboxAnotaciones = new TextBox();
            opcionBurguer.SuspendLayout();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(-2, 0);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(237, 452);
            userControl11.TabIndex = 0;
            // 
            // opcionBurguer
            // 
            opcionBurguer.Controls.Add(radioBurra);
            opcionBurguer.Controls.Add(radioApocalipsis);
            opcionBurguer.Location = new Point(272, 238);
            opcionBurguer.Name = "opcionBurguer";
            opcionBurguer.Size = new Size(240, 100);
            opcionBurguer.TabIndex = 2;
            opcionBurguer.TabStop = false;
            opcionBurguer.Text = "Elija Hamburguesa";
            // 
            // radioBurra
            // 
            radioBurra.AutoSize = true;
            radioBurra.Location = new Point(26, 39);
            radioBurra.Name = "radioBurra";
            radioBurra.Size = new Size(53, 19);
            radioBurra.TabIndex = 2;
            radioBurra.TabStop = true;
            radioBurra.Text = "Burra";
            radioBurra.UseVisualStyleBackColor = true;
            radioBurra.CheckedChanged += radioBurra_CheckedChanged;
            // 
            // radioApocalipsis
            // 
            radioApocalipsis.AutoSize = true;
            radioApocalipsis.Location = new Point(149, 39);
            radioApocalipsis.Name = "radioApocalipsis";
            radioApocalipsis.Size = new Size(85, 19);
            radioApocalipsis.TabIndex = 1;
            radioApocalipsis.TabStop = true;
            radioApocalipsis.Text = "Apocalipsis";
            radioApocalipsis.UseVisualStyleBackColor = true;
            radioApocalipsis.CheckedChanged += radioBurra_CheckedChanged;
            // 
            // lbIngredientes
            // 
            lbIngredientes.Location = new Point(272, 33);
            lbIngredientes.Name = "lbIngredientes";
            lbIngredientes.Size = new Size(240, 202);
            lbIngredientes.TabIndex = 3;
            // 
            // lbLabel
            // 
            lbLabel.AutoSize = true;
            lbLabel.Location = new Point(272, 18);
            lbLabel.Name = "lbLabel";
            lbLabel.Size = new Size(72, 15);
            lbLabel.TabIndex = 4;
            lbLabel.Text = "Ingredientes";
            // 
            // lblAnotaciones
            // 
            lblAnotaciones.AutoSize = true;
            lblAnotaciones.Location = new Point(272, 367);
            lblAnotaciones.Name = "lblAnotaciones";
            lblAnotaciones.Size = new Size(102, 15);
            lblAnotaciones.TabIndex = 10;
            lblAnotaciones.Text = "Anotaciones Extra";
            // 
            // txtboxAnotaciones
            // 
            txtboxAnotaciones.Location = new Point(272, 401);
            txtboxAnotaciones.Name = "txtboxAnotaciones";
            txtboxAnotaciones.Size = new Size(240, 23);
            txtboxAnotaciones.TabIndex = 9;
            // 
            // ElegirHamburguesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(577, 450);
            Controls.Add(lblAnotaciones);
            Controls.Add(txtboxAnotaciones);
            Controls.Add(lbLabel);
            Controls.Add(lbIngredientes);
            Controls.Add(opcionBurguer);
            Controls.Add(userControl11);
            Name = "ElegirHamburguesa";
            Text = "ElegirHamburguesa";
            FormClosing += ElegirHamburguesa_FormClosing;
            opcionBurguer.ResumeLayout(false);
            opcionBurguer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControl1 userControl11;
        private GroupBox opcionBurguer;
        private RadioButton radioBurra;
        private RadioButton radioApocalipsis;
        private Label lbIngredientes;
        private Label lbLabel;
        private Label lblAnotaciones;
        private TextBox txtboxAnotaciones;
    }
}