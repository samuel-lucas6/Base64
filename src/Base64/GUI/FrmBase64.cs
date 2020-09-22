using System;
using System.Drawing;
using System.Windows.Forms;

/*  
    Base64: Convert strings to/from Base64 on Windows.
    Copyright(C) 2020 Samuel Lucas

    Permission is hereby granted, free of charge, to any person obtaining 
    a copy of this software and associated documentation files (the "Software"), 
    to deal in the Software without restriction, including without limitation 
    the rights to use, copy, modify, merge, publish, distribute, sublicense, 
    and/or sell copies of the Software, and to permit persons to whom the 
    Software is furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included
    in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
    OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

namespace Base64
{
    public partial class FrmBase64 : Form
    {
        public FrmBase64()
        {
            InitializeComponent();
        }

        private void FrmBase64_Load(object sender, EventArgs e)
        {
            ApplyDarkTheme();
        }

        private void BtnToBase64_Click(object sender, EventArgs e)
        {
            RemoveButtonHighlight();
            bool encode = true;
            char[] message = GetInputMessage();
            ConvertInput(encode, message);
        }

        private void BtnFromBase64_Click(object sender, EventArgs e)
        {
            RemoveButtonHighlight();
            bool encode = false;
            char[] message = GetInputMessage();
            ConvertInput(encode, message);
        }

        private char[] GetInputMessage()
        {
            return txtInputMessage.Text.ToCharArray();
        }

        private void BtnClearTextboxes_Click(object sender, EventArgs e)
        {
            RemoveButtonHighlight();
            txtInputMessage.Clear();
            txtInputMessage.ClearUndo();
            txtOutputMessage.Clear();
            txtOutputMessage.ClearUndo();
        }

        private void RemoveButtonHighlight()
        {
            txtInputMessage.Focus();
            txtInputMessage.SelectionStart = txtInputMessage.Text.Length;
        }

        private void ConvertInput(bool encode, char[] message)
        {
            if (message.Length > 0)
            {
                char[] outputMessage;
                if (encode == true)
                {
                    outputMessage = Base64.EncodeMessage(message);
                }
                else
                {
                    outputMessage = Base64.DecodeMessage(message);
                }
                OutputConversion(outputMessage);
                Array.Clear(message, 0, message.Length);
            }
        }

        private void OutputConversion(char[] outputMessage)
        {
            if (outputMessage != null)
            {
                txtOutputMessage.Text = new string(outputMessage);
                Array.Clear(outputMessage, 0, outputMessage.Length);
            }
        }

        private void TxtInputMessage_TextChanged(object sender, EventArgs e)
        {
            ShowScrollBar(txtInputMessage);
        }

        private void TxtOutputMessage_TextChanged(object sender, EventArgs e)
        {
            ShowScrollBar(txtOutputMessage);
        }

        private static void ShowScrollBar(TextBox textbox)
        {
            if (textbox.Lines.Length > 6 || textbox.Text.Length > 486)
            {
                textbox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                textbox.ScrollBars = ScrollBars.None;
            }
        }

        private void TsmiCopyPassword_Click(object sender, EventArgs e)
        {
            SharedContextMenu.CopyTextbox(sender);
        }

        private void TsmiClearTextboxes_Click(object sender, EventArgs e)
        {
            SharedContextMenu.ClearTextbox(sender);
        }

        private void TsmiClearClipboard_Click(object sender, EventArgs e)
        {
            EditClipboard.ClearClipboard();
        }

        private void ApplyDarkTheme()
        {
            const int red = 44;
            const int green = 47;
            const int blue = 51;
            this.BackColor = Color.FromArgb(red, green, blue);
            txtInputMessage.BackColor = Color.DimGray;
            txtInputMessage.ForeColor = Color.White;
            txtOutputMessage.BackColor = Color.DimGray;
            txtOutputMessage.ForeColor = Color.White;
            btnToBase64.BackColor = Color.FromArgb(red, green, blue);
            btnToBase64.ForeColor = Color.White;
            btnToBase64.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFromBase64.BackColor = Color.FromArgb(red, green, blue);
            btnFromBase64.ForeColor = Color.White;
            btnFromBase64.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClearTextboxes.BackColor = Color.FromArgb(red, green, blue);
            btnClearTextboxes.ForeColor = Color.White;
            btnClearTextboxes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SharedContextMenu.DarkContextMenu(cmsTextboxMenu, red, green, blue);
        }
    }
}
