using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad4_RS232
{
    public partial class Receiver : Form
    {
        public static Receiver instance;
        string textInBinary = "";
        const int ONE_CHAR_FRAME = 11; // start bit + 1 byte + 2 stop bits
        const int ONE_BYTE = 8;
        public Receiver()
        {
            InitializeComponent();
            instance = this;
        }
        public void GetBinaryCode(string recievedBinaryText)
        {
            textInBinary = recievedBinaryText;
            TextInBinaryTextbox.Text = textInBinary;
            if (0 != CheckForError())
            {
                DecodedTextTextbox.Text = "BLAD";
            }
            DecodedTextTextbox.Text = DecodeRS232Frame();
        }

        int CheckForStartBitError()
        {
            for (int i = 0; i < textInBinary.Length; i += ONE_CHAR_FRAME)
            {
                if (0 != textInBinary[i])
                {
                    return i / ONE_CHAR_FRAME; //return the number of first sign in which there is an error
                }
            }
            return 0; //no error
        }
        int CheckForStopBitError()
        {
            for (int i = 9; i < textInBinary.Length; i += ONE_CHAR_FRAME) //the first stop bit
            {
                if (1 != textInBinary[i])
                {
                    return i / ONE_CHAR_FRAME; //return the number of the first sign in which there is an error
                }
            }
            for (int i = 10; i < textInBinary.Length; i += ONE_CHAR_FRAME) //the second stop bit
            {
                if (1 != textInBinary[i])
                {
                    return i / ONE_CHAR_FRAME; //return the number of the first sign in which there is an error
                }
            }
            return 0;
        }
        int CheckForError() //will terminate at first error
        {
            int retVal = 0;
            retVal = CheckForStartBitError();
            if (0 == retVal) //no error in the first check
            {
                retVal = CheckForStopBitError();
            }
            return retVal;
        }
        string DecodeRS232Frame()
        {
            char dedodedSign = '\0';
            string decodedText = "";
            string asciiSign = "";
            for (int i = 1; i < textInBinary.Length; i += ONE_CHAR_FRAME)
            {
                dedodedSign = '\0';
                asciiSign = textInBinary.Substring(i, ONE_BYTE);
                for (int j = 0; j < ONE_BYTE ; j++)
                {
                    if (48 == asciiSign[j]) //48 is '0' in ascii (that is lazy method)
                    {
                    dedodedSign += (char)(0 * Math.Pow(2, j));
                    }
                    else if ((49 == asciiSign[j])) //49 is '1' in ascii (that is lazy method)
                    {
                    dedodedSign += (char)(1 * Math.Pow(2, j));
                    }
                    else
                    {
                        //error
                    }
                }
            decodedText += dedodedSign;
            }
            return decodedText;
        }

    }
}
