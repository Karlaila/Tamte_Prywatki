namespace WindowsFormsApplication1
{
    partial class oPomoc
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
            this.bPowrot = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPowrot
            // 
            this.bPowrot.Location = new System.Drawing.Point(92, 174);
            this.bPowrot.Name = "bPowrot";
            this.bPowrot.Size = new System.Drawing.Size(99, 23);
            this.bPowrot.TabIndex = 0;
            this.bPowrot.Text = "Powrót do kursu";
            this.bPowrot.UseVisualStyleBackColor = true;
            this.bPowrot.Click += new System.EventHandler(this.bPowrot_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 141);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // bMenu
            // 
            this.bMenu.Location = new System.Drawing.Point(92, 203);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(99, 23);
            this.bMenu.TabIndex = 2;
            this.bMenu.Text = "Powrót do menu";
            this.bMenu.UseVisualStyleBackColor = true;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // oPomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bMenu);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bPowrot);
            this.Name = "oPomoc";
            this.Text = "oPomoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oPomoc_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPowrot;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bMenu;
    }
}