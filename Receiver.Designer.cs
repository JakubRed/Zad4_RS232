namespace Zad4_RS232
{
    public partial class Receiver
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
            ReceivedBinaryText = new TextBox();
            DecodedText = new TextBox();
            TextInBinaryTextbox = new TextBox();
            DecodedTextTextbox = new TextBox();
            SuspendLayout();
            // 
            // ReceivedBinaryText
            // 
            ReceivedBinaryText.BackColor = Color.FromArgb(209, 182, 153);
            ReceivedBinaryText.BorderStyle = BorderStyle.None;
            ReceivedBinaryText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReceivedBinaryText.Location = new Point(39, 85);
            ReceivedBinaryText.Name = "ReceivedBinaryText";
            ReceivedBinaryText.Size = new Size(460, 22);
            ReceivedBinaryText.TabIndex = 0;
            ReceivedBinaryText.Text = "Odebrany kod binarny:";
            // 
            // DecodedText
            // 
            DecodedText.BackColor = Color.FromArgb(209, 182, 153);
            DecodedText.BorderStyle = BorderStyle.None;
            DecodedText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DecodedText.Location = new Point(39, 258);
            DecodedText.Name = "DecodedText";
            DecodedText.Size = new Size(460, 22);
            DecodedText.TabIndex = 1;
            DecodedText.Text = "Odkodowany test:";
            // 
            // TextInBinaryTextbox
            // 
            TextInBinaryTextbox.BackColor = SystemColors.ControlLight;
            TextInBinaryTextbox.BorderStyle = BorderStyle.None;
            TextInBinaryTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextInBinaryTextbox.Location = new Point(39, 113);
            TextInBinaryTextbox.Multiline = true;
            TextInBinaryTextbox.Name = "TextInBinaryTextbox";
            TextInBinaryTextbox.Size = new Size(460, 120);
            TextInBinaryTextbox.TabIndex = 2;
            // 
            // DecodedTextTextbox
            // 
            DecodedTextTextbox.BackColor = SystemColors.ControlLight;
            DecodedTextTextbox.BorderStyle = BorderStyle.None;
            DecodedTextTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DecodedTextTextbox.Location = new Point(39, 286);
            DecodedTextTextbox.Multiline = true;
            DecodedTextTextbox.Name = "DecodedTextTextbox";
            DecodedTextTextbox.ScrollBars = ScrollBars.Vertical;
            DecodedTextTextbox.Size = new Size(460, 120);
            DecodedTextTextbox.TabIndex = 3;
            // 
            // Receiver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 182, 153);
            ClientSize = new Size(534, 450);
            Controls.Add(DecodedTextTextbox);
            Controls.Add(TextInBinaryTextbox);
            Controls.Add(DecodedText);
            Controls.Add(ReceivedBinaryText);
            Name = "Receiver";
            Text = "Odbiornik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox ReceivedBinaryText;
        private TextBox DecodedText;
        private TextBox TextInBinaryTextbox;
        private TextBox DecodedTextTextbox;
    }
}