namespace Base64
{
    partial class frmBase64
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase64));
            this.btnToBase64 = new System.Windows.Forms.Button();
            this.btnFromBase64 = new System.Windows.Forms.Button();
            this.btnClearTextboxes = new System.Windows.Forms.Button();
            this.tsmiCopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearTextbox = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInputMessage = new System.Windows.Forms.TextBox();
            this.txtOutputMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToBase64
            // 
            this.btnToBase64.BackColor = System.Drawing.Color.Black;
            this.btnToBase64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBase64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBase64.ForeColor = System.Drawing.Color.White;
            this.btnToBase64.Location = new System.Drawing.Point(14, 156);
            this.btnToBase64.Name = "btnToBase64";
            this.btnToBase64.Size = new System.Drawing.Size(165, 50);
            this.btnToBase64.TabIndex = 3;
            this.btnToBase64.TabStop = false;
            this.btnToBase64.Text = "To Base64";
            this.btnToBase64.UseVisualStyleBackColor = false;
            this.btnToBase64.Click += new System.EventHandler(this.btnToBase64_Click);
            // 
            // btnFromBase64
            // 
            this.btnFromBase64.BackColor = System.Drawing.Color.Black;
            this.btnFromBase64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFromBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromBase64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromBase64.ForeColor = System.Drawing.Color.White;
            this.btnFromBase64.Location = new System.Drawing.Point(366, 156);
            this.btnFromBase64.Name = "btnFromBase64";
            this.btnFromBase64.Size = new System.Drawing.Size(165, 50);
            this.btnFromBase64.TabIndex = 4;
            this.btnFromBase64.TabStop = false;
            this.btnFromBase64.Text = "From Base64";
            this.btnFromBase64.UseVisualStyleBackColor = false;
            this.btnFromBase64.Click += new System.EventHandler(this.btnFromBase64_Click);
            // 
            // btnClearTextboxes
            // 
            this.btnClearTextboxes.BackColor = System.Drawing.Color.Black;
            this.btnClearTextboxes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearTextboxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTextboxes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTextboxes.ForeColor = System.Drawing.Color.White;
            this.btnClearTextboxes.Location = new System.Drawing.Point(190, 156);
            this.btnClearTextboxes.Name = "btnClearTextboxes";
            this.btnClearTextboxes.Size = new System.Drawing.Size(165, 50);
            this.btnClearTextboxes.TabIndex = 7;
            this.btnClearTextboxes.TabStop = false;
            this.btnClearTextboxes.Text = "Clear Textboxes";
            this.btnClearTextboxes.UseVisualStyleBackColor = false;
            this.btnClearTextboxes.Click += new System.EventHandler(this.btnClearTextboxes_Click);
            // 
            // tsmiCopyText
            // 
            this.tsmiCopyText.Name = "tsmiCopyText";
            this.tsmiCopyText.Size = new System.Drawing.Size(32, 19);
            // 
            // tsmiClearTextbox
            // 
            this.tsmiClearTextbox.Name = "tsmiClearTextbox";
            this.tsmiClearTextbox.Size = new System.Drawing.Size(32, 19);
            // 
            // txtInputMessage
            // 
            this.txtInputMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputMessage.Location = new System.Drawing.Point(14, 13);
            this.txtInputMessage.MaxLength = 0;
            this.txtInputMessage.Multiline = true;
            this.txtInputMessage.Name = "txtInputMessage";
            this.txtInputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputMessage.Size = new System.Drawing.Size(517, 136);
            this.txtInputMessage.TabIndex = 8;
            this.txtInputMessage.TabStop = false;
            // 
            // txtOutputMessage
            // 
            this.txtOutputMessage.BackColor = System.Drawing.Color.White;
            this.txtOutputMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputMessage.Location = new System.Drawing.Point(14, 212);
            this.txtOutputMessage.MaxLength = 0;
            this.txtOutputMessage.Multiline = true;
            this.txtOutputMessage.Name = "txtOutputMessage";
            this.txtOutputMessage.ReadOnly = true;
            this.txtOutputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputMessage.Size = new System.Drawing.Size(517, 136);
            this.txtOutputMessage.TabIndex = 9;
            this.txtOutputMessage.TabStop = false;
            // 
            // frmBase64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.txtOutputMessage);
            this.Controls.Add(this.txtInputMessage);
            this.Controls.Add(this.btnClearTextboxes);
            this.Controls.Add(this.btnFromBase64);
            this.Controls.Add(this.btnToBase64);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBase64";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToBase64;
        private System.Windows.Forms.Button btnFromBase64;
        private System.Windows.Forms.Button btnClearTextboxes;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyText;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearTextbox;
        private System.Windows.Forms.TextBox txtInputMessage;
        private System.Windows.Forms.TextBox txtOutputMessage;
    }
}

