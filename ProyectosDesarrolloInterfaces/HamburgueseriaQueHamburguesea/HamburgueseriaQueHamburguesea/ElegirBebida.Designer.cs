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
            userControlBebidas = new UserControl1();
            SuspendLayout();
            // 
            // userControlBebidas
            // 
            userControlBebidas.Location = new Point(-1, 1);
            userControlBebidas.Name = "userControlBebidas";
            userControlBebidas.Size = new Size(246, 446);
            userControlBebidas.TabIndex = 0;
            // 
            // ElegirBebida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
            Controls.Add(userControlBebidas);
            Name = "ElegirBebida";
            Text = "ElegirBebida";
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControlBebidas;
    }
}