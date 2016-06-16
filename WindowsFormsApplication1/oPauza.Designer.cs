namespace WindowsFormsApplication1
{
    partial class oPauza
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
            this.bPowrotKurs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bPowrotKurs
            // 
            this.bPowrotKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.bPowrotKurs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPowrotKurs.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPowrotKurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.bPowrotKurs.Location = new System.Drawing.Point(76, 320);
            this.bPowrotKurs.Name = "bPowrotKurs";
            this.bPowrotKurs.Size = new System.Drawing.Size(329, 45);
            this.bPowrotKurs.TabIndex = 0;
            this.bPowrotKurs.Text = "powrót do kursu";
            this.bPowrotKurs.UseVisualStyleBackColor = false;
            this.bPowrotKurs.Click += new System.EventHandler(this.bPowrotKurs_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.button1.Location = new System.Drawing.Point(76, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "powrót do menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(76, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 227);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // oPauza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tlo2;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bPowrotKurs);
            this.Name = "oPauza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oPauza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oPauza_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPowrotKurs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}