﻿namespace Comlan
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            richTextBoxChannel = new RichTextBox();
            buttonAddFile = new Button();
            buttonSend = new Button();
            TextBoxWrite = new TextBox();
            label2 = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // richTextBoxChannel
            // 
            richTextBoxChannel.Location = new Point(12, 42);
            richTextBoxChannel.Name = "richTextBoxChannel";
            richTextBoxChannel.ReadOnly = true;
            richTextBoxChannel.Size = new Size(386, 333);
            richTextBoxChannel.TabIndex = 0;
            richTextBoxChannel.Text = "";
            // 
            // buttonAddFile
            // 
            buttonAddFile.FlatAppearance.BorderSize = 0;
            buttonAddFile.FlatStyle = FlatStyle.Flat;
            buttonAddFile.Image = (Image)resources.GetObject("buttonAddFile.Image");
            buttonAddFile.Location = new Point(368, 381);
            buttonAddFile.Name = "buttonAddFile";
            buttonAddFile.Size = new Size(30, 28);
            buttonAddFile.TabIndex = 2;
            buttonAddFile.UseVisualStyleBackColor = true;
            buttonAddFile.Click += ButtonAddFile_Click;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = SystemColors.Control;
            buttonSend.BackgroundImage = (Image)resources.GetObject("buttonSend.BackgroundImage");
            buttonSend.BackgroundImageLayout = ImageLayout.Center;
            buttonSend.FlatAppearance.BorderSize = 0;
            buttonSend.FlatStyle = FlatStyle.Flat;
            buttonSend.Location = new Point(320, 381);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(30, 28);
            buttonSend.TabIndex = 3;
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += ButtonSend_Click;
            // 
            // TextBoxWrite
            // 
            TextBoxWrite.BorderStyle = BorderStyle.FixedSingle;
            TextBoxWrite.Location = new Point(12, 385);
            TextBoxWrite.Name = "TextBoxWrite";
            TextBoxWrite.PlaceholderText = "Please enter message ";
            TextBoxWrite.Size = new Size(290, 22);
            TextBoxWrite.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 7;
            label2.Text = "Comlan - v1.0.0";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Transparent;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.icons8_close_24;
            buttonClose.Location = new Point(368, 8);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(30, 30);
            buttonClose.TabIndex = 8;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(410, 420);
            Controls.Add(buttonClose);
            Controls.Add(label2);
            Controls.Add(TextBoxWrite);
            Controls.Add(buttonSend);
            Controls.Add(buttonAddFile);
            Controls.Add(richTextBoxChannel);
            Cursor = Cursors.Cross;
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Main";
            Text = "Lan Communication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxChannel;
        private Button buttonAddFile;
        private Button buttonSend;
        private TextBox TextBoxWrite;
        private Label label2;
        private Button buttonClose;
    }
}
