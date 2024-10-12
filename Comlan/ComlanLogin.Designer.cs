namespace Comlan
{
    partial class ComlanLogin
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
            textBoxUsername = new TextBox();
            textBoxServerIP = new TextBox();
            textBoxServerPort = new TextBox();
            buttonConnect = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 27);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(208, 23);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxServerIP
            // 
            textBoxServerIP.Location = new Point(12, 71);
            textBoxServerIP.Name = "textBoxServerIP";
            textBoxServerIP.Size = new Size(132, 23);
            textBoxServerIP.TabIndex = 1;
            // 
            // textBoxServerPort
            // 
            textBoxServerPort.Location = new Point(150, 71);
            textBoxServerPort.Name = "textBoxServerPort";
            textBoxServerPort.Size = new Size(70, 23);
            textBoxServerPort.TabIndex = 2;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(80, 105);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(75, 23);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += ButtonConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 99;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Server IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 53);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Server port :";
            // 
            // ComlanLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 138);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxServerPort);
            Controls.Add(textBoxServerIP);
            Controls.Add(textBoxUsername);
            Name = "ComlanLogin";
            Text = "ConnexionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxServerIP;
        private TextBox textBoxServerPort;
        private Button buttonConnect;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}