namespace WindowsFormsApplication1
{
    partial class oWyniki
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
            this.SuspendLayout();
            // 
            // bPowrot
            // 
            this.bPowrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.bPowrot.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPowrot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.bPowrot.Location = new System.Drawing.Point(149, 440);
            this.bPowrot.Name = "bPowrot";
            this.bPowrot.Size = new System.Drawing.Size(584, 50);
            this.bPowrot.TabIndex = 0;
            this.bPowrot.Text = "Powrót";
            this.bPowrot.UseVisualStyleBackColor = false;
            this.bPowrot.Click += new System.EventHandler(this.bPowrot_Click);
            // 
            // oWyniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tlo2;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.bPowrot);
            this.Name = "oWyniki";
            this.Text = "oWyniki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oWyniki_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPowrot;
    }
}