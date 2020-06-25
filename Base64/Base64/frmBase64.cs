using System;
using System.Text;
using System.Windows.Forms;

//Base64:  Convert strings to/from Base64 on Windows.
//    Copyright(C) 2020 Samuel Lucas

//    Permission is hereby granted, free of charge, to any person obtaining 
//    a copy of this software and associated documentation files (the "Software"), 
//    to deal in the Software without restriction, including without limitation 
//    the rights to use, copy, modify, merge, publish, distribute, sublicense, 
//    and/or sell copies of the Software, and to permit persons to whom the 
//    Software is furnished to do so, subject to the following conditions:

//    The above copyright notice and this permission notice shall be included
//    in all copies or substantial portions of the Software.

//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
//    OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.

namespace Base64
{
    public partial class frmBase64 : Form
    {
        public frmBase64()
        {
            InitializeComponent();
        }

        private void btnToBase64_Click(object sender, EventArgs e)
        {
            bool encode = true;
            checkTextboxNotEmpty(encode);
        }

        private void btnClearTextboxes_Click(object sender, EventArgs e)
        {
            txtInputMessage.Clear();
            txtInputMessage.ClearUndo();
            txtOutputMessage.Clear();
            txtOutputMessage.ClearUndo();
        }

        private void btnFromBase64_Click(object sender, EventArgs e)
        {
            bool encode = false;
            checkTextboxNotEmpty(encode);
        }

        private void checkTextboxNotEmpty(bool encode)
        {
            if (!string.IsNullOrEmpty(txtInputMessage.Text))
            {
                char[] message = txtInputMessage.Text.ToCharArray();
                char[] output = new char[message.Length];
                if (encode == true)
                {
                    output = encodeMessage(message);
                }
                else
                {
                    output = decodeMessage(message);
                }
                if (output != null)
                {
                    txtOutputMessage.Text = new string(output);
                }
                Array.Clear(output, 0, output.Length);
                output = null;
            }
        }

        private static char[] encodeMessage(char[] message)
        {
            try
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                string base64 = Convert.ToBase64String(messageBytes);
                Array.Clear(messageBytes, 0, messageBytes.Length);
                messageBytes = null;
                return base64.ToCharArray();
            }
            catch (EncoderFallbackException)
            {
                MessageBox.Show("Error: Unable to encode characters.");
                return null;
            }
        }

        private static char[] decodeMessage(char[] message)
        {
            try
            {
                string base64 = new string(message);
                byte[] messageBytes = Convert.FromBase64String(base64);
                char[] decodedMessage = Encoding.UTF8.GetChars(messageBytes);
                Array.Clear(messageBytes, 0, messageBytes.Length);
                messageBytes = null;
                return decodedMessage;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Message is not in a valid Base64 format.");
                return null;
            }
            catch (EncoderFallbackException)
            {
                MessageBox.Show("Error: Unable to decode characters.");
                return null;
            }
        }
    }
}
