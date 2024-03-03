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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            txPasswordReg = new TextBox();
            txUsernameReg = new TextBox();
            labelPassword = new Label();
            labelUser = new Label();
            buttonRegistrarReg = new Button();
            PasswordRep = new Label();
            txRepetir = new TextBox();
            buttonVolver = new Button();
            txboxEmailReg = new TextBox();
            txboxApellidoReg = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txboxNombreReg = new TextBox();
            label10 = new Label();
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
            // buttonVolver
            // 
            buttonVolver.Location = new Point(599, 361);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(158, 43);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // txboxEmailReg
            // 
            txboxEmailReg.Location = new Point(179, 265);
            txboxEmailReg.Name = "txboxEmailReg";
            txboxEmailReg.Size = new Size(320, 23);
            txboxEmailReg.TabIndex = 46;
            // 
            // txboxApellidoReg
            // 
            txboxApellidoReg.Location = new Point(179, 221);
            txboxApellidoReg.Name = "txboxApellidoReg";
            txboxApellidoReg.Size = new Size(320, 23);
            txboxApellidoReg.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 273);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 44;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 229);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 43;
            label2.Text = "Apellido";
            // 
            // txboxNombreReg
            // 
            txboxNombreReg.Location = new Point(179, 175);
            txboxNombreReg.Name = "txboxNombreReg";
            txboxNombreReg.Size = new Size(320, 23);
            txboxNombreReg.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 183);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 42;
            label10.Text = "Nombre";
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txboxEmailReg);
            Controls.Add(txboxApellidoReg);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txboxNombreReg);
            Controls.Add(label10);
            Controls.Add(buttonVolver);
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
        private Button buttonVolver;
        private TextBox txboxEmailReg;
        private TextBox txboxApellidoReg;
        private Label label1;
        private Label label2;
        private TextBox txboxNombreReg;
        private Label label10;
    }
}