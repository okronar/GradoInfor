namespace GuessNumber_Ex3
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
            label_Info = new Label();
            textBoxInput = new TextBox();
            label_Intentos = new Label();
            buttonAction = new Button();
            statusStrip1 = new StatusStrip();
            Label_Debug = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Info
            // 
            label_Info.AutoSize = true;
            label_Info.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_Info.Location = new Point(329, 69);
            label_Info.Name = "label_Info";
            label_Info.Size = new Size(249, 37);
            label_Info.TabIndex = 0;
            label_Info.Text = "¡Adivina el número!";
            label_Info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(260, 163);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Mete el numerito";
            textBoxInput.Size = new Size(412, 23);
            textBoxInput.TabIndex = 1;
            // 
            // label_Intentos
            // 
            label_Intentos.AutoSize = true;
            label_Intentos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Intentos.Location = new Point(418, 244);
            label_Intentos.Name = "label_Intentos";
            label_Intentos.Size = new Size(69, 21);
            label_Intentos.TabIndex = 2;
            label_Intentos.Text = "Intentos:";
            // 
            // buttonAction
            // 
            buttonAction.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAction.Location = new Point(376, 326);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(153, 56);
            buttonAction.TabIndex = 3;
            buttonAction.Text = "A Tope!";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { Label_Debug });
            statusStrip1.Location = new Point(0, 499);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(886, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // Label_Debug
            // 
            Label_Debug.Name = "Label_Debug";
            Label_Debug.Size = new Size(87, 17);
            Label_Debug.Text = "NumeroOculto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 521);
            Controls.Add(statusStrip1);
            Controls.Add(buttonAction);
            Controls.Add(label_Intentos);
            Controls.Add(textBoxInput);
            Controls.Add(label_Info);
            Name = "Form1";
            Text = "JuegoAdivinación";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Info;
        private TextBox textBoxInput;
        private Label label_Intentos;
        private Button buttonAction;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Label_Debug;
    }
}