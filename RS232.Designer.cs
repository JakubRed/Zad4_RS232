namespace Zad4_RS232
{
    partial class RS232
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
            ConvertButton = new Button();
            SendButton = new Button();
            EnterTheString = new TextBox();
            TextInLetters = new TextBox();
            TextInBinary = new TextBox();
            ConvertedString = new TextBox();
            SuspendLayout();
            // 
            // ConvertButton
            // 
            ConvertButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ConvertButton.Location = new Point(536, 106);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(148, 57);
            ConvertButton.TabIndex = 0;
            ConvertButton.Text = "Przekonwertuj";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // SendButton
            // 
            SendButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SendButton.Location = new Point(536, 286);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(148, 57);
            SendButton.TabIndex = 3;
            SendButton.Text = "Wyślij";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // EnterTheString
            // 
            EnterTheString.BackColor = SystemColors.ActiveCaption;
            EnterTheString.BorderStyle = BorderStyle.None;
            EnterTheString.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnterTheString.Location = new Point(39, 85);
            EnterTheString.Name = "EnterTheString";
            EnterTheString.Size = new Size(460, 22);
            EnterTheString.TabIndex = 6;
            EnterTheString.Text = "Podaj ciąg znaków:";
            // 
            // TextInLetters
            // 
            TextInLetters.BackColor = SystemColors.ControlLight;
            TextInLetters.BorderStyle = BorderStyle.None;
            TextInLetters.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextInLetters.Location = new Point(39, 113);
            TextInLetters.Multiline = true;
            TextInLetters.Name = "TextInLetters";
            TextInLetters.Size = new Size(460, 120);
            TextInLetters.TabIndex = 7;
            // 
            // TextInBinary
            // 
            TextInBinary.BackColor = SystemColors.ControlLight;
            TextInBinary.BorderStyle = BorderStyle.None;
            TextInBinary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextInBinary.Location = new Point(39, 286);
            TextInBinary.Multiline = true;
            TextInBinary.Name = "TextInBinary";
            TextInBinary.Size = new Size(460, 120);
            TextInBinary.TabIndex = 8;
            // 
            // ConvertedString
            // 
            ConvertedString.BackColor = SystemColors.ActiveCaption;
            ConvertedString.BorderStyle = BorderStyle.None;
            ConvertedString.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConvertedString.Location = new Point(39, 258);
            ConvertedString.Name = "ConvertedString";
            ConvertedString.ScrollBars = ScrollBars.Vertical;
            ConvertedString.Size = new Size(460, 22);
            ConvertedString.TabIndex = 9;
            ConvertedString.Text = "Przekonwertowany ciąg znaków:";
            // 
            // RS232
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(732, 450);
            Controls.Add(ConvertedString);
            Controls.Add(TextInBinary);
            Controls.Add(TextInLetters);
            Controls.Add(EnterTheString);
            Controls.Add(SendButton);
            Controls.Add(ConvertButton);
            Name = "RS232";
            Text = "Nadajnik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConvertButton;
        private Button SendButton;
        private TextBox EnterTheString;
        private TextBox TextInLetters;
        private TextBox TextInBinary;
        private TextBox ConvertedString;
    }
}