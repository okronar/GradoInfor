namespace TiendaInstrumentos
{
    partial class Registrar
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
            txPasswordReg = new TextBox();
            txUsernameReg = new TextBox();
            labelPassword = new Label();
            labelUser = new Label();
            buttonRegistrarReg = new Button();
            PasswordRep = new Label();
            txRepetir = new TextBox();
            SuspendLayout();
            // 
            // txPasswordReg
            // 
            txPasswordReg.Location = new Point(179, 85);
            txPasswordReg.Name = "txPasswordReg";
            txPasswordReg.Size = new Size(320, 23);
            txPasswordReg.TabIndex = 7;
            txPasswordReg.UseSystemPasswordChar = true;
            // 
            // txUsernameReg
            // 
            txUsernameReg.Location = new Point(179, 37);
            txUsernameReg.Name = "txUsernameReg";
            txUsernameReg.Size = new Size(320, 23);
            txUsernameReg.TabIndex = 6;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(35, 93);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(35, 45);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(60, 15);
            labelUser.TabIndex = 4;
            labelUser.Text = "Username";
            // 
            // buttonRegistrarReg
            // 
            buttonRegistrarReg.Location = new Point(331, 361);
            buttonRegistrarReg.Name = "buttonRegistrarReg";
            buttonRegistrarReg.Size = new Size(168, 43);
            buttonRegistrarReg.TabIndex = 8;
            buttonRegistrarReg.Text = "Registrar";
            buttonRegistrarReg.UseVisualStyleBackColor = true;
            buttonRegistrarReg.Click += buttonRegistrarReg_Click;
            // 
            // PasswordRep
            // 
            PasswordRep.AutoSize = true;
            PasswordRep.Location = new Point(12, 142);
            PasswordRep.Name = "PasswordRep";
            PasswordRep.Size = new Size(97, 15);
            PasswordRep.TabIndex = 9;
            PasswordRep.Text = "Repetir Password";
            // 
            // txRepetir
            // 
            txRepetir.Location = new Point(179, 134);
            txRepetir.Name = "txRepetir";
            txRepetir.Size = new Size(320, 23);
            txRepetir.TabIndex = 10;
            txRepetir.UseSystemPasswordChar = true;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txRepetir);
            Controls.Add(PasswordRep);
            Controls.Add(buttonRegistrarReg);
            Controls.Add(txPasswordReg);
            Controls.Add(txUsernameReg);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Name = "Registrar";
            Text = "Registrar";
            FormClosing += Registrar_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txPasswordReg;
        private TextBox txUsernameReg;
        private Label labelPassword;
        private Label labelUser;
        private Button buttonRegistrarReg;
        private Label PasswordRep;
        private TextBox txRepetir;
    }
}