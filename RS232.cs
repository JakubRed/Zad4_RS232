namespace Zad4_RS232
{
    public partial class RS232 : Form
    {
        string inputText = "";
        string convertedText = "";
        public RS232()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            Receiver receiver = new Receiver();
            receiver.StartPosition = FormStartPosition.Manual;
            receiver.Location = new System.Drawing.Point(850, 100);
            receiver.Show();
        }
        private string ConvertChar(char sign)
        {
            string charInBinary = "0";
            int bitCounter = 0;
            while (bitCounter < 8)
            {
                if (sign > 0)
                {
                    charInBinary += sign % 2;
                    sign = (char)(sign / 2);
                    bitCounter++;
                }
                else
                {
                    charInBinary += "0";
                    bitCounter++;
                }
            }
            charInBinary += "11";

            return charInBinary;

        }
        public void classa()
        {

        }
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            inputText = TextInLetters.Text;
            convertedText = ConvertingToRs232Protocol(inputText);
            TextInBinary.Text = convertedText;
        }

        private string ConvertingToRs232Protocol(string inputText)
        {
            string convertedTestInside = "";
            for (int i = 0; i < inputText.Length; i++)
            {
                convertedTestInside += ConvertChar(inputText[i]);
            }
            return convertedTestInside;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (convertedText != "")
            {
                Receiver.instance.GetBinaryCode(convertedText);
            }
        }
    }
}