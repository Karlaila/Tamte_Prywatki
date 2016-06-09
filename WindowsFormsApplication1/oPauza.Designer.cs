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
            this.SuspendLayout();
            // 
            // bPowrotKurs
            // 
            this.bPowrotKurs.Location = new System.Drawing.Point(68, 25);
            this.bPowrotKurs.Name = "bPowrotKurs";
            this.bPowrotKurs.Size = new System.Drawing.Size(139, 23);
            this.bPowrotKurs.TabIndex = 0;
            this.bPowrotKurs.Text = "powrót do kursu";
            this.bPowrotKurs.UseVisualStyleBackColor = true;
            this.bPowrotKurs.Click += new System.EventHandler(this.bPowrotKurs_Click);
            // 
            // oPauza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bPowrotKurs);
            this.Name = "oPauza";
            this.Text = "oPauza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oPauza_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPowrotKurs;
    }
}