namespace WindowsFormsApplication1
{
    partial class oInformacje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oInformacje));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.tekst = new System.Windows.Forms.RichTextBox();
            this.bPowrot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(233, 22);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(142, 227);
            this.player.TabIndex = 0;
            // 
            // tekst
            // 
            this.tekst.Location = new System.Drawing.Point(13, 22);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(201, 183);
            this.tekst.TabIndex = 1;
            this.tekst.Text = "";
            // 
            // bPowrot
            // 
            this.bPowrot.Location = new System.Drawing.Point(74, 226);
            this.bPowrot.Name = "bPowrot";
            this.bPowrot.Size = new System.Drawing.Size(75, 23);
            this.bPowrot.TabIndex = 2;
            this.bPowrot.Text = "Powrót";
            this.bPowrot.UseVisualStyleBackColor = true;
            this.bPowrot.Click += new System.EventHandler(this.bPowrot_Click);
            // 
            // oInformacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.bPowrot);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.player);
            this.Name = "oInformacje";
            this.Text = "oInformacje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oInformacje_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.RichTextBox tekst;
        private System.Windows.Forms.Button bPowrot;
    }
}