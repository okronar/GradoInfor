namespace TiendaInstrumentos
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelUser = new Label();
            labelPassword = new Label();
            txUsername = new TextBox();
            txPassword = new TextBox();
            buttonClear = new Button();
            buttonRegistrar = new Button();
            buttonLogin = new Button();
            buttonVolver = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(106, 87);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(60, 15);
            labelUser.TabIndex = 0;
            labelUser.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(106, 150);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // txUsername
            // 
            txUsername.Location = new Point(263, 87);
            txUsername.Name = "txUsername";
            txUsername.Size = new Size(320, 23);
            txUsername.TabIndex = 2;
            toolTip1.SetToolTip(txUsername, "your username");
            // 
            // txPassword
            // 
            txPassword.Location = new Point(263, 142);
            txPassword.Name = "txPassword";
            txPassword.Size = new Size(320, 23);
            txPassword.TabIndex = 3;
            toolTip1.SetToolTip(txPassword, "your password");
            txPassword.UseSystemPasswordChar = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(77, 303);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(154, 43);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            toolTip1.SetToolTip(buttonClear, "clean the textboxes");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Location = new Point(309, 303);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(168, 43);
            buttonRegistrar.TabIndex = 5;
            buttonRegistrar.Text = "Registrar";
            toolTip1.SetToolTip(buttonRegistrar, "go to register");
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(550, 303);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(172, 43);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            toolTip1.SetToolTip(buttonLogin, "click to login once completed");
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(309, 391);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(172, 47);
            buttonVolver.TabIndex = 7;
            buttonVolver.Text = "Volver";
            toolTip1.SetToolTip(buttonVolver, "go back");
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVolver);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegistrar);
            Controls.Add(buttonClear);
            Controls.Add(txPassword);
            Controls.Add(txUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private Label labelPassword;
        private TextBox txUsername;
        private TextBox txPassword;
        private Button buttonClear;
        private Button buttonRegistrar;
        private Button buttonLogin;
        private Button buttonVolver;
        private ToolTip toolTip1;
    }
}