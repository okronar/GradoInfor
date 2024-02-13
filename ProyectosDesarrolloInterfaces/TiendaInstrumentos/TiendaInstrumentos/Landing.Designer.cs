namespace TiendaInstrumentos
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            botonGO = new Button();
            SuspendLayout();
            // 
            // botonGO
            // 
            botonGO.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            botonGO.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 0);
            botonGO.Location = new Point(162, 435);
            botonGO.Name = "botonGO";
            botonGO.Size = new Size(182, 73);
            botonGO.TabIndex = 0;
            botonGO.Text = "GO";
            botonGO.UseVisualStyleBackColor = true;
            botonGO.Click += botonGO_Click;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(507, 611);
            Controls.Add(botonGO);
            Name = "Landing";
            Text = "Landing";
            ResumeLayout(false);
        }

        #endregion

        private Button botonGO;
    }
}