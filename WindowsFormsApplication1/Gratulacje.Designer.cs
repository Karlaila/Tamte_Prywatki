namespace WindowsFormsApplication1
{
    partial class Gratulacje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gratulacje));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bPowrot = new System.Windows.Forms.Button();
            this.bPowtorz = new System.Windows.Forms.Button();
            this.bPrzejdz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(283, 30);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(163, 264);
            this.player.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(241, 161);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // bPowrot
            // 
            this.bPowrot.Location = new System.Drawing.Point(65, 197);
            this.bPowrot.Name = "bPowrot";
            this.bPowrot.Size = new System.Drawing.Size(119, 23);
            this.bPowrot.TabIndex = 2;
            this.bPowrot.Text = "Powrót do menu";
            this.bPowrot.UseVisualStyleBackColor = true;
            this.bPowrot.Click += new System.EventHandler(this.bPowrot_Click);
            // 
            // bPowtorz
            // 
            this.bPowtorz.Location = new System.Drawing.Point(65, 226);
            this.bPowtorz.Name = "bPowtorz";
            this.bPowtorz.Size = new System.Drawing.Size(119, 23);
            this.bPowtorz.TabIndex = 3;
            this.bPowtorz.Text = "Powtórz poziom";
            this.bPowtorz.UseVisualStyleBackColor = true;
            this.bPowtorz.Click += new System.EventHandler(this.bPowtorz_Click);
            // 
            // bPrzejdz
            // 
            this.bPrzejdz.Location = new System.Drawing.Point(65, 256);
            this.bPrzejdz.Name = "bPrzejdz";
            this.bPrzejdz.Size = new System.Drawing.Size(119, 38);
            this.bPrzejdz.TabIndex = 4;
            this.bPrzejdz.Text = "Przejdź do kolejnego poziomu";
            this.bPrzejdz.UseVisualStyleBackColor = true;
            this.bPrzejdz.Click += new System.EventHandler(this.bPrzejdz_Click);
            // 
            // Gratulacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 306);
            this.Controls.Add(this.bPrzejdz);
            this.Controls.Add(this.bPowtorz);
            this.Controls.Add(this.bPowrot);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.player);
            this.Name = "Gratulacje";
            this.Text = "Gratulacje";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bPowrot;
        private System.Windows.Forms.Button bPowtorz;
        private System.Windows.Forms.Button bPrzejdz;
    }
}