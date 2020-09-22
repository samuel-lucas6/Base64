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
    public static class SharedContextMenu
    {
        public static void DarkContextMenu(ContextMenuStrip contextMenu, int red, int green, int blue)
        {
            if (contextMenu == null)
            {
                throw new ArgumentNullException(nameof(contextMenu));
            }
            contextMenu.BackColor = Color.FromArgb(red, green, blue);
            foreach (ToolStripItem toolStripItem in contextMenu.Items)
            {
                toolStripItem.ForeColor = Color.White;
                toolStripItem.BackColor = Color.FromArgb(red, green, blue);
            }
        }

        public static void CopyTextbox(object sender)
        {
            Control sourceControl = GetSourceControl(sender);
            if (sourceControl != null && !string.IsNullOrEmpty(sourceControl.Text))
            {
                EditClipboard.SetClipboard(sourceControl.Text);
            }
        }

        public static void ClearTextbox(object sender)
        {
            Control sourceControl = GetSourceControl(sender);
            if (sourceControl != null)
            {
                sourceControl.Text = string.Empty;
            }
        }

        private static Control GetSourceControl(object sender)
        {
            // Return which textbox the context menu was used on
            if (sender is ToolStripItem toolStripItem)
            {
                if (toolStripItem.Owner is ContextMenuStrip owner)
                {
                    Control sourceControl = owner.SourceControl;
                    return sourceControl;
                }
            }
            return null;
        }
    }
}
