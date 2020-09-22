namespace Base64
{
    partial class FrmBase64
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase64));
            this.btnToBase64 = new System.Windows.Forms.Button();
            this.btnFromBase64 = new System.Windows.Forms.Button();
            this.btnClearTextboxes = new System.Windows.Forms.Button();
            this.tsmiCopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearTextbox = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInputMessage = new System.Windows.Forms.TextBox();
            this.cmsTextboxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearTextboxes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOutputMessage = new System.Windows.Forms.TextBox();
            this.cmsTextboxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToBase64
            // 
            this.btnToBase64.BackColor = System.Drawing.Color.Black;
            this.btnToBase64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToBase64.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToBase64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnToBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBase64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBase64.ForeColor = System.Drawing.Color.White;
            this.btnToBase64.Location = new System.Drawing.Point(12, 156);
            this.btnToBase64.Name = "btnToBase64";
            this.btnToBase64.Size = new System.Drawing.Size(165, 50);
            this.btnToBase64.TabIndex = 3;
            this.btnToBase64.TabStop = false;
            this.btnToBase64.Text = "To Base64";
            this.btnToBase64.UseVisualStyleBackColor = false;
            this.btnToBase64.Click += new System.EventHandler(this.BtnToBase64_Click);
            // 
            // btnFromBase64
            // 
            this.btnFromBase64.BackColor = System.Drawing.Color.Black;
            this.btnFromBase64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFromBase64.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFromBase64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFromBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromBase64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromBase64.ForeColor = System.Drawing.Color.White;
            this.btnFromBase64.Location = new System.Drawing.Point(367, 156);
            this.btnFromBase64.Name = "btnFromBase64";
            this.btnFromBase64.Size = new System.Drawing.Size(165, 50);
            this.btnFromBase64.TabIndex = 4;
            this.btnFromBase64.TabStop = false;
            this.btnFromBase64.Text = "From Base64";
            this.btnFromBase64.UseVisualStyleBackColor = false;
            this.btnFromBase64.Click += new System.EventHandler(this.BtnFromBase64_Click);
            // 
            // btnClearTextboxes
            // 
            this.btnClearTextboxes.BackColor = System.Drawing.Color.Black;
            this.btnClearTextboxes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearTextboxes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearTextboxes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
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
            this.btnClearTextboxes.Click += new System.EventHandler(this.BtnClearTextboxes_Click);
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
            this.txtInputMessage.BackColor = System.Drawing.Color.White;
            this.txtInputMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputMessage.ContextMenuStrip = this.cmsTextboxMenu;
            this.txtInputMessage.ForeColor = System.Drawing.Color.Black;
            this.txtInputMessage.Location = new System.Drawing.Point(12, 12);
            this.txtInputMessage.MaxLength = 0;
            this.txtInputMessage.Multiline = true;
            this.txtInputMessage.Name = "txtInputMessage";
            this.txtInputMessage.Size = new System.Drawing.Size(520, 138);
            this.txtInputMessage.TabIndex = 8;
            this.txtInputMessage.TabStop = false;
            this.txtInputMessage.TextChanged += new System.EventHandler(this.TxtInputMessage_TextChanged);
            // 
            // cmsTextboxMenu
            // 
            this.cmsTextboxMenu.BackColor = System.Drawing.Color.White;
            this.cmsTextboxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmsTextboxMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTextboxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyPassword,
            this.tsmiClearTextboxes,
            this.tsmiClearClipboard});
            this.cmsTextboxMenu.Name = "passwordContextMenu";
            this.cmsTextboxMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsTextboxMenu.Size = new System.Drawing.Size(188, 82);
            // 
            // tsmiCopyPassword
            // 
            this.tsmiCopyPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiCopyPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiCopyPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiCopyPassword.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmiCopyPassword.Name = "tsmiCopyPassword";
            this.tsmiCopyPassword.Size = new System.Drawing.Size(187, 26);
            this.tsmiCopyPassword.Text = "Copy Text";
            this.tsmiCopyPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsmiCopyPassword.Click += new System.EventHandler(this.TsmiCopyPassword_Click);
            // 
            // tsmiClearTextboxes
            // 
            this.tsmiClearTextboxes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiClearTextboxes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiClearTextboxes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiClearTextboxes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmiClearTextboxes.Name = "tsmiClearTextboxes";
            this.tsmiClearTextboxes.Size = new System.Drawing.Size(187, 26);
            this.tsmiClearTextboxes.Text = "Clear Textbox";
            this.tsmiClearTextboxes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsmiClearTextboxes.Click += new System.EventHandler(this.TsmiClearTextboxes_Click);
            // 
            // tsmiClearClipboard
            // 
            this.tsmiClearClipboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiClearClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiClearClipboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiClearClipboard.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmiClearClipboard.Name = "tsmiClearClipboard";
            this.tsmiClearClipboard.Size = new System.Drawing.Size(187, 26);
            this.tsmiClearClipboard.Text = "Clear Clipboard";
            this.tsmiClearClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsmiClearClipboard.Click += new System.EventHandler(this.TsmiClearClipboard_Click);
            // 
            // txtOutputMessage
            // 
            this.txtOutputMessage.BackColor = System.Drawing.Color.White;
            this.txtOutputMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputMessage.ContextMenuStrip = this.cmsTextboxMenu;
            this.txtOutputMessage.ForeColor = System.Drawing.Color.Black;
            this.txtOutputMessage.Location = new System.Drawing.Point(12, 212);
            this.txtOutputMessage.MaxLength = 0;
            this.txtOutputMessage.Multiline = true;
            this.txtOutputMessage.Name = "txtOutputMessage";
            this.txtOutputMessage.ReadOnly = true;
            this.txtOutputMessage.Size = new System.Drawing.Size(520, 138);
            this.txtOutputMessage.TabIndex = 9;
            this.txtOutputMessage.TabStop = false;
            this.txtOutputMessage.TextChanged += new System.EventHandler(this.TxtOutputMessage_TextChanged);
            // 
            // FrmBase64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 362);
            this.Controls.Add(this.txtOutputMessage);
            this.Controls.Add(this.txtInputMessage);
            this.Controls.Add(this.btnClearTextboxes);
            this.Controls.Add(this.btnFromBase64);
            this.Controls.Add(this.btnToBase64);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBase64";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64";
            this.Load += new System.EventHandler(this.FrmBase64_Load);
            this.cmsTextboxMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmsTextboxMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyPassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearTextboxes;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearClipboard;
    }
}

