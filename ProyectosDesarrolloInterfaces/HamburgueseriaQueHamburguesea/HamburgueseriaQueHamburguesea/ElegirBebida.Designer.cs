namespace HamburgueseriaQueHamburguesea
{
    partial class ElegirBebida
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
            opcionBebidas = new GroupBox();
            radioCoca = new RadioButton();
            radioAgua = new RadioButton();
            radioNestea = new RadioButton();
            lbLabel = new Label();
            lbIngredientes = new Label();
            opcionBebidas.SuspendLayout();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(-1, 1);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(246, 446);
            userControl11.TabIndex = 0;
            // 
            // opcionBebidas
            // 
            opcionBebidas.Controls.Add(radioCoca);
            opcionBebidas.Controls.Add(radioAgua);
            opcionBebidas.Controls.Add(radioNestea);
            opcionBebidas.Location = new Point(260, 280);
            opcionBebidas.Name = "opcionBebidas";
            opcionBebidas.Size = new Size(240, 100);
            opcionBebidas.TabIndex = 1;
            opcionBebidas.TabStop = false;
            opcionBebidas.Text = "Elija Bebida";
            // 
            // radioCoca
            // 
            radioCoca.AutoSize = true;
            radioCoca.Location = new Point(76, 59);
            radioCoca.Name = "radioCoca";
            radioCoca.Size = new Size(79, 19);
            radioCoca.TabIndex = 2;
            radioCoca.TabStop = true;
            radioCoca.Text = "Coca Cola";
            radioCoca.UseVisualStyleBackColor = true;
            radioCoca.CheckedChanged += radioNestea_CheckedChanged;
            // 
            // radioAgua
            // 
            radioAgua.AutoSize = true;
            radioAgua.Location = new Point(157, 22);
            radioAgua.Name = "radioAgua";
            radioAgua.Size = new Size(60, 19);
            radioAgua.TabIndex = 1;
            radioAgua.TabStop = true;
            radioAgua.Text = "Agüita";
            radioAgua.UseVisualStyleBackColor = true;
            radioAgua.CheckedChanged += radioNestea_CheckedChanged;
            // 
            // radioNestea
            // 
            radioNestea.AutoSize = true;
            radioNestea.Location = new Point(15, 22);
            radioNestea.Name = "radioNestea";
            radioNestea.Size = new Size(61, 19);
            radioNestea.TabIndex = 0;
            radioNestea.TabStop = true;
            radioNestea.Text = "Nestea";
            radioNestea.UseVisualStyleBackColor = true;
            radioNestea.CheckedChanged += radioNestea_CheckedChanged;
            // 
            // lbLabel
            // 
            lbLabel.AutoSize = true;
            lbLabel.Location = new Point(260, 21);
            lbLabel.Name = "lbLabel";
            lbLabel.Size = new Size(72, 15);
            lbLabel.TabIndex = 6;
            lbLabel.Text = "Ingredientes";
            // 
            // lbIngredientes
            // 
            lbIngredientes.Location = new Point(260, 36);
            lbIngredientes.Name = "lbIngredientes";
            lbIngredientes.Size = new Size(240, 221);
            lbIngredientes.TabIndex = 5;
            // 
            // ElegirBebida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
            Controls.Add(lbLabel);
            Controls.Add(lbIngredientes);
            Controls.Add(opcionBebidas);
            Controls.Add(userControl11);
            Name = "ElegirBebida";
            Text = "ElegirBebida";
            opcionBebidas.ResumeLayout(false);
            opcionBebidas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControl1 userControl11;
        private GroupBox opcionBebidas;
        private RadioButton radioCoca;
        private RadioButton radioAgua;
        private RadioButton radioNestea;
        private Label lbLabel;
        private Label lbIngredientes;
    }
}