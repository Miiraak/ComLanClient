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
            buttonClose = new Button();
            label4 = new Label();
            textBoxAesKey = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 62);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(208, 22);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxServerIP
            // 
            textBoxServerIP.Location = new Point(12, 103);
            textBoxServerIP.Name = "textBoxServerIP";
            textBoxServerIP.Size = new Size(132, 22);
            textBoxServerIP.TabIndex = 1;
            // 
            // textBoxServerPort
            // 
            textBoxServerPort.Location = new Point(150, 103);
            textBoxServerPort.Name = "textBoxServerPort";
            textBoxServerPort.Size = new Size(70, 22);
            textBoxServerPort.TabIndex = 2;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(12, 177);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(75, 21);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += ButtonConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(77, 14);
            label1.TabIndex = 99;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(84, 14);
            label2.TabIndex = 200;
            label2.Text = "Server IP :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 86);
            label3.Name = "label3";
            label3.Size = new Size(49, 14);
            label3.TabIndex = 3000;
            label3.Text = "Port :";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(147, 177);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 100;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(70, 14);
            label4.TabIndex = 101;
            label4.Text = "AES Key :";
            // 
            // textBoxAesKey
            // 
            textBoxAesKey.Location = new Point(12, 145);
            textBoxAesKey.Name = "textBoxAesKey";
            textBoxAesKey.Size = new Size(208, 22);
            textBoxAesKey.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 103;
            label5.Text = "ComLan - Login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 21);
            label6.Name = "label6";
            label6.Size = new Size(231, 14);
            label6.TabIndex = 3001;
            label6.Text = "________________________________";
            // 
            // ComlanLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(234, 210);
            Controls.Add(label5);
            Controls.Add(textBoxAesKey);
            Controls.Add(label4);
            Controls.Add(buttonClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxServerPort);
            Controls.Add(textBoxServerIP);
            Controls.Add(textBoxUsername);
            Controls.Add(label6);
            Cursor = Cursors.Cross;
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ComlanLogin";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button buttonClose;
        private Label label4;
        private TextBox textBoxAesKey;
        private Label label5;
        private Label label6;
    }
}